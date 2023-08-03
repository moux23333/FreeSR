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

    internal class TokenLoginRequestHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            var data = await context.Request.Body.ReadAllAsStringAsync();
            var json = JObject.Parse(data);

            var uid = int.Parse((string)json["uid"]);
            var token = (string)json["token"];

            AccountDatabase accountDatabase = DatabaseManager.Instance.Get<AccountDatabase>();
            AccountModel account = await accountDatabase.GetByUid(uid);
            if (account == null)
            {
                await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                         .Retcode(Retcode.RETCODE_RET_FAIL)
                                                         .Message("Account not found.")
                                                         .Object("data", null)
                                                         .Build());

                return true;
            }
            else if (account.Token != token)
            {
                await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                         .Retcode(Retcode.RETCODE_RET_FAIL)
                                                         .Message("Invalid user token.")
                                                         .Object("data", null)
                                                         .Build());

                return true;
            }

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
                                                     })
                                                     .Build());
            return true;
        }
    }
}
