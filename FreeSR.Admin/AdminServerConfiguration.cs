namespace FreeSR.Admin
{
    using FreeSR.Shared.Configuration;

    internal class AdminServerConfiguration
    {
        public NetworkConfiguration Network { get; set; }
        public string DispatchUrl { get; set; }
    }
}
