namespace FreeSR.Gateserver.Network.Packet
{
    using DotNetty.Buffers;
    using FreeSR.Gateserver.Network.Factory;
    using ProtoBuf;

    internal class NetPacket
    {
        private const uint HeadMagicConst = 0x9d74c714;
        private const uint TailMagicConst = 0xd7a152c8;

        public int CmdId { get; set; }
        public int HeadLen { get; set; }
        public uint HeadMagic { get; set; }
        public int PacketLen { get; set; }
        public byte[] RawData { get; set; }
        public uint TailMagic { get; set; }
        public object Data { get; set; }
        public IByteBuffer Buf { get; set; }

        public NetPacket()
        {
            // NetPacket.
        }

        public DeserializationResult Deserialize(IByteBuffer buf)
        {
            HeadMagic = buf.ReadUnsignedInt();
            if (HeadMagic != HeadMagicConst)
                return DeserializationResult.MAGIC_MISMATCH;

            CmdId = buf.ReadShort();
            HeadLen = buf.ReadShort();
            PacketLen = buf.ReadInt();

            if (buf.ReadableBytes < HeadLen + PacketLen + 4)
                return DeserializationResult.INVALID_LENGTH;

            RawData = new byte[PacketLen];

            _ = buf.ReadBytes(HeadLen);
            buf.ReadBytes(RawData);

            TailMagic = buf.ReadUnsignedInt();
            if (TailMagic != TailMagicConst)
                return DeserializationResult.MAGIC_MISMATCH;

            Data = ProtoFactory.Deserialize(CmdId, RawData);

            return DeserializationResult.SUCC;
        }

        public void Serialize<T>(IByteBuffer buf) where T : class
        {
            var stream = new MemoryStream();
            Serializer.Serialize(stream, Data as T);
            RawData = stream.ToArray();
            PacketLen = RawData.Length;

            buf.WriteUnsignedShort((ushort)(HeadMagicConst >> 16));
            buf.WriteUnsignedShort(0xc714);
            buf.WriteShort(CmdId);
            buf.WriteShort(HeadLen);
            buf.WriteInt(PacketLen);
            buf.WriteBytes(RawData);
            buf.WriteUnsignedShort((ushort)(TailMagicConst >> 16));
            buf.WriteUnsignedShort(0x52c8);
        }
    }

    internal enum DeserializationResult
    {
        SUCC = 1,
        INVALID_LENGTH,
        MAGIC_MISMATCH
    }
}
