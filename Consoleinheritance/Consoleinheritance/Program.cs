namespace Consoleinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //var app = new App();
            //app.Run();
            42.Ambulate();
            (42.0).Ambulate();

            Util.Ambulate(77);
            Util.Ambulate(55, 100);

            new App().Run();
        }
    }

    static class Util
    {
        public static void Ambulate(this int i)
        {
            System.Console.WriteLine($"{i} ambulate with swagger");
        }

        public static void Ambulate(this double i)
        {
            System.Console.WriteLine($"{i} ambulate seductively");
        }

        public static void Ambulate(this int i, int steps)
        {
            System.Console.WriteLine($"{i} ambulate with swagger for {steps} steps");
        }
    }
}
