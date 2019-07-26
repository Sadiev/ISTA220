using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleScanning
{
    class Navigation
    {
        int page;//Current page
        const int ItemsPerPage = 5;//Tasks per page
        public void KeyCatch(List<MyTask> taskList)
        {
            XMLFile file = new XMLFile(); //needs it to save or open tasks in XML file
            int index = 0; //current task
            int cursor = 0;

            PrintTasks(index, taskList);
            ConsoleKeyInfo consoleKeyInfo;
            Console.SetCursorPosition(0, 0);
            
            if (index <= taskList.Count) SelectTask(index, taskList);//select current task first time
            
            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.F12) //if pressed F12 close app
            {
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.F1://skip
                        index++;
                        cursor++;
                        MoveToNext(ref index, ref cursor, taskList);
                        break;
                    case ConsoleKey.F2://done
                        taskList[index].Status = 1;//cross-out current task
                        file.Save(taskList);
                        index++;
                        cursor++;
                        MoveToNext(ref index, ref cursor, taskList);
                        break;
                    case ConsoleKey.F3://Re-write
                        if (taskList[index].Status != 1)//if active task then re-write
                        {
                            taskList[index].Status = 1;
                            taskList.Add(new MyTask(0, taskList[index].TaskName, DateTime.Now));//RewriteTask
                            file.Save(taskList);
                            PrintTasks(page, taskList);
                        }
                        cursor++;
                        index++;
                        MoveToNext(ref index, ref cursor, taskList);
                        break;
                    case ConsoleKey.F4://add a new task
                        AddTask(taskList);
                        file.Save(taskList);
                        PrintTasks(page, taskList);
                        Console.SetCursorPosition(0, cursor);
                        SelectTask(index, taskList);
                        break;
                    case ConsoleKey.PageDown://next page
                        cursor = ItemsPerPage;
                        index = page + ItemsPerPage;
                        MoveToNext(ref index, ref cursor, taskList);
                        break;
                    default:
                        
                        break;
                }
            }
            clearConsol();//Clear console before closing app
        }

        void SelectTask(int index, List<MyTask> taskList)//This method select current task with a green line 
        {
            if (taskList[index].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(taskList[index].TaskName.PadRight(120, ' '));
        }

        void PrintTasks(int index, List<MyTask> taskList) //This method print -ItemsPerPage- and Menu
        {
            clearConsol();
            page = index;

            foreach (var item in taskList.Skip(index).Take(ItemsPerPage))
            {
                Console.ResetColor();
                Console.ForegroundColor = item.Status == 1 ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(item.TaskName);
            }
            //Print menu with blue color
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, ItemsPerPage + 1);
            DisplayMenu();
        }
        void MoveToNext(ref int index, ref int cursor, List<MyTask> taskList)
        {
            if (index >= 0 && index < taskList.Count)
            {
                Console.SetCursorPosition(0, cursor - 1);
                Console.ResetColor();
                if (taskList[index - 1].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(taskList[index - 1].TaskName.PadRight(120, ' '));
                //if a last task on the page than print next page
                if (Console.CursorTop == ItemsPerPage-1)
                {
                    PrintTasks(index, taskList);
                    cursor = 0;
                } 
                Console.SetCursorPosition(0, cursor);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Green;
                if (taskList[index].Status == 1) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(taskList[index].TaskName.PadRight(120, ' '));
            }
            else if (index >= taskList.Count)//move to begin of the list
            {
                index = 0;
                PrintTasks(index, taskList);
                cursor = 0;
                Console.SetCursorPosition(0, 0);
                SelectTask(index, taskList);
            }
        }
        
        public void AddTask(List<MyTask> taskList)
        {
            clearConsol();
            Console.WriteLine("Enter a new task > ");
            taskList.Add(new MyTask(0, Console.ReadLine(), DateTime.Now));
        }

        void clearConsol()
        {
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
            Console.Clear();
        }

        void DisplayMenu() //Menu
        {
            Console.WriteLine(new string('=', 120));
            Console.Write(" F1. Skipp");
            Console.Write(" || F2. Cross out");
            Console.Write(" || F3. Re-enter");
            Console.Write(" || F4. Add Task");
            Console.Write(" || PgDn. Next Page");
            Console.WriteLine(" || F12. Exit");
            Console.WriteLine(new string('=', 120));
        }
    }
}
