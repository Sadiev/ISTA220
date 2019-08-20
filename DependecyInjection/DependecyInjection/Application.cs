using LoggingFramework.Abstract;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection
{
    class Application: IService
    {
        private readonly ILogger logger;
        private readonly IService longRunningProcess;

        public Application(ILogger logger, IService longRunningProcess)
        {
            this.logger = logger;
            this.longRunningProcess = longRunningProcess;
        }

        //public void Run()
        //{

        //}

        public void Start()
        {
            logger.Log("Application: Starting");
            longRunningProcess.Start();
            logger.Log("Application: Shutting down");
        }
    }
}
