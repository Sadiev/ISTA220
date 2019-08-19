using System;
using System.Collections.Generic;

// Shod
// 08/14/2019
// EX 7A - C# - Military Unit (Implementing Inheritance)

namespace MilitaryUnit
{
    class App
    {
        public void Run()
        {
            var finance = new Finance();
            var infantry = new Infantry("SSG", "Brooks");
            var signal = new Signal("SGT", "Lee");

            var soldiers = new List<Soldier>() { finance, infantry, signal };
            foreach (var solder in soldiers)
            {
                SoldierAction(solder);
            }
        }

        void SoldierAction(Soldier soldier)
        {
            soldier.Duty();
            soldier.Move();
            soldier.Eat();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }

    }
}
