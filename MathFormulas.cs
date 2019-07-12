using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter a number greater than zero for the radius: ");
            
            double dblRadius=0;
            do
            {
                if (double.TryParse(Console.ReadLine(), out dblRadius) && (dblRadius > 0))
                    break;
                else
                    Console.Write("Please enter a valid number: ");
            } while (true);
            

            // Implementation for circumference
            double circumference = 2 * Math.PI * dblRadius;
            Console.WriteLine($"The circumference is {circumference}");
            
            // Implementation for area
            double area = Math.PI * Math.Pow(dblRadius, 2);
            Console.WriteLine($"The area is {area}");


            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            
            do
            {
                if (double.TryParse(Console.ReadLine(), out dblRadius) && (dblRadius > 0))
                    break;
                else
                    Console.Write("Please enter a valid number: ");
            } while (true);

            double volume = ((4 / 3) * Math.PI * Math.Pow(dblRadius, 3)) / 2;
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Enter an integer for the side a: ");
            uint a;
            while (!uint.TryParse(Console.ReadLine(), out a))
                Console.Write("Please enter a valid number: ");
            
            Console.Write("Enter an integer for the side b: ");
            uint b;
            while (!uint.TryParse(Console.ReadLine(), out b))
                Console.Write("Please enter a valid number: ");
            Console.Write("Enter an integer for the side c: ");
            uint c;
            while (!uint.TryParse(Console.ReadLine(), out c))
                Console.Write("Please enter a valid number: ");

            double p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"The area is {area}");


            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            Console.Write("Enter a positive number for the coefficient a: ");
            while (!uint.TryParse(Console.ReadLine(), out a))
                Console.Write("Please enter a valid number: ");
            Console.Write("Enter a positive number for the coefficient b: ");
            while (!uint.TryParse(Console.ReadLine(), out b))
                Console.Write("Please enter a valid number: ");
            Console.Write("Enter a positive number for the coefficient c: ");
            while (!uint.TryParse(Console.ReadLine(), out c))
                Console.Write("Please enter a valid number: ");

            double d = b * b - 4 * a * c;
            if (d>=0)
            {
                double positive_num = (-b + Math.Sqrt(d));
                double negative_num = (-b - Math.Sqrt(d));
                double denominator = 2 * a;

                Console.WriteLine($"The positive solution is {positive_num / denominator}");
                Console.WriteLine($"The negative solution is {negative_num / denominator}");
            }
            else
                Console.WriteLine("Root are imeainary; No Solution. \n\n");
            
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
