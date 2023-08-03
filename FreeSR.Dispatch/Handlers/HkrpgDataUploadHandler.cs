namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Dispatch.Util;
    using NLog;
    using System.Threading.Tasks;

    internal class HkrpgDataUploadHandler : IHttpModule
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        public async Task<bool> HandleAsync(IHttpContext context)
        {
            string logs = await context.Request.Body.ReadAllAsStringAsync();
            s_log.Info(logs);

            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                     .Code(0)
                                                     .Build());

            return true;
        }
    }
}
