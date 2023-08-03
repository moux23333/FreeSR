namespace FreeSR.Shared.Command
{
    using FreeSR.Shared.Command.Context;
    using System.Reflection;

    public class CommandCategory : ICommandCategory
    {
        private readonly Dictionary<string, CommandHandler> handlers = new Dictionary<string, CommandHandler>();
        private readonly Dictionary<string, ICommandCategory> categories = new Dictionary<string, ICommandCategory>();

        public void Build()
        {
            Type type = GetType();
            foreach (MethodInfo info in type.GetMethods())
            {
                CommandAttribute attribute = info.GetCustomAttribute<CommandAttribute>();
                if (attribute == null)
                    continue;

                var handler = new CommandHandler(type, info);
                handlers.Add(attribute.Name, handler);
            }

            foreach (Type info in type.GetNestedTypes())
            {
                CommandAttribute attribute = info.GetCustomAttribute<CommandAttribute>();
                if (attribute == null)
                    continue;

                CommandCategory category = (CommandCategory)Activator.CreateInstance(info);
                category.Build();
                categories.Add(attribute.Name, category);
            }
        }

        public CommandResult Invoke(ICommandContext context, string[] parameters, uint depth)
        {
            if (handlers.TryGetValue(parameters[depth], out CommandHandler handler))
                return handler.Invoke(this, context, parameters, depth + 1);
            if (categories.TryGetValue(parameters[depth], out ICommandCategory category))
                return category.Invoke(context, parameters, depth + 1);

            return CommandResult.Invalid;
        }
    }
}
