using System;
using System.Collections.Generic;

namespace Properties
{
    interface IReferenced
    {
        int References { get; }
        void AddReference();
        void RemoveReference();
    }
    class PropertyTest: IReferenced
    {
        //public PropertyTest()
        //{
        //    Cats = 7;
        //}
        int _test;
        public int Test { get { return Test; } set { _test = value; } }
        public List<int> Age { get; set; }
        public int Dogs { get; set; } = 9;
        private int _cats = 7;
        public int Cats
        {
            get => _cats;
            private set
            {
                _cats = value;
            }
        }
        public int References { get; private set; }

        public void AddReference()
        {
            References += 1;
        }

        public void RemoveReference()
        {
            References -= 1;
        }

        private double _unsignedDouble;
        public double UnsignedDouble
        {
            get => _unsignedDouble;
            set
            {
                if (value > 0)
                    _unsignedDouble = value;
                //else
                //    throw new Exception();

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PropertyTest();
            var p2 = new PropertyTest { Dogs = 7,UnsignedDouble=-4, Age=new List<int> {1,2,3,4,5 } };
            p.UnsignedDouble = 5;
            Console.WriteLine(p.UnsignedDouble);
            p.UnsignedDouble = -5;
            Console.WriteLine(p.UnsignedDouble);
            Console.WriteLine("--------------------------------");
            p.Test = 1;
            Console.WriteLine(p.Test);

        }
    }
}
