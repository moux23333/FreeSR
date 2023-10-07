namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Dispatch.Util;
    using FreeSR.Proto;
    using System.Threading.Tasks;

    internal class QueryGatewayHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "text/plain";
            await context.Response.WriteAllAsync(Convert.ToBase64String(ProtobufUtil.Serialize(new Gateserver
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                Msg = "OK",
                Ip = "127.0.0.1",
                RegionName = "FreeSR",
                Port = 22301,
                Mljaogdhcki = true,
                LoginWhiteMsg = "Access verification failed. Please check if you have logged in to the correct account and server.",
                Jcdlppbocpe = true,
                Gifijbibiin = true,
                Ibplbfhmgkf = true,
                MbResVersion = "5335706",
                //AssetBundleUrl = "https://autopatchos.starrails.com/asb/V1.2Live/output_4762225_de745b65ed",
                //ExResourceUrl = "https://autopatchos.starrails.com/design_data/V1.2Live/output_4762225_de745b65ed",
            })));

            return true;
        }
    }
}
