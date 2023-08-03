namespace FreeSR.Shared.Command.Context
{
    public interface ICommandContext
    {
        void SendMessage(string message);
        void SendError(string message);
    }
}
