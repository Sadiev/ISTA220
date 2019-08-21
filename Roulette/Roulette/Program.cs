using System;
using System.Collections.Generic;
using System.Linq;

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
            
           // wheel.WinNumber = wheel.Spin();

        }
        public static void Menu()
        {
            Console.SetCursorPosition(90, 1);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Money ${Global.Money}");
            Console.SetCursorPosition(90, 3);
            Console.Write($"Your bets: ");
            foreach (var bet in Global.Bets.Select(x => new { x.BetType, x.BetAmount }).Distinct())
            {
                Console.SetCursorPosition(90, Console.CursorTop+1);
                Console.Write($"Your on {bet.BetType} is {bet.BetAmount}");
            }
            Console.SetCursorPosition(0, 15);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 'S' to spin the wheel or enter a bet > ");
            Console.ResetColor();

            string betStr = Console.ReadLine();
            if (betStr == "S")
            {
                new Wheel().Spin();
            }
            else
            {
                new Bet().Betting(betStr, 50);
            }
            

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
        public void Spin()
        {
            int winNumber= new Random().Next(0, 37);
            decimal winTotal = 0;
            foreach (var bet in Global.Bets)
            {
                if (bet.BetNumber == winNumber)
                {
                    winTotal +=((bet.Percent*bet.BetAmount)/100)+bet.BetAmount;
                }
            }
            Global.Money += winTotal;
            Global.Bets.Clear();
            Program.Menu();
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
            Console.WriteLine("*           1 to 18 - L             |             19 to 36 - H          *");

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
        public decimal BetAmount { get; set; }
        public string BetType { get; set; }

        public void Betting(string bet, decimal betAmount)
        {
            switch (bet)
            {
                case "R1":
                    AddBets(3, 36, 3, 40, betAmount, bet);
                    break;
                case "R2":
                    AddBets(2, 35, 3, 40, betAmount, bet);
                    break;
                case "R3":
                    AddBets(1, 34, 3, 40, betAmount, bet);
                    break;
                case "C1":
                    AddBets(1, 3, 1, 60, betAmount, bet);
                    break;
                case "C2":
                    AddBets(4, 6, 1, 60, betAmount, bet);
                    break;
                case "C3":
                    AddBets(7, 9, 1, 60, betAmount, bet);
                    break;
                case "C4":
                    AddBets(10, 12, 1, 60, betAmount, bet);
                    break;
                case "C5":
                    AddBets(13, 15, 1, 60, betAmount, bet);
                    break;
                case "C6":
                    AddBets(16, 18, 1, 60, betAmount, bet);
                    break;
                case "C7":
                    AddBets(19, 21, 1, 60, betAmount, bet);
                    break;
                case "C8":
                    AddBets(22, 24, 1, 60, betAmount, bet);
                    break;
                case "C9":
                    AddBets(25, 27, 1, 60, betAmount, bet);
                    break;
                case "C10":
                    AddBets(28, 30, 1, 60, betAmount, bet);
                    break;
                case "C11":
                    AddBets(31, 33, 1, 60, betAmount, bet);
                    break;
                case "C12":
                    AddBets(34, 36, 1, 60, betAmount, bet);
                    break;
                case "C13":
                    AddBets(1, 6, 1, 50, betAmount, bet);
                    break;
                case "C14":
                    AddBets(7, 12, 1, 50, betAmount, bet);
                    break;
                case "C15":
                    AddBets(13, 18, 1, 50, betAmount, bet);
                    break;
                case "C16":
                    AddBets(19, 24, 1, 50, betAmount, bet);
                    break;
                case "C17":
                    AddBets( 25, 30, 1, 50, betAmount, bet);
                    break;
                case "C18":
                    AddBets(31, 36, 1, 50, betAmount, bet);
                    break;
                case "A":
                    AddBets(1,12,1,40,betAmount,bet);
                    break;
                case "B":
                    AddBets(13, 24, 1, 40, betAmount, bet);
                    break;
                case "C":
                    AddBets(25, 36, 1, 40, betAmount, bet);
                    break;
                case "L":
                    AddBets(1, 18, 1, 30, betAmount, bet);
                    break;
                case "H":
                    AddBets(19, 36, 1, 30, betAmount, bet);
                    break;
                default:
                    break;
            }
        }
        void AddBets(int begin, int end, int step, int percent, decimal betAmount, string bet)
        {
            Bet temp;
            for (int i = begin; i < end; i+=step)
            {
                temp = Global.Bets.Find(x => x.BetType == bet && x.BetNumber == i);
                if (temp==null)
                {
                    Global.Bets.Add(new Bet() { BetNumber = i, Percent = percent, BetAmount = betAmount, BetType = bet });
                }
                else
                {
                    temp.BetAmount += betAmount;
                }
            }
            Global.Money -= betAmount;
            Program.Menu();
        }


    }


}
