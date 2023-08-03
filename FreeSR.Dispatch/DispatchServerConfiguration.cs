namespace FreeSR.Dispatch
{
    using FreeSR.Database.Configuration;
    using FreeSR.Dispatch.Configuration;
    using FreeSR.Shared.Configuration;

    internal class DispatchServerConfiguration
    {
        public NetworkConfiguration Network { get; set; }
        public DatabaseConfiguration Database { get; set; }
        public RegionConfiguration Region { get; set; }
    }
}
