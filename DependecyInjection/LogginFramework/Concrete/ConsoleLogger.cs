using LoggingFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingFramework.Concrete
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string toLog)
        {
            Console.WriteLine(toLog);
        }
    }
}
