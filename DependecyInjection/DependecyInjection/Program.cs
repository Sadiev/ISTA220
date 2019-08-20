using System;
using LongRunningProcess;
using LoggingFramework.Concrete;

namespace DependecyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();
            var service = new MyGreateProcess(logger);
            new Application(logger, service).Start();
        }
    }
}
