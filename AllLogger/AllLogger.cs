using System;

namespace Cmps253.Logger.Loggers
{
    public class AllLogger
    {
        [Flags]
        public enum LogDestination
        {
            None = 0,
            Console = 1,  // 01
            File = 2,     // 10
            Both = 3      // 11
        }

        string file;
        public AllLogger(string file)
        {
            this.file = file;
        }
        public void Log(string msg, LogDestination d)
        {
            if ((d & LogDestination.Console) == LogDestination.Console)
            {
                ConsoleLogger consoleLogger = new ConsoleLogger();
                consoleLogger.Log(msg);
            }

            if ((d & LogDestination.File) == LogDestination.File)
            {
                FileLogger fileLogger = new FileLogger(file);
                fileLogger.Log(msg);
            }
        }
    }
}