using System;

namespace Consoleinheritance
{
    class Human : Mammal
    {
        public Human()
            :this (98.6)
        {

        }
        protected Human(double bodyTemp)
            : base("Human", 2, bodyTemp)
        { }
        public override double Sleep()
        {
            Console.WriteLine($"{creatureName} sleeps 8 hours");
            return 8.0;
        }
    }
}
