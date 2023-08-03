namespace FreeSR.Admin.Command.Handlers
{
    using FreeSR.Shared.Command;
    using FreeSR.Shared.Command.Context;
    using FreeSR.Shared.Configuration;

    [Command("account")]
    internal class AccountCommandCategory : CommandCategory
    {
        [Command("create")]
        public void AccountCreateCommandHandler(ICommandContext context, string username, string password)
        {
            var config = ConfigurationManager<AdminServerConfiguration>.Instance.Model;
            context.SendMessage($"dohttpreq={config.DispatchUrl}/sdk/createaccount?user={username}&pass={password}");
        }
    }
}
