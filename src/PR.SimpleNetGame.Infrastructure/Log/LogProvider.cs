using System;
using System.Diagnostics;
using PR.SimpleNetGame.Infrastructure.DependencyResolver;

namespace PR.SimpleNetGame.Infrastructure.Log
{
    public static class LogProvider
    {
        private static ILogProvider GetLogProvider()
        {
            return IoC.Resolve<ILogProvider>();
        }

        [DebuggerStepThrough]
        public static ILog GetLog()
        {
            return GetLogProvider().GetLog();
        }

        [DebuggerStepThrough]
        public static ILog GetLog(string name)
        {
            return GetLogProvider().GetLog(name);
        }
    }
}