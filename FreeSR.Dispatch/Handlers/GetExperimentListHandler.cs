namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Dispatch.Util;
    using FreeSR.Proto;

    internal class GetExperimentListHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                     .Retcode(Retcode.RETCODE_RET_SUCC)
                                                     .Boolean("success", true)
                                                     .String("message", "")
                                                     .Build());

            return true;
        }
    }
}
