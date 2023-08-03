namespace FreeSR.Shared.Command.Convert
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandParameterConverterAttribute : Attribute
    {
        public Type Type { get; }

        public CommandParameterConverterAttribute(Type type)
        {
            Type = type;
        }
    }
}
