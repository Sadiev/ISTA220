using System;
using System.Collections.Generic;
using System.IO;
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
            XMLFile file = new XMLFile();
            Navigation nav = new Navigation();      
            List<MyTask> list = new List<MyTask>();

            file.Open(ref list); //Upload tasks from XML file
            if (list.Count <= 0) //if the XML file is empty then ask user input a new task
            {
                nav.AddTask(list);
                file.Save(list);
            }
            nav.KeyCatch(list);
        }
    }

    class XMLFile
    {
        public void Save(List<MyTask> t)
        {
            XmlSerializer serializer = new XmlSerializer(t.GetType());
            using (StreamWriter writer = new StreamWriter(@"tasks.xml"))
            {
                serializer.Serialize(writer, t);
                //Console.WriteLine("Объект был сериализирован");
            }
        }

        public void Open(ref List<MyTask> t)
        {
            XmlSerializer serializer = new XmlSerializer(t.GetType());
            try
            {
                using (StreamReader reader = new StreamReader(@"tasks.xml"))
                {
                    t = (List<MyTask>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)// if the file doesn't exist then create one
            {
                Console.WriteLine(e.Message);
                Save(t);
            }
        }
    }

}


