namespace FreeSR.Dispatch.Handlers
{
    using Ceen;
    using Newtonsoft.Json;

    internal class ComboGranterApiGetConfigHandler : IHttpModule
    {
        public async Task<bool> HandleAsync(IHttpContext context)
        {
            context.Response.StatusCode = HttpStatusCode.OK;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(new
            {
                retcode = 0,
                message = "OK",
                data =
                    new
                    {
                        protocol = true,
                        qr_enabled = true,
                        log_level = "INFO",
                        announce_url = "https://sdk.hoyoverse.com/hkrpg/announcement/index.html?sdk_presentation_style=fullscreen\u0026sdk_screen_transparent=true\u0026auth_appid=announcement\u0026authkey_ver=1\u0026sign_type=2#/",
                        push_alias_type = 0,
                        disable_ysdk_guard = true,
                        enable_announce_pic_popup = true
                    }
            }));

            return true;
        }
    }
}
