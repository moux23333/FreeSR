namespace FreeSR.Database.Account
{
    using FreeSR.Database.Account.Model;
    using FreeSR.Database.Account.Util;
    using FreeSR.Database.Mongo;
    using MongoDB.Driver;

    public class AccountDatabase : SRMongoDatabase<AccountModel>
    {
        private int _maxUid;

        public AccountDatabase(IMongoDatabase database, string collectionName) : base(database, collectionName)
        {
            // AccountDatabase.
        }

        public async Task<AccountModel> Create(string name, string password)
        {
            if (_maxUid == 0)
                _maxUid = await FetchMaxUid();

            if (await GetByName(name) != null)
                return null;

            var model = new AccountModel
            {
                Uid = Interlocked.Increment(ref _maxUid),
                Name = name,
                Password = password,
                CreationDateUtc = DateTime.UtcNow,
                Token = AccountTokenUtil.Generate()
            };

            await Insert(model);
            return model;
        }

        public async Task<AccountModel> GetByUid(int uid)
        {
            return await FindOne(account => account.Uid == uid);
        }

        public async Task<AccountModel> GetByName(string name)
        {
            return await FindOne(account => account.Name == name);
        }

        public async Task Update(AccountModel account)
        {
            await Update(model => model.Uid == account.Uid, account);
        }

        private async Task<int> FetchMaxUid()
        {
            var maxUidAccount = await FindMax(account => account.Uid);
            return maxUidAccount?.Uid ?? 0;
        }
    }
}
