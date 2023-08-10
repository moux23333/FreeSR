namespace FreeSR.Gateserver.Network
{
    using DotNetty.Transport.Bootstrapping;
    using DotNetty.Transport.Channels;
    using DotNetty.Transport.Channels.Sockets;
    using FreeSR.Gateserver.Manager;
    using FreeSR.Gateserver.Manager.Handlers;
    using FreeSR.Gateserver.Network.Handlers.Decoder;
    using FreeSR.Gateserver.Network.Handlers.Encoder;
    using FreeSR.Gateserver.Network.Handlers.Manager;
    using FreeSR.Shared;
    using FreeSR.Shared.Configuration;
    using System.Net;

    internal sealed class NetworkManager : Singleton<NetworkManager>
    {
        private ServerBootstrap _bootstrap;
        private IChannel _serverChannel;

        public async Task Initialize(NetworkConfiguration config)
        {
            // Notify handlers
            {
                NotifyManager.AddReqGroupHandler(typeof(PlayerReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(MailReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(TutorialReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(ItemReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(AvatarReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(LineupReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(MissionReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(QuestReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(ChallengeReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(SceneReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(GachaReqGroup));
                NotifyManager.AddReqGroupHandler(typeof(NPCReqGroup));

                NotifyManager.Init();
            }

            var bossGroup = new MultithreadEventLoopGroup();
            var workerGroup = new MultithreadEventLoopGroup();

            _bootstrap = new ServerBootstrap()
                         .Group(bossGroup, workerGroup)
                         .Channel<TcpServerSocketChannel>()
                         .Option(ChannelOption.SoBacklog, 120)
                         .Option(ChannelOption.TcpNodelay, true)
                         .Option(ChannelOption.SoKeepalive, true)
                         .ChildHandler(
                            new ActionChannelInitializer<IChannel>(channel =>
                            {
                                var session = new NetSession(channel);
                                var pipeline = channel.Pipeline;

                                pipeline.AddFirst(new StarRailHeaderDecoder());
                                pipeline.AddLast(new PacketDecoder());
                                pipeline.AddLast(new PacketEncoder());
                                pipeline.AddLast(new PacketHandler(session));
                            })
                          );

            _serverChannel = await _bootstrap.BindAsync(IPAddress.Parse(config.Host), config.Port);
        }
    }
}
