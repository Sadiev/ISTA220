using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            student("Dilshod", "Sadiev");
            Console.WriteLine($"Graduation year: {add(2012, 3)}"  );
            Console.ReadLine();
        }

        // Overload method with no arguments
        static void student()
        {
            Console.WriteLine("No data");
        }
        // Overload with a argument
        static void student(string firstName)
        {
            Console.WriteLine($"First name: {firstName}");
        }
        // Overload with two arguments
        static void student(string firstName, string lastName)
        {
            Console.WriteLine($"First name: {firstName}\nLast Name: {lastName}");
        }
        //method with default parameters
        static int add(int a=0, int b=0)
        {
            return a+b;
        }



    }   
}
