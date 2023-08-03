namespace FreeSR.Admin.Service
{
    using Ceen.Httpd;
    using Ceen.Httpd.Logging;
    using FreeSR.Admin.Handlers;
    using FreeSR.Shared.Configuration;
    using System.Net;

    internal static class HttpAdminService
    {
        public static string ConsoleHTML { get; private set; }

        private static ServerConfig s_httpdConfiguration;

        public static void Initialize(NetworkConfiguration config)
        {
            LoadHtDocs();

            s_httpdConfiguration = CreateConfiguration();
            _ = BootHttpAsync(config);
        }

        private static void LoadHtDocs()
        {
            ConsoleHTML = File.ReadAllText("assets/console.html");
        }

        private static ServerConfig CreateConfiguration()
        {
            return new ServerConfig().AddLogger(new CLFStdOut())
                                     .AddRoute("/console", new ConsolePageRequestHandler())
                                     .AddRoute("/console/exec", new ExecuteCommandRequestHandler());
        }

        private static async Task BootHttpAsync(NetworkConfiguration config)
        {
            await HttpServer.ListenAsync(new IPEndPoint(
                                         IPAddress.Parse(config.Host),
                                         config.Port),
                                         false, s_httpdConfiguration);
        }
    }
}
