namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Database;
    using FreeSR.Database.Account;
    using FreeSR.Database.Account.Model;
    using FreeSR.Dispatch.Util;
    using FreeSR.Proto;
    using Newtonsoft.Json.Linq;
    using System.Threading.Tasks;

    internal class LoginRequestHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "application/json";

            string data = await context.Request.Body.ReadAllAsStringAsync();
            JObject loginJson = JObject.Parse(data);

            AccountDatabase accountDatabase = DatabaseManager.Instance.Get<AccountDatabase>();

            string accountName = (string)loginJson["account"];
            string password = (string)loginJson["password"];

            AccountModel account = await accountDatabase.GetByName(accountName);
            if (account == null)
            {
                await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                         .Retcode(Retcode.RETCODE_RET_FAIL)
                                                         .Message("Account not found.")
                                                         .Object("data", null)
                                                         .Build());
                return true;
            }

            // no password check, because client patch is closed-source for now.

            await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                     .Retcode(Retcode.RETCODE_RET_SUCC)
                                                     .Message("OK")
                                                     .Object("data", new JObject 
                                                     {
                                                         {"account", account.ToLoginResponseData()},
                                                         {"device_grant_required", false},
                                                         {"safe_moblie_required", false},
                                                         {"realperson_required", false},
                                                         {"reactivate_required", false},
                                                         {"realname_operation", "None"}
,                                                     })
                                                     .Build());

            return true;
        }
    }
}
