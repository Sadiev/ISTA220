using System;
using System.Collections.Generic;

namespace Roulette
{
    public enum Color { Red, Black, Green };
    public enum EvenOdd { Even, Odd };
    public enum LowHigh { Low, High };
    public enum Columns { First, Second, Therd }
    class Program
    {
        static void Main(string[] args)
        {
            
            new Global();//assign a random color for numbers
            Wheel wheel = new Wheel();
            
            wheel.PrintBets();
            Menu();
            Console.SetCursorPosition(0, 15);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 'S' to spin the wheel or enter a bet > ");
            Console.ResetColor();
            string betStr = Console.ReadLine();
           // wheel.WinNumber = wheel.Spin();

        }
        static void Menu()
        {
            Console.SetCursorPosition(90, 1);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Money ${Global.Money}");
            Console.SetCursorPosition(90, 3);
            Console.Write($"Your bets: ");
        }

    }
    class Global
    {
        public static decimal Money = 500;
        public static Color[] BetNumbers = new Color[37];
        public static List<Bet> Bets= new List<Bet>();
        public Global()
        {
            Random random = new Random();
            for (int i = 0; i < BetNumbers.Length; i++)
            {
                Array values = Enum.GetValues(typeof(Color));
                BetNumbers[i] = (Color)values.GetValue(random.Next(values.Length));
            }
        }
    }
    class Wheel
    {
        public int Spin()
        {
            return new Random().Next(0, 37);
        }

        public void PrintBets()
        {
            Console.SetCursorPosition(0, 2);
            for (int i = 1; i < Global.BetNumbers.Length; i++)
            {
                Console.BackgroundColor = (Global.BetNumbers[i] == Color.Red) ? ConsoleColor.Red : ConsoleColor.Black;
                Console.Write($"  {i}".PadRight(6, ' '));
                if (Console.CursorTop == 0)
                {
                    Console.SetCursorPosition(Console.CursorLeft, 2);
                }
                else
                {
                    Console.SetCursorPosition(Console.CursorLeft - 6, Console.CursorTop - 1);
                }
            }


            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" - R1");
            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop - 1);
            Console.Write(" - R2");
            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop - 1);
            Console.Write(" - R3");

            Console.SetCursorPosition(0, 3);
            Console.ResetColor();

            Console.WriteLine("                  0                 |                 00                 ");

            Console.WriteLine(new string('=', 73));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("* C1  | C2  | C3  | C4  | C5  | C6  | C7  | C8  | C9  | C10 | C11 | C12 *");
            Console.WriteLine(new string('*', 73));
            Console.WriteLine("*   C13     |    C14    |    C15    |    C16    |    C17    |    C18    *");
            Console.WriteLine(new string('*', 73));
            Console.WriteLine("*     1 to 12 - A       |     13 to 24 - B      |     25 to 36 - C      *");


            Console.WriteLine(new string('*', 73));
            Console.WriteLine("*  1 to 18 - D   |   19 to 36 - F   |   1 to 18 - L   |   19 to 36 - H  *");

            Console.WriteLine(new string('*', 73));
            Console.WriteLine("*  red   |    black   |   odd   |    even    |    split    |    corner  *");

            Console.WriteLine(new string('*', 73));
            //Console.WriteLine("Numbers: the number of the bin");
            //Console.WriteLine("Evens / Odds: even or odd numbers");
            //Console.WriteLine("Reds / Blacks: red or black colored numbers");
            //Console.WriteLine("Lows / Highs: low(1 – 18) or high(19 – 38) numbers.");
            //Console.WriteLine("Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");
            //Console.WriteLine("Columns: first, second, or third columns");
            //Console.WriteLine("Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24");
            //Console.WriteLine("Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26");
            //Console.WriteLine("Split: at the edge of any two contiguous numbers, e.g., 1 / 2, 11 / 14, and 35 / 36");
            //Console.WriteLine("Corner: at the intersection of any four contiguous numbers, e.g., 1 / 2 / 4 / 5, or 23 / 24 / 26 / 27");
        }

    }

    class Bet
    {
        //public int WinNumber { get; set; }
        //public Color color { get; set; }
        //public EvenOdd evenOdd { get; set; }
        //public LowHigh lowHigh { get; set; }
        //public Columns columns { get; set; }
        public int BetNumber { get; set; }
        public int Percent { get; set; }

        public void Betting(string bet, decimal amount)
        {
            switch (bet)
            {
                case "R1":
                    AddBets(new int[] { 3,6,9,12,15,18,21,24,27,30,33,36 },30);
                    break;
                case "R2":
                    AddBets(new int[] { 2,5,8,11,14,17,20,23,26,29,32,35 }, 30);
                    break;
                case "R3":
                    AddBets(new int[] { 1,4,7,10,13,16,19,22,25,28,31,34 }, 30);
                    break;
                case "C1":
                    AddBets(new int[] { 1, 2, 3 }, 50);
                    break;
                case "C2":
                    AddBets(new int[] { 4, 5, 6 }, 50);
                    break;
                case "C3":
                    AddBets(new int[] { 7, 8, 9 }, 50);
                    break;
                case "C4":
                    AddBets(new int[] { 10, 11, 12 }, 50);
                    break;
                case "C5":
                    AddBets(new int[] { 13,14,15 }, 50);
                    break;
                case "C6":
                    AddBets(new int[] { 16, 17, 18 }, 50);
                    break;
                case "C7":
                    AddBets(new int[] {19, 20, 21 }, 50);
                    break;
                case "C8":
                    AddBets(new int[] { 22, 23, 24 }, 50);
                    break;
                case "C9":
                    AddBets(new int[] { 25, 26, 27 }, 50);
                    break;
                case "C10":
                    AddBets(new int[] { 28, 29, 30 }, 50);
                    break;
                case "C11":
                    AddBets(new int[] {31, 32, 33 }, 50);
                    break;
                case "C12":
                    AddBets(new int[] { 34, 35, 36 }, 50);
                    break;
                   
                default:
                    break;
            }
        }
        void AddBets(int[] bets, int percent)
        {
            foreach (var bet in bets)
            {
                Global.Bets.Add(new Bet() { BetNumber = bet, Percent = percent });
            }
            
        }


    }


}
