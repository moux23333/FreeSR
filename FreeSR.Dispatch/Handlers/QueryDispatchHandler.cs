namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Dispatch.Service.Manager;
    using FreeSR.Dispatch.Util;
    using FreeSR.Proto;
    using NLog;
    using System.Threading.Tasks;

    internal class QueryDispatchHandler : IHttpModule
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        public async Task<bool> HandleAsync(IHttpContext context)
        {
            var query = context.Request.QueryString;
            var version = query["version"];
            var timestamp = query["t"];
            var languageType = query["language_type"];
            var platformType = query["platform_type"];

            s_log.Info($"query_dispatch: version: {version}, time: {timestamp}, language: {languageType}, platform: {platformType}");

            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "text/plain";
            await context.Response.WriteAllAsync(Convert.ToBase64String(ProtobufUtil.Serialize(new DispatchRegionsData
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                TopSeverRegionName = RegionManager.GetTopServerRegionName(),
                RegionList = RegionManager.GetRegionList()
            })));

            return true;
        }
    }
}
