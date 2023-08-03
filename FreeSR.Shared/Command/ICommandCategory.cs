namespace FreeSR.Shared.Command
{
    using FreeSR.Shared.Command.Context;

    public interface ICommandCategory
    {
        CommandResult Invoke(ICommandContext context, string[] parameters, uint depth);
    }
}
