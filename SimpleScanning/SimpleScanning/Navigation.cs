using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleScanning
{
    class Navigation
    {
        public void KeyCatch(List<MyTask> taskList)
        {
            TaskClass taskClass = new TaskClass();//need it to get access to save and open XML

            PrintTasks(0, taskList);
            ConsoleKeyInfo consoleKeyInfo;
            Console.SetCursorPosition(0, 0);
            int index = 0;

            if (index <= taskList.Count)
            {
                if (taskList[index].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(taskList[index].TaskName.PadRight(120, ' '));
            }

            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.F12)
            {
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.F1://skip
                        index++;
                        SkipTask(ref index, taskList);
                        break;
                    case ConsoleKey.F2://done
                        done(index, taskList);
                        taskClass.SaveTasks(taskList);
                        index++;
                        SkipTask(ref index, taskList);
                        break;
                    case ConsoleKey.F3://Re-write
                        if (taskList[index].Status != 1)
                        {
                            done(index, taskList);
                            RewriteTask(index, taskList);
                            taskClass.SaveTasks(taskList);
                            PrintTasks(index, taskList);
                        }
                        index++;
                        SkipTask(ref index, taskList);
                        break;
                    case ConsoleKey.F4://add a new task
                        AddTask(taskList);
                        taskClass.SaveTasks(taskList);
                        PrintTasks(index, taskList);
                        Console.SetCursorPosition(0, index);
                        if (taskList[index].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(taskList[index].TaskName.PadRight(120, ' '));
                        break;
                    default:
                        
                        break;
                }
            }
            clearConsol();//Clear console before closing app
        }

        public void SkipTask(ref int index, List<MyTask> taskList)
        {
            if (index >= 0 && index < taskList.Count)
            {
                Console.SetCursorPosition(0, index - 1);
                Console.ResetColor();
                if (taskList[index - 1].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(taskList[index - 1].TaskName.PadRight(120, ' '));
                Console.SetCursorPosition(0, index);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Green;
                if (taskList[index].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(taskList[index].TaskName.PadRight(120, ' '));
            }
            else if (index >= taskList.Count)
            {
                Console.SetCursorPosition(0, index - 1);
                Console.ResetColor();
                if (taskList[index - 1].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(taskList[index - 1].TaskName.PadRight(120, ' '));
                index = 0;
                Console.SetCursorPosition(0, 0);
                if (taskList[index].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(taskList[index].TaskName.PadRight(120, ' '));
            }
        }

        public void done(int index, List<MyTask> taskList)
        {
            taskList[index].Status = 1;
        }

        public void RewriteTask(int index, List<MyTask> taskList)
        {
            taskList.Add(new MyTask(0, taskList[index].TaskName, DateTime.Now));
            clearConsol();
        }

        public void PrintTasks(int index, List<MyTask> taskList)
        {
            Console.Clear();
            for (int i = 0; i < taskList.Count; i++)
            {
                if (i >= taskList.Count) break;
                Console.SetCursorPosition(0, i);
                Console.ResetColor();
                Console.ForegroundColor = taskList[i].Status == 1 ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.Write(taskList[i].TaskName);
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, taskList.Count + 1);
            DisplayMenu();
        }
        public void AddTask(List<MyTask> taskList)
        {
            clearConsol();
            Console.WriteLine("Enter a new task > ");
            taskList.Add(new MyTask(0, Console.ReadLine(), DateTime.Now));
            clearConsol();
        }

        void clearConsol()
        {
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
            Console.Clear();
        }

        public void DisplayMenu() //Menu
        {
            Console.WriteLine(new string('=', 120));
            Console.Write(" F1. Skip");
            Console.Write(" || F2. Cross out");
            Console.Write(" || F3. Re-enter");
            Console.Write(" || F4. Add Task");
            Console.WriteLine(" || F12. Exit");
            Console.WriteLine(new string('=', 120));
        }
    }
}
