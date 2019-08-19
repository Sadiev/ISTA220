using System;

// Shod
// 08/14/2019
// EX 7A - C# - Military Unit (Implementing Inheritance)

namespace MilitaryUnit
{
    class Finance : Soldier
    {
        public Finance()
            :base ("SPC","Sadiev")
        {

        }
        public override void Duty()
        {
            base.Duty();
            Console.WriteLine($"{rank} {lastName} counting money");
        }
        public override void Eat()
        {
            Console.WriteLine($"{rank} {lastName} eating at a dfac");
        }
    }
}
