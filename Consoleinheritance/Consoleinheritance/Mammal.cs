using System;

namespace Consoleinheritance
{
    abstract class Mammal
    {
        protected readonly int legs =4;
        protected readonly string creatureName;
        protected readonly double internalTemperature;
        protected Mammal(string creatureName, double internalTemperature)
        {
            this.creatureName = creatureName;
            this.internalTemperature = internalTemperature;
        }
        protected Mammal(string creatureName, int legs, double internalTemperature)
        {
            this.creatureName = creatureName;
            this.legs = legs;
            this.internalTemperature = internalTemperature;
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{creatureName}  eat");
        }
        public virtual void Gestate()
        {
            Console.WriteLine($"{creatureName}  gestate");
        }
        public void Lactate()
        {
            Console.WriteLine($"{creatureName} lactate");
        }
        public virtual void Ambulate()
        {
            Console.WriteLine($"{creatureName} ambulatting on {legs} legs");
        }
        public abstract double Sleep();
    }
}
