namespace FreeSR.Shared.Command.Context
{
    using NLog;

    public class ConsoleCommandContext : ICommandContext
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        public void SendMessage(string message)
        {
            s_log.Info(message);
        }

        public void SendError(string message)
        {
            s_log.Error(message);
        }
    }
}
