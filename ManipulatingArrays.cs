using System;

// Project: EX 2B - C# - Manipulating Arrays
// Student: Shod
// Date: 01/15/2019

namespace manipulatingarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            // Display Menu and prompt a user to choose a function
            do
            {
                int[] A = { 0, 2, 4, 6, 8, 10 };
                int[] B = { 1, 3, 5, 7, 9 };
                int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
                switch (DisplayMenu())
                {
                    case "1"://Counting, summing, computing the mean
                        Console.Write($"\nThe average of the A is {CountSumAvg(A)}");
                        Console.Write($"\nThe average of the B is {CountSumAvg(B)}");
                        Console.WriteLine($"\nThe average of the C is {CountSumAvg(C)}");
                        break;
                    case "2"://Reversing arrays
                        ReversingArrays(A);
                        ReversingArrays(B);
                        ReversingArrays(C);
                        break;
                    case "3"://Rotating arrays
                        RotatingArrays(A);
                        RotatingArrays(B);
                        RotatingArrays(C);
                        break;
                    case "4"://Sorting arrays
                        Console.WriteLine("\n[{0}]", string.Join(", ", C));
                        SortingArrays(C);
                        Console.WriteLine("[{0}]", string.Join(", ", C));
                        break;
                    case "5"://Exit
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nError: Enter a valid number.");
                        break;
                }

            } while (exit == false);
        }

        private static void SortingArrays(int[] arr, bool repeat = false)
        {
            //This method takes an unsorted integer array and sort the array
            for (var i=0; i<arr.Length-1; i++)
            {
                int tmp;
                if (arr[i] > arr[i + 1])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    repeat = true;
                }
            }
            if (repeat) SortingArrays(arr);          

        }

        static string DisplayMenu() //Menu
        {
            Console.WriteLine("\n1. Counting, summing, computing the mean");
            Console.WriteLine("2. Reversing arrays");
            Console.WriteLine("3. Rotating arrays");
            Console.WriteLine("4. Sorting arrays");
            Console.WriteLine("5. Exit");
            Console.Write("Enter a number (1, 2, 3, 4 or 5) >>");
            return Console.ReadLine();
        }

        static double CountSumAvg(int[] arr)
        {
            //This method counts the number of elements in an integer array,
            //and then sums the elements in an integer array
            var sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum / arr.Length;
        }

        static void ReversingArrays(int[] arr)
        {
            //This method that accepts an array as an argument and prints the reversed array
            Console.Write("\nReversing [{0}] to ", string.Join(", ", arr));
            int[] revers = new int[arr.Length];
            int j = 0;
            for (var i=arr.Length-1; i>0; i--)
            {
                revers[j++] = arr[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", revers));
        }

        static void RotatingArrays(int[] arr)
        {
            //Rotating an array to the right by two places
            Console.Write("\nRotating [{0}] to ", string.Join(", ", arr));
            int[] rotate = new int[arr.Length];
            int j = 1;
            for (var i=0; i<arr.Length; i++)
            {
                if (i == arr.Length - 2)
                {
                    j = 0;
                }
                else
                {
                    j++;
                } 
                
                rotate[j] = arr[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", rotate));
        }
    }
}
