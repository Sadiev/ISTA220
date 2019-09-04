using System;
using System.Linq;

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = Enumerable.Range(1, 10).ToList();
            //var result = intList.First();//output 1
            var result = intList.First(x=>x%2==0);//FirstOrDefault(x=>x%2==0) works if list empty
            Console.WriteLine(result);//output 2  

            var last = intList.Last();//LastOrDefault(x=>x%2==0) works if list empty
            Console.WriteLine(last);

            var byIndex = intList.ElementAt(0);//ElementAtOrDefault(0)
            Console.WriteLine(byIndex);//output 1 

            var single = intList.Single(x => x == 3);//SingleAtOrDefault(0)
            Console.WriteLine(single);

            var def = intList.DefaultIfEmpty();//if list empty return 0
        }
    }
}
