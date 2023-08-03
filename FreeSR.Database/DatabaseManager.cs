namespace FreeSR.Database
{
    using FreeSR.Database.Configuration;
    using FreeSR.Shared;
    using MongoDB.Driver;
    using NLog;

    public sealed class DatabaseManager : Singleton<DatabaseManager>
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        private DatabaseConfiguration _configuration;
        private Dictionary<Type, object> _databases;

        public IMongoDatabase MongoDatabase { get; private set; }

        private DatabaseManager()
        {
            _databases = new Dictionary<Type, object>();
        }

        public void Initialize(DatabaseConfiguration configuration)
        {
            _configuration = configuration;

            var mongoClient = new MongoClient(configuration.ConnectionString);
            MongoDatabase = mongoClient.GetDatabase(configuration.Name);
        }

        public string GetCollectionName(DatabaseType databaseType)
        {
            foreach (var entry in _configuration.Entries)
            {
                if (entry.Type == databaseType)
                    return entry.CollectionName;
            }

            throw new DatabaseMisconfiguredException($"Can not find database of type {databaseType} in provided configuration.");
        }

        public DatabaseManager Add<T>(ISRDatabase<T> database) where T : class
        {
            _databases.Add(database.GetType(), database);
            return this;
        }

        public T Get<T>() where T : class
        {
            if (_databases.TryGetValue(typeof(T), out var database))
                return database as T;

            return null;
        }
    }
}
