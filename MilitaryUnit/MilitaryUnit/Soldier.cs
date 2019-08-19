using System;

// Shod
// 08/14/2019
// EX 7A - C# - Military Unit (Implementing Inheritance)

namespace MilitaryUnit
{
    abstract class Soldier
    {
        protected string rank;
        protected string lastName;

        protected Soldier(string rank, string lastName)
        {
            this.rank = rank;
            this.lastName = lastName;
        }
        public void Move()
        {
            Random distance= new Random();
            Console.WriteLine($"{rank} {lastName} walked {distance.Next(1, 5000)} meters to get food");
        }

        public virtual void Duty()
        {
            Console.WriteLine($"{rank} {lastName} shooting");
        }

        public abstract void Eat();
        
    }

}
