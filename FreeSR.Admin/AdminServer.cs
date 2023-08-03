namespace FreeSR.Admin
{
    using FreeSR.Admin.Command.Handlers;
    using FreeSR.Admin.Service;
    using FreeSR.Shared.Command;
    using FreeSR.Shared.Configuration;
    using FreeSR.Shared.Exceptions;
    using NLog;

    internal static class AdminServer
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            AppDomain.CurrentDomain.UnhandledException += OnFatalException;

            s_log.Info("Initializing...");

            CommandManager.Instance.Initialize(typeof(AccountCommandCategory));
            ConfigurationManager<AdminServerConfiguration>.Instance.Initialize("AdminServer.json");
            var serverConfiguration = ConfigurationManager<AdminServerConfiguration>.Instance.Model;

            HttpAdminService.Initialize(serverConfiguration.Network);

            s_log.Info("Server is ready!");
            Thread.Sleep(-1);
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