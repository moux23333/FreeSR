namespace FreeSR.Dispatch.Util
{
    using Newtonsoft.Json.Linq;

    internal class DispatchResponseBuilder
    {
        private readonly JObject _jsonObject;

        private DispatchResponseBuilder()
        {
            _jsonObject = new JObject();
        }

        public string Build()
        {
            return _jsonObject.ToString();
        }

        public DispatchResponseBuilder Code(int code)
        {
            _jsonObject["code"] = code;
            return this;
        }

        public DispatchResponseBuilder Retcode(int retcode)
        {
            _jsonObject["retcode"] = retcode;
            return this;
        }

        public DispatchResponseBuilder Message(string message)
        {
            _jsonObject["message"] = message;
            return this;
        }

        public DispatchResponseBuilder Boolean(string field, bool value)
        {
            _jsonObject[field] = value;
            return this;
        }

        public DispatchResponseBuilder String(string field, string value)
        {
            _jsonObject[field] = value;
            return this;
        }

        public DispatchResponseBuilder Int(string field, int value)
        {
            _jsonObject[field] = value;
            return this;
        }

        public DispatchResponseBuilder Array(string field, JArray array)
        {
            _jsonObject[field] = array;
            return this;
        }

        public DispatchResponseBuilder Object(string field, JObject jsonObject)
        {
            _jsonObject[field] = jsonObject;
            return this;
        }

        public static DispatchResponseBuilder Create() => new DispatchResponseBuilder();
    }
}
