namespace FreeSR.Database.Account.Model
{
    using MongoDB.Bson.Serialization.Attributes;

    [BsonIgnoreExtraElements]
    public class AccountModel
    {
        public int Uid { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public DateTime CreationDateUtc { get; set; }
    }
}
