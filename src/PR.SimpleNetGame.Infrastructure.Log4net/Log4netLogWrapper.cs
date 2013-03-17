using System;
using log4net;

namespace PR.SimpleNetGame.Infrastructure.Log4net
{
    public class Log4netLogWrapper : Log.ILog
    {
        private readonly ILog _log4NetLog;

        public Log4netLogWrapper(ILog log4NetLog)
        {
            Require.NotNull(log4NetLog, "log4NetLog");

            _log4NetLog = log4NetLog;
        }

        public void Info(string format, params object[] args)
        {
            _log4NetLog.InfoFormat(format, args);
        }

        public void Debug(string format, params object[] args)
        {
            _log4NetLog.DebugFormat(format, args);
        }

        public void Warn(string format, params object[] args)
        {
            _log4NetLog.WarnFormat(format, args);
        }

        public void Error(string format, params object[] args)
        {
            _log4NetLog.ErrorFormat(format, args);
        }

        public void Error(Exception e)
        {
            _log4NetLog.Error(e.Message, e);
        }
    }
}