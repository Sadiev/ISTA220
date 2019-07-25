using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

// Progect - Simple Scanning
// Student - Dilshod Sadiev
// Date - 07/24/2019

namespace SimpleScanning
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskClass taskClass = new TaskClass();
            Navigation nav = new Navigation();
          
            taskClass.OpenTasks(); //Upload tasks from XML file
            if (taskClass.TaskList.Count<=0) //if the XML file is empty then ask user input a new task
            {
                nav.AddTask(taskClass.TaskList);
                taskClass.SaveTasks(taskClass.TaskList);
            }      
            nav.KeyCatch(taskClass.TaskList);  //Show the list of the tasks       
        }
    }

    [XmlRoot("ArrayOfMyTask")]
    class TaskClass
    {
        List<MyTask> taskList = new List<MyTask>();

        [XmlElement("MyTask")]
        public List<MyTask> TaskList
        {
            get { return taskList; }
            set { taskList = value; }
        }
      
        public void SaveTasks(List<MyTask> t)
        {
            XmlSerializer serializer = new XmlSerializer(t.GetType());
            using (StreamWriter writer = new StreamWriter(@"tasks.xml"))
            {
                serializer.Serialize(writer, t);
                //Console.WriteLine("Объект был сериализирован");
            }          
        }

        public void OpenTasks()
        {
            XmlSerializer serializer = new XmlSerializer(taskList.GetType());
            try
            {
                using (StreamReader reader = new StreamReader(@"tasks.xml"))
                {
                    TaskList = (List<MyTask>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)// if the file doesn't exist then create one
            {
                //Console.WriteLine(e.Message);
                SaveTasks(TaskList);
            }
        }
    }

}


