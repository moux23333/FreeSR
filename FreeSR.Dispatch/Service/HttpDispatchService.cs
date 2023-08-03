namespace FreeSR.Dispatch.Service
{
    using Ceen.Httpd;
    using Ceen.Httpd.Logging;
    using FreeSR.Dispatch.Handlers;
    using FreeSR.Dispatch.Handlers.Sdk;
    using FreeSR.Shared.Configuration;
    using System.Net;

    internal static class HttpDispatchService
    {
        private static ServerConfig s_httpdConfiguration;

        public static void Initialize(NetworkConfiguration config)
        {
            s_httpdConfiguration = CreateConfiguration();
            _ = BootHttpAsync(config);
        }

        private static ServerConfig CreateConfiguration()
        {
            return new ServerConfig().AddLogger(new CLFStdOut())
                                     .AddRoute("/query_dispatch", new QueryDispatchHandler())
                                     .AddRoute("/query_gateway", new QueryGatewayHandler())
                                     .AddRoute("/hkrpg_global/mdk/shield/api/login", new LoginRequestHandler())
                                     .AddRoute("/hkrpg_global/combo/granter/login/v2/login", new ComboTokenRequestHandler())
                                     .AddRoute("/hkrpg_global/mdk/shield/api/verify", new TokenLoginRequestHandler())
                                     .AddRoute("/sdk/dataUpload", new SdkDataUploadHandler())
                                     .AddRoute("/hkrpg/dataUpload", new HkrpgDataUploadHandler())
                                     .AddRoute("/account/risky/api/check", new RiskyApiCheckHandler())
                                     .AddRoute("/hkrpg_global/mdk/agreement/api/getAgreementInfos", new GetAgreementInfosHandler())
                                     .AddRoute("/data_abtest_api/config/experiment/list", new GetExperimentListHandler())
                                     .AddRoute("/hkrpg_global/combo/granter/api/getConfig", new ComboGranterApiGetConfigHandler())
                                     .AddRoute("/sdk/createaccount", new CreateAccountHandler());
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
