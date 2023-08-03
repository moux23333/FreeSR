namespace FreeSR.Shared.Command
{
    using System.Reflection;
    using FreeSR.Shared.Command.Context;
    using FreeSR.Shared.Command.Convert;
    using NLog;

    public sealed class CommandManager : Singleton<CommandManager>
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        private readonly Dictionary<Type, ICommandParameterConverter> converters = new Dictionary<Type, ICommandParameterConverter>();
        private readonly Dictionary<string, CommandCategory> categories = new Dictionary<string, CommandCategory>();

        private CommandManager()
        {
            // CommandManager.
        }

        public void Initialize(params Type[] categories)
        {
            InitializeConverters();
            InitializeCategories(categories);
        }

        private void InitializeConverters()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(ICommandParameterConverter).IsAssignableFrom(t)))
            {
                CommandParameterConverterAttribute attribute = type.GetCustomAttribute<CommandParameterConverterAttribute>();
                if (attribute == null)
                    continue;

                ICommandParameterConverter converter = (ICommandParameterConverter)Activator.CreateInstance(type);
                converters.Add(attribute.Type, converter);
            }
        }

        private void InitializeCategories(params Type[] types)
        {
            foreach (Type type in types)
            {
                CommandAttribute attribute = type.GetCustomAttribute<CommandAttribute>();
                if (attribute == null)
                    continue;

                CommandCategory category = (CommandCategory)Activator.CreateInstance(type);
                category.Build();

                categories.Add(attribute.Name, category);
            }
        }

        public ICommandParameterConverter GetConverter(Type type)
        {
            return converters.TryGetValue(type, out ICommandParameterConverter converter) ? converter : null;
        }

        public void Invoke(string command)
        {
            var context = new ConsoleCommandContext();
            Invoke(context, command);
        }

        public void Invoke(ICommandContext context, string command)
        {
            CommandResult result = InvokeResult(context, command);
            if (result != CommandResult.Ok)
                context.SendError(GetError());

            string GetError()
            {
                return result switch
                {
                    CommandResult.Invalid    => "No valid command was found.",
                    CommandResult.Parameter  => "Invalid parameters were provided for the command.",
                    CommandResult.Permission => "You don't have permission to invoke the command.",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }

        private CommandResult InvokeResult(ICommandContext context, string command)
        {
            string[] parameters = command.Split(' ');
            if (categories.TryGetValue(parameters[0], out CommandCategory category))
                return category.Invoke(context, parameters, 1);

            return CommandResult.Invalid;
        }
    }
}
