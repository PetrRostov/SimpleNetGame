namespace PR.SimpleNetGame.Infrastructure.Log
{
    public interface ILogProvider
    {
        ILog GetLog();

        ILog GetLog(string name);
    }
}