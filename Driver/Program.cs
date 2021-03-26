using Cmps253.Logger.Loggers;
using System;
using System.Threading;
using System.Linq;

namespace Architecture1
{
    class Program
    {

        static void Main(string[] args)
        {
            //--target=cf
            string argument = args.SingleOrDefault(p => p.ToLower().StartsWith("--target="));
            string options = argument.Split('=')[1].ToLower();

            AllLogger.LogDestination destination = AllLogger.LogDestination.None;
            
            if(options.Contains('c'))
            {
                destination = AllLogger.LogDestination.Console;
            }

            if(options.Contains('f'))
            {
                destination |= AllLogger.LogDestination.File;
            }

            AllLogger allLogger = new AllLogger(@"c:\trash\log.txt");

            allLogger.Log("Program started", destination);

            Thread.Sleep(3000); //simulate sending emails

        }
    }
}
