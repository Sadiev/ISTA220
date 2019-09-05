using System;
using System.Linq;

namespace Union
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new[] {1,3,4,5,6,7 };
            int[] arr2 = new[] { 1, 2, 3, 4, 5, 8 };

            var result = arr1.Union(arr2).OrderBy(x=>x);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-',100));
            var diff = arr1.Except(arr2);
            foreach (var item in diff)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 100));
            var intersect = arr1.Intersect(arr2);
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 100));
            var concat = arr1.Concat(arr2);//.OrderBy(x => x);
            foreach (var item in concat)
            {
                Console.WriteLine(item);
            }
        }
    }
}
