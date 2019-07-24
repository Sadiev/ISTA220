using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  EX 2A - C# - Calculating Averages
//  Student: Shod
//  07/15/2019

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            // Display Menu and prompt a user to choose a function
            do
            {
                switch(DisplayMenu())
                {
                    case "1"://Sum of numbers
                        Console.WriteLine($"\nThe sum of the numbers is {SumOfNumbers(10)}\n");
                        break;
                    case "2"://Average ten scores
                        AverageScores(10);
                        break;
                    case "3"://Average a specific number of scores
                        AverageScores();
                        break;
                    case "4"://Average a non-specific number of scores
                        Average();
                        break;
                    case "5"://Exit
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nError: Enter a valid number.");
                        break;
                }

            } while (exit == false);
        }

        static string DisplayMenu() //Menu
        {
            Console.WriteLine("\n1. Sum of numbers");
            Console.WriteLine("2. Average ten scores");
            Console.WriteLine("3. Average a specific number of scores");
            Console.WriteLine("4. Average a non-specific number of scores");
            Console.WriteLine("5. Exit");
            Console.Write("Enter a number (1, 2, 3, 4 or 5) >>"); 
            return Console.ReadLine();
        }

        static ushort SumOfNumbers(int len) //This method accept ten numbers between 0 and 100, and return their sum.
        {          
            byte[] number = new byte[len];
            byte output = 0;
            ushort sum = 0;

            Console.WriteLine("\nEnter ten numbers between 0 and 100.");                      
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Enter an integer #{i+1} between 0 and 100 >>");
                do
                {
                    if (byte.TryParse(Console.ReadLine(), out output) && (output >= 0 && output <= 100))
                    {
                        number[i] = output;
                        sum += number[i];
                        break;
                    }                      
                    else
                        Console.Write("Not a valid number. Enter a number between 0 and 100 >>");
                } while (true);
  
            }
            return sum;
            
        }

        static void AverageScores(int len)
        {
            //Accept ten test scores, average them, and report a letter grade for the average based on the usual scale
            double avg = SumOfNumbers(len) / len;
            if (avg < 60)
                Console.WriteLine($"The average numerical grade is {avg:0} and the letter grade is F.\n");
            else if (avg < 70)
                Console.WriteLine($"The average numerical grade is {avg:0} and the letter grade is D.\n");
            else if (avg < 80)
                Console.WriteLine($"The average numerical grade is {avg:0} and the letter grade is C.\n");
            else if (avg < 90)
                Console.WriteLine($"The average numerical grade is {avg:0} and the letter grade is  B.\n");
            else
                Console.WriteLine($"The average numerical grade is {avg:0} and the letter grade is  A.\n");
        }

        static void AverageScores()
        {
            ushort output = 0;
            Console.Write("Enter a total number of tests >>");
            while (!ushort.TryParse(Console.ReadLine(), out output))
                Console.Write("Enter a valid number for the total number of test >>");
            AverageScores(output);
        }

        static void Average()
        {
            //This method accept a number test scores (as calculated by the number of scores actually entered)
            //between 0 and 100, average them, and report a letter grade for the average based on the usual scale
            List<int> grades = new List<int>();
            bool exit = false;
            string strGrade;
            int intGrade=0;

            do
            {
                Console.Write("\nEnter a numerical grade between 0 and 100\nor 'r' to average and report a letter grade >>");
                strGrade = Console.ReadLine();
                if (strGrade == "r")
                {
                    exit = true;
                }
                else
                {
                    if (int.TryParse(strGrade, out intGrade) && (intGrade >= 0 && intGrade <= 100))
                    {
                        grades.Add(intGrade);
                    }
                    else
                        Console.Write("Not a valid grade.");
                }
            } while (exit==false);
            if (grades.Count<=0) 
            {
                Console.WriteLine("\nNot a grade added.");
                return;
            }
            double avg = grades.Average();
            if (avg < 60)
                Console.WriteLine($"\nThe average numerical grade is {avg:0} and the letter grade is F.\n");
            else if (avg < 70)
                Console.WriteLine($"\nThe average numerical grade is {avg:0} and the letter grade is D.\n");
            else if (avg < 80)
                Console.WriteLine($"\nThe average numerical grade is {avg:0} and the letter grade is C.\n");
            else if (avg < 90)
                Console.WriteLine($"\nThe average numerical grade is {avg:0} and the letter grade is  B.\n");
            else
                Console.WriteLine($"\nThe average numerical grade is {avg:0} and the letter grade is  A.\n");


        }
    }
}
