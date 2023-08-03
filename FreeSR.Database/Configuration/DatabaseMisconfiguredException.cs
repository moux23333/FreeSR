namespace FreeSR.Database.Configuration
{
    using FreeSR.Shared.Exceptions;

    internal class DatabaseMisconfiguredException : ServerInitializationException
    {
        public DatabaseMisconfiguredException(string message) : base(message)
        {
            // DatabaseMisconfiguredException.
        }
    }
}
