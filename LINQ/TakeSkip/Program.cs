using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string> {"USA", "Canada","Russia", "UK", "Tajikistan","Germany" };

            IEnumerable<string> take = countries.Take(2);//"USA", "Canada"
            IEnumerable<string> skip = countries.Skip(2);//"Russia", "UK", "Tajikistan","Germany"
            IEnumerable<string> takeWhile = countries.TakeWhile(c=>c.Length>2);//"USA", "Canada","Russia"
            IEnumerable<string> skipWhile = countries.SkipWhile(c => c.Length > 2);//"UK", "Tajikistan","Germany"
            IEnumerable<string> takeSQL = (from country in countries
                                           select country).Take(5);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item);
            }
        }
    }
}
