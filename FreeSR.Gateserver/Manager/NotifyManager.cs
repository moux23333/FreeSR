namespace FreeSR.Gateserver.Manager
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using Nito.AsyncEx;
    using NLog;
    using System.Collections.Immutable;
    using System.Linq.Expressions;
    using System.Reflection;

    internal static class NotifyManager
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        private static List<Type> s_handlerTypes = new List<Type>();
        private static ImmutableDictionary<int, (HandlerAttribute, HandlerAttribute.HandlerDelegate)> s_notifyReqGroup;

        public static void Init()
        {
            var handlers = ImmutableDictionary.CreateBuilder<int, (HandlerAttribute, HandlerAttribute.HandlerDelegate)>();

            foreach (var type in s_handlerTypes)
            {
                foreach (var method in type.GetMethods())
                {
                    var attribute = method.GetCustomAttribute<HandlerAttribute>();
                    if (attribute == null)
                        continue;

                    var parameterInfo = method.GetParameters();

                    var sessionParameter = Expression.Parameter(typeof(NetSession));
                    var cmdIdParameter = Expression.Parameter(typeof(int));
                    var dataParameter = Expression.Parameter(typeof(object));

                    var call = Expression.Call(method,
                        Expression.Convert(sessionParameter, parameterInfo[0].ParameterType),
                        Expression.Convert(cmdIdParameter, parameterInfo[1].ParameterType),
                        Expression.Convert(dataParameter, parameterInfo[2].ParameterType));

                    var lambda = Expression.Lambda<HandlerAttribute.HandlerDelegate>(call, sessionParameter, cmdIdParameter, dataParameter);

                    if (!handlers.TryGetKey(attribute.CmdID, out _))
                        handlers.Add(attribute.CmdID, (attribute, lambda.Compile()));
                }
            }

            s_notifyReqGroup = handlers.ToImmutable();
        }

        public static void Notify(NetSession session, int cmdId, object data)
        {
            if (s_notifyReqGroup.TryGetValue(cmdId, out var handler))
            {
                AsyncContext.Run(() => handler.Item2.Invoke(session, cmdId, data));
            }
            else
            {
                s_log.Warn($"Can't find handler, cmdId: {cmdId}");
            }
        }

        public static void AddReqGroupHandler(Type type)
        {
            s_handlerTypes.Add(type);
        }
    }
}
