namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using FreeSR.Dispatch.Util;
    using FreeSR.Proto;
    using Newtonsoft.Json.Linq;
    using System.Threading.Tasks;

    internal class ComboTokenRequestHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            var data = await context.Request.Body.ReadAllAsStringAsync();
            var json = JObject.Parse(data);
            var clientData = JObject.Parse((string)json["data"]);

            var dataObject = new JObject
            {
                {"combo_id", 1},
                {"open_id", clientData["uid"]},
                {"combo_token", clientData["token"]},
                {"data", new JObject {{"guest", false}}},
                {"heartbeat", false},
                {"account_type", 1},
                {"fatigue_remind", null}
            };

            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAllJsonAsync(DispatchResponseBuilder.Create()
                                                     .Retcode(Retcode.RETCODE_RET_SUCC)
                                                     .Message("OK")
                                                     .Object("data", dataObject)
                                                     .Build());

            return true;
        }
    }
}
