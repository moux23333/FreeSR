namespace FreeSR.Dispatch
{
    using FreeSR.Database;
    using FreeSR.Database.Account;
    using FreeSR.Database.Configuration;
    using FreeSR.Dispatch.Service;
    using FreeSR.Dispatch.Service.Manager;
    using FreeSR.Shared.Configuration;
    using FreeSR.Shared.Exceptions;
    using NLog;

    internal static class DispatchServer
    {
        private const string Title = "FreeSR Dispatch Server (EXPERIMENTAL OPEN SOURCE BUILD)";

        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            AppDomain.CurrentDomain.UnhandledException += OnFatalException;

            Console.Title = Title;
            s_log.Info("Initializing...");

            ConfigurationManager<DispatchServerConfiguration>.Instance.Initialize("DispatchServer.json");
            var serverConfiguration = ConfigurationManager<DispatchServerConfiguration>.Instance.Model;

            DatabaseManager.Instance.Initialize(serverConfiguration.Database);

            var mongoDatabase = DatabaseManager.Instance.MongoDatabase;
            DatabaseManager.Instance.Add(new AccountDatabase(mongoDatabase, DatabaseManager.Instance.GetCollectionName(DatabaseType.Account)));

            RegionManager.Initialize(serverConfiguration.Region);
            HttpDispatchService.Initialize(serverConfiguration.Network);

            s_log.Info("Server is ready!");

            Thread.Sleep(-1); // TODO: Console handler
        }

        private static void OnFatalException(object sender, UnhandledExceptionEventArgs args)
        {
            if (args.ExceptionObject is ServerInitializationException initException)
            {
                Console.WriteLine("Server initialization failed, unhandled exception!");
                Console.WriteLine(initException);
            }
            else
            {
                Console.WriteLine("Unhandled exception in runtime!");
                Console.WriteLine(args.ExceptionObject);
            }

            Console.WriteLine("Press enter to close this window...");
            Console.ReadLine();
        }
    }
}