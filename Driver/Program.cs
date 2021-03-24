using Cmps253.Logger.Loggers;
using System.Threading;

namespace Architecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            AllLogger allLogger = new AllLogger(@"c:\trash\log.txt");
            
            allLogger.Log("Program started");
        
            Thread.Sleep(3000); //simulate sending emails
            
            allLogger.Log("Program ended");
        }
    }
}
