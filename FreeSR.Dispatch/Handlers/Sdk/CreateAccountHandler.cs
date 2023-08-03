namespace FreeSR.Dispatch.Handlers.Sdk
{
    using Ceen;
    using FreeSR.Database;
    using FreeSR.Database.Account;

    internal class CreateAccountHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            var query = context.Request.QueryString;

            var name = query["user"];
            var password = query["pass"];

            var database = DatabaseManager.Instance.Get<AccountDatabase>();
            var account = await database.Create(name, password);

            context.Response.StatusCode = HttpStatusCode.OK;
            if (account == null)
            {
                await context.Response.WriteAllAsync("Sorry, this username is already taken.", "text/plain");
            }
            else
            {
                await context.Response.WriteAllAsync($"Successfully created account with name {account.Name}, uid: {account.Uid}", "text/plain");
            }

            return true;
        }
    }
}
