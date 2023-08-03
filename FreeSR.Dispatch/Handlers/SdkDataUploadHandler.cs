namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Dispatch.Util;
    using System.Threading.Tasks;

    internal class SdkDataUploadHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                     .Code(0)
                                                     .Build());

            return true;
        }
    }
}
