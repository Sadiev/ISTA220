using System;
using System.Collections.Generic;
using System.Linq;

namespace StackProject
{
    class Stack
    {
        private List<int> list=new List<int>();
        public List<int> Data => Enumerable.Reverse(list).ToList();
        public int Count { get => list.Count; }//public int Count => list.Count;
        public int this[int offset]
        {
            get => list[list.Count - (offset+1)];
        }
        public void Push(int i)
        {
            list.Add(i);
        }

        public int Pop()
        {
            var lastIndex = list.Count - 1;
            var tmp = list[lastIndex];
            list.RemoveAt(lastIndex);
            return tmp;
        }

        public int Peak() => list[list.Count - 1];
    }
    class Program
    {

        static void Main(string[] args)
        {
            var s = new Stack();
            for (int i = 0; i < 10; i++)
            {
                s.Push(i + 1);
            }

            foreach (var item in s.Data)
            {
                Console.WriteLine($"Enumerable: {item}");
            }

            Console.WriteLine("\n");

            var count = s.Count;

            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s[i]);
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s.Pop());
            }
            Console.WriteLine($"\n{s.Count}");
        }
    }
}
