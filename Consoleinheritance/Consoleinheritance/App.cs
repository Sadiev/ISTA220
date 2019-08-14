using System;
using System.Collections.Generic;

namespace Consoleinheritance
{
    class App
    {
        public void Run()
        {
            var bat = new Bat();
            var human = new Human();
            var cow = new Cow();

            //bat.Ambulate();
            //human.Ambulate();
            //cow.Ambulate();
            cow.Lactate();
            ((Mammal)cow).Lactate();


            //Mammal mCow = cow;
            //Mammal mBat = bat;

            //cow.Stampede();
            //((Cow)mCow).Stampede();
            //Console.WriteLine($"Bat is bat? {mBat is Bat}");
            //Console.WriteLine($"Bat is bat? {mBat is Cow}");

            var mammals = new List<Mammal>() { bat, human, cow };
            foreach (var mammal in mammals)
            {
                DoMammalStuff(mammal);
            }
            //DoMammalStuff(bat);
            //DoMammalStuff(human);
            //DoMammalStuff(cow);
        }

        private void DoMammalStuff(Mammal mammal)
        {
            Cow asCow = mammal as Cow;

            if (asCow != null)
            {
                asCow.Stampede();
            }
            else
            {
                mammal.Ambulate();
            }

            if (mammal is Cow)
            {
                Cow cow = (Cow)mammal;
                //Cow cow=mammal as Cow;
                cow.Stampede();

            }
            else
            {
                mammal.Ambulate();
            }
            mammal.Ambulate();
            var totalSleep = mammal.Sleep();
            mammal.Eat();
            mammal.Lactate();
            totalSleep += mammal.Sleep();

            Console.WriteLine($"Total hours of sleep: {totalSleep}\n");
        }

    }
}
