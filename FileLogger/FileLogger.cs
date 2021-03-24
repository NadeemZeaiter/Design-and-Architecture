using Cmps253.Logger.Core;
using System;
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
        public override void Log(string msg)
        {
            File.AppendAllText(file, (msg));
        }
    }
}