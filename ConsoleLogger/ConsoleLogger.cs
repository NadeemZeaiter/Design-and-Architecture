using Cmps253.Logger.Core;
using System;

namespace Cmps253.Logger.Loggers
{
    public class ConsoleLogger : BaseLogger
    {
        public override void Log(string msg)
        {
            Console.WriteLine(base.FormatMessage(msg));
        }
    }
}