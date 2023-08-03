namespace FreeSR.Database.Configuration
{
    public class DatabaseConfiguration
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public DatabaseEntry[] Entries { get; set; }
    }
}
