using System;

namespace PR.SimpleNetGame.Infrastructure.Log
{
    public interface ILog
    {
        void Info(string format, params object[] args);

        void Debug(string format, params object[] args);

        void Warn(string format, params object[] args);

        void Error(string format, params object[] args);

        void Error(Exception e);
    }
}