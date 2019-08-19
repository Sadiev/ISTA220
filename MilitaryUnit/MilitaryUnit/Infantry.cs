using System;

// Shod
// 08/14/2019
// EX 7A - C# - Military Unit (Implementing Inheritance)

namespace MilitaryUnit
{
    class Infantry : Soldier
    {
        public Infantry(string rank, string lastName) 
            : base(rank, lastName)
        {
        }

        //public override void Duty()
        //{
        //    base.Duty();
        //}

        public override void Eat()
        {
            Console.WriteLine($"{rank} {lastName} eating MRE");
        }
    }
}
