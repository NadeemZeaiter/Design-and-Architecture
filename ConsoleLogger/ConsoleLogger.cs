using Cmps253.Logger.Core;
using System;

namespace Cmps253.Logger.Loggers
{
    public class ConsoleLogger : BaseLogger
    {
        public override void ConcreteLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}