namespace FreeSR.Gateserver.Network.Handlers.Decoder
{
    using DotNetty.Buffers;
    using DotNetty.Codecs;
    using DotNetty.Transport.Channels;
    using FreeSR.Gateserver.Network.Packet;
    using NLog;

    internal class PacketDecoder : MessageToMessageDecoder<IByteBuffer>
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        protected override void Decode(IChannelHandlerContext context, IByteBuffer message, List<object> output)
        {
            var netPacket = new NetPacket();

            DeserializationResult result;
            if ((result = netPacket.Deserialize(message)) != DeserializationResult.SUCC)
            {
                context.CloseAsync();
                s_log.Info("Closing connection, reason: " + result);

                return;
            }

            output.Add(netPacket);
        }
    }
}
