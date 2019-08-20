using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using LoggingFramework.Abstract;
using Service.Abstract;

namespace LongRunningProcess
{
    public class MyGreateProcess: IService
    {
        private readonly ILogger logger;

        public MyGreateProcess(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                logger.Log($"Long running process: Iteration {i}");
            }
        }
    }
}
