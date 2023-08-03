namespace FreeSR.Gateserver.Network.Handlers.Encoder
{
    using DotNetty.Buffers;
    using DotNetty.Codecs;
    using DotNetty.Transport.Channels;
    using FreeSR.Gateserver.Network.Packet;
    using NLog;

    internal class PacketEncoder : MessageToByteEncoder<NetPacket>
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        protected override void Encode(IChannelHandlerContext context, NetPacket message, IByteBuffer output)
        {
            output.WriteBytes(message.Buf);
            s_log.Info($"Sent packet with cmdId {message.CmdId}");
        }
    }
}
