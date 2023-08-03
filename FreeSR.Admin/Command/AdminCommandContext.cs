namespace FreeSR.Admin.Command
{
    using FreeSR.Shared.Command.Context;

    internal class AdminCommandContext : ICommandContext
    {
        public string Message { get; private set; }

        public void SendError(string message)
        {
            Message = "Error: " + message;
        }

        public void SendMessage(string message)
        {
            Message = message;
        }
    }
}
