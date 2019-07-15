using System;
using System.Collections.Generic;
using System.Linq;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int n = 5;

            //for (var i = 0; i < args.Length; ++i)
            //{
            //    Console.WriteLine($"{args[i]}");
            //}

            //foreach (var a in args)
            //{
            //    Console.WriteLine(a);
            //}

            //Array.ForEach(args, a => Console.WriteLine(a));
            ////OR
            //Array.ForEach(args, Console.WriteLine

            if (args.Length != 1)
            {
                Console.WriteLine("You must pass exactly one argument");
                Environment.Exit(-1);
            }

            var n = int.Parse(args[0]);
            
            Console.WriteLine($"Factorial of {n} is {Factorial(n)}");
            Console.WriteLine($"Factorial of {n} is {Factorial_tailRecursive(n)}");
            Console.WriteLine($"Factorial of {n} is {Factorial_for(n)}");
            Console.WriteLine($"Factorial of {n} is {Factorial_LinqProduct(n)}");
            Console.WriteLine($"Fib: {Fib(n)}");
        }

        static int Factorial(int n)
        {
            // Base cae, n==1
            if (n == 1) return 1;

            //Otherwise
            checked
            {
                return n * Factorial(n - 1);
            }
            
        }

        static int Factorial_tailRecursive(int n, int accumulator = 1)
        {
            // Base cae, n==1
            if (n == 1) return accumulator;

            //Otherwise
            return Factorial_tailRecursive(n - 1, accumulator * n);
        }

        static int Factorial_for(int n)
        {
            var accum = 1;
            for (int i = 1; i <= n; ++i)
            {
                accum *=  i;
                
            }
            return accum;
        }

        static int Factorial_LinqProduct(int n) => Enumerable.Range(1, n).Aggregate((x, y) => x * y);

        static int Fib(int n, int x = 0, int y = 1)
        {
            if (n == 0) return x;
            
            return Fib(n - 1, y, x + y);
        }
        
    }
}
