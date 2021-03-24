namespace Cmps253.Logger.Loggers
{
    public class AllLogger
    {
        string file;
        public AllLogger(string file)
        {
            this.file = file;
        }
        public void Log(string msg)
        {
            new FileLogger(file).Log(msg);
            new ConsoleLogger().Log(msg);
        }
    }
}