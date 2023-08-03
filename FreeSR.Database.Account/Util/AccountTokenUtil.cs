namespace FreeSR.Database.Account.Util
{
    using FreeSR.Database.Account.Model;

    public static class AccountTokenUtil
    {
        private const int AccountTokenLength = 128;
        private const string TokenCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private static Random s_random;

        static AccountTokenUtil()
        {
            s_random = new Random();
        }

        public static string Generate()
        {
            var token = "";

            for (int i = 0; i < AccountTokenLength; i++)
            {
                token += TokenCharacters[s_random.Next(TokenCharacters.Length)];
            }

            return token;
        }

        public static bool Verify(AccountModel accountModel, string clientToken)
        {
            if (accountModel == null)
                return false;

            return string.Equals(accountModel.Token, clientToken);
        }
    }
}
