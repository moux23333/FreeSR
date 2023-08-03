namespace FreeSR.Shared.Command.Convert
{
    [CommandParameterConverter(typeof(string))]
    public class StringCommandParameterConverter : ICommandParameterConverter
    {
        public bool TryConvert(string parameter, out object result)
        {
            result = parameter;
            return true;
        }
    }
}
