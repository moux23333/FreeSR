namespace FreeSR.Dispatch.Util
{
    using ProtoBuf;

    internal static class ProtobufUtil
    {
        public static byte[] Serialize<T>(T obj) where T : class
        {
            var stream = new MemoryStream();
            Serializer.Serialize(stream, obj);

            return stream.ToArray();
        }
    }
}
