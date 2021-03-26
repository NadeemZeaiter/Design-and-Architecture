using Cmps253.Logger.Core;
using System.IO;

namespace Cmps253.Logger.Loggers
{
    public class FileLogger : BaseLogger
    {
        private string file;
        public FileLogger(string file)
        {
            this.file = file;
        }
        public override void ConcreteLog(string msg)
        {
            File.AppendAllText(file, msg);
        }
    }
}