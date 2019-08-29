using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //---Lambda---
            // 1. An expression which takes no parameters and evaluates to the string "Hello, World".
            //Func<string> func1 = delegate { return "Hello World!"; };
            Func<string> func1 = () => "Hello World!";
            Console.WriteLine(func1());           

            // 2. An expression which returns an integer, takes a single integer parameter, and adds the integer 1 to it.
            Func<int, int> func2 = x => x + 1;
            Console.WriteLine(func2(5));

            // 3. An expression which returns an integer, takes two integer parameters, and raises the second parameter to the power of the first.
            Func<int, int, int> func3 = (x, y) => (int)Math.Pow(x, y);
            Console.WriteLine(func3(3,2));

            // 4. An expression which returns an integer, takes two integer parameters and sums them.
            Func<int, int, int> func4 = (x, y) => x+y;
            Console.WriteLine(func4(5,4));

            //5. An expression which returns a string, takes two strings, and appends the first to the second.
            Func<string, string, string> func5 = (x, y) => x + y;
            Console.WriteLine(func5("Hello ","world!"));

            //---LINQ---
            //Declare a list of sequential integers with a method from the Enumerable class.           
            var intList = Enumerable.Range(1, 10).ToList();

            //Declare a list of dummy strings.
            List<string> strList = new List<string>(new string[] { "txt1","txt2","txt3","txt4","txt5"});

            //Use #2 to add one to a list of integers individually.
        
            foreach (var c in intList.Select(func2))
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //Use #3 to raise a list of integers to the second power individually.
            foreach (var c in intList.Select(func3))
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("+++++++++++++++++++++++++++SUM++++++++++++++++++++++++++++++++++++++");
            //Use #4 to sum a list of integers.
            Console.WriteLine(intList.Aggregate(func4));
            
           
            Console.WriteLine("+++++++++++++++++++++++++++++Concatenate++++++++++++++++++++++++++++++++++++");
            //Use #5 to concatenate a list of strings, returning an empty string if given an empty list.

            Console.WriteLine(strList.Aggregate(func5));
            Console.WriteLine("+++++++++++++++++++++++++++Knuth's up-arrow notation++++++++++++++++++++++++++++++++++++++");
            //Use #3 and a method from the Enumerable class in a new lambda expression which returns an integer,
            //takes two integer parameters (base and times), and which raises the base to its own value times - 1 times.
            //Evaluating your function with base of 2 and times of 4 should result in 65536. This is repeated exponentiation, also known as 
            //tetration, and is frequently expressed in Knuth's up-arrow notation (Links to an external site.) using double up-arrows.

            
            var Knuth = (Enumerable.Repeat(2, 4).Aggregate(func3));
            Console.WriteLine(Knuth);
        }
    }
}
