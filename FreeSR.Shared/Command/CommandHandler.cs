namespace FreeSR.Shared.Command
{
    using FreeSR.Shared.Command.Context;
    using FreeSR.Shared.Command.Convert;
    using System.Linq.Expressions;
    using System.Reflection;

    public class CommandHandler
    {
        private Delegate _handlerDelegate;
        private readonly List<ICommandParameterConverter> _additionalParameterConverters = new List<ICommandParameterConverter>();

        public CommandHandler(Type type, MethodInfo method)
        {
            InitializeDelegate(type, method);
            InitializeParameters(method);
        }

        private void InitializeDelegate(Type type, MethodInfo method)
        {
            ParameterInfo[] info = method.GetParameters();
            if (info.Length < 1 || !typeof(ICommandContext).IsAssignableFrom(info[0].ParameterType))
                throw new CommandException("");

            ParameterExpression instance = Expression.Parameter(type);

            var parameters = new List<ParameterExpression> { instance };
            parameters.AddRange(info.Select(p => Expression.Parameter(p.ParameterType)));

            MethodCallExpression call = Expression.Call(instance, method, parameters.Skip(1));
            LambdaExpression lambda = Expression.Lambda(call, parameters);
            _handlerDelegate = lambda.Compile();
        }

        private void InitializeParameters(MethodInfo method)
        {
            foreach (Type parameterType in method.GetParameters()
                .Skip(1)
                .Select(p => p.ParameterType))
            {
                ICommandParameterConverter converter = CommandManager.Instance.GetConverter(parameterType);
                if (converter == null)
                    throw new CommandException("");

                _additionalParameterConverters.Add(converter);
            }
        }

        public CommandResult Invoke(ICommandCategory category, ICommandContext context, string[] parameters, uint depth)
        {
            var additionalParameterCount = parameters.Length - depth;
            if (additionalParameterCount < _additionalParameterConverters.Count)
                return CommandResult.Parameter;

            var parameterObjects = new List<object> { category, context };
            for (int i = 0; i < _additionalParameterConverters.Count; i++)
            {
                if (!_additionalParameterConverters[i].TryConvert(parameters[depth + i], out object result))
                    return CommandResult.Parameter;

                parameterObjects.Add(result);
            }

            _handlerDelegate.DynamicInvoke(parameterObjects.ToArray());
            return CommandResult.Ok;
        }
    }
}
