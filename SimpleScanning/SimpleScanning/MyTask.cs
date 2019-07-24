using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SimpleScanning
{
    public class MyTask
    {
        int status;
        string taskname;
        DateTime taskdate;
        public MyTask()
        {
            this.status = 0;
            taskname = "A new task";
            taskdate = DateTime.Now;
        }
        public MyTask(int status, string tname, DateTime tdate)
        {
            this.status = status;
            this.taskname = tname;
            this.taskdate = tdate;
        }
        [XmlElement("Status")]
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        [XmlElement("TaskName")]
        public string TaskName
        {
            get { return taskname; }
            set { taskname = value; }
        }
        [XmlElement("TaskDate")]
        public DateTime TaskDate
        {
            get { return taskdate; }
            set { taskdate = value; }
        }
    }
}
