using System;

// Shod
// 08/14/2019
// EX 7A - C# - Military Unit (Implementing Inheritance)

namespace MilitaryUnit
{
    class Signal : Soldier
    {
        public Signal(string rank, string lastName)
            : base(rank, lastName)
        {
        }

        public override void Duty()
        {
            base.Duty();
            Console.WriteLine($"{rank} {lastName} fixig computers");
        }

        public override void Eat()
        {
            Console.WriteLine($"{rank} {lastName} eating some snacks");
        }
    }
}
