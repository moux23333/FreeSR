namespace FreeSR.Shared.Command.Convert
{
    [CommandParameterConverter(typeof(uint))]
    public class UIntCommandParameterConverter : ICommandParameterConverter
    {
        public bool TryConvert(string parameter, out object result)
        {
            result = null;
            if (!uint.TryParse(parameter, out uint parseResult))
                return false;

            result = parseResult;
            return true;
        }
    }
}
