namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Dispatch.Util;
    using FreeSR.Proto;
    using Newtonsoft.Json.Linq;

    internal class GetAgreementInfosHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                     .Retcode(Retcode.RETCODE_RET_SUCC)
                                                     .Message("OK")
                                                     .Object("data", Data)
                                                     .Build());

            return true;
        }

        private static JObject Data
        {
            get
            {
                return new JObject
                {
                    {"marketing_agreements", new JArray()}
                };
            }
        }
    }
}
