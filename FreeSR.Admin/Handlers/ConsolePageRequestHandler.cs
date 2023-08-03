namespace FreeSR.Admin.Handlers
{
    using Ceen;
    using FreeSR.Admin.Service;

    internal class ConsolePageRequestHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            context.Response.StatusCode = HttpStatusCode.OK;
            await context.Response.WriteAllAsync(CreateHTMLDocument(), "text/html");

            return true;
        }

        private static string CreateHTMLDocument()
        {
            string baseString = HttpAdminService.ConsoleHTML;

            return baseString.Replace("%SERVER_VERSION%", "v0.1.0 dev")
                      .Replace("%GAME_VERSION%", "0.56");

        }
    }
}
