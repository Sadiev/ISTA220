using LoggingFramework.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggingFramework.Concrete
{
   public class FileLogger : ILogger
    {
        private string path;

        public FileLogger(string path)
        {
            this.path = path;
            File.Create(path).Close();
        }

        public void Log(string toLog)
        {
            using (StreamWriter w = new StreamWriter(path))
            {
                w.WriteLine(toLog);
            }
        }
    }
}
