namespace FreeSR.Shared.Configuration
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Primitives;

    public sealed class ConfigurationManager<T> : Singleton<ConfigurationManager<T>> where T : class
    {
        public IConfiguration Config { get; private set; }
        public T Model { get; private set; }

        public void Initialize(string path)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile(path, false, true)
                .AddEnvironmentVariables();

            Config = builder.Build();
            Model = Config.Get<T>();

            ChangeToken.OnChange(
                Config.GetReloadToken,
                () => Model = Config.Get<T>());
        }
    }
}
