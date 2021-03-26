using System;

namespace Cmps253.Logger.Core
{
    public abstract class BaseLogger : ILogger
    {
        public void Log(string msg) => ConcreteLog(FormatMessage(msg));

        public abstract void ConcreteLog(string msg);

        protected string FormatMessage(string msg) => $"{DateTime.Now}: {msg}\n";
    }
}
