namespace FreeSR.Dispatch.Util
{
    using FreeSR.Database.Account.Model;
    using Newtonsoft.Json.Linq;

    internal static class DispatchHelper
    {
        public static JObject ToLoginResponseData(this AccountModel model)
        {
            return new JObject
            {
                {"uid", model.Uid},
                {"name", model.Name},
                {"email", ""},
                {"mobile", ""},
                {"is_email_verify", "0"},
                {"realname", ""},
                {"identity_card", ""},
                {"safe_mobile", ""},
                {"facebook_name", ""},
                {"google_name", ""},
                {"twitter_name", ""},
                {"game_center_name", ""},
                {"apple_name", ""},
                {"sony_name", ""},
                {"tap_name", ""},
                {"country", "CN"},
                {"reactivate_ticket", ""},
                {"area_code", "**"},
                {"device_grant_ticket", ""},
                {"steam_name", ""},
                {"unmasked_email", ""},
                {"unmasked_email_type", 0},
                {"token", model.Token}
            };
        }
    }
}
