namespace FreeSR.Admin.Handlers
{
    using Ceen;
    using FreeSR.Admin.Command;
    using FreeSR.Shared.Command;

    internal class ExecuteCommandRequestHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            var query = context.Request.QueryString;
            string command = query["command"];

            var ctx = new AdminCommandContext();
            CommandManager.Instance.Invoke(ctx, command);

            context.Response.StatusCode = HttpStatusCode.OK;
            await context.Response.WriteAllAsync(ctx.Message, "text/plain");

            return true;
        }
    }
}
