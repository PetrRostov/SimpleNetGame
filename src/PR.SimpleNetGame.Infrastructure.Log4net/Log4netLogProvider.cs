using PR.SimpleNetGame.Infrastructure.Log;

namespace PR.SimpleNetGame.Infrastructure.Log4net
{
// ReSharper disable InconsistentNaming
    public class Log4netLogProvider : ILogProvider
// ReSharper restore InconsistentNaming
    {
        public ILog GetLog()
        {
            return new Log4netLogWrapper(log4net.LogManager.GetLogger(typeof(Log4netLogProvider))); 
        }

        public ILog GetLog(string name)
        {
            return new Log4netLogWrapper(log4net.LogManager.GetLogger(name)); 
        }
    }
}