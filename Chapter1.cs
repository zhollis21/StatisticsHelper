using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsHelper
{
    public static class Chapter1
    {
        public static Random RandomGenerator = new Random();

        public static void CalculatePercentage()
        {
            Console.Write("TODO");
        }

        public static void SumNumbers()
        {
            double sum = 0;
            Console.WriteLine("Please enter the numbers seperated by a single space");

            var input = Console.ReadLine();

            var splitInput = input?.Split(' ');

            foreach (string numberToParse in splitInput)
            {
                if (double.TryParse(numberToParse, out double number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"\tUnable to parse '{numberToParse}', skipping this item");
                }
            }

            Console.WriteLine($"\n\tSum: {sum}");
        }

        public static void GetRandomNumber()
        {
            Console.Write("Please enter a lower bound (default is 0): ");
            int.TryParse(Console.ReadLine(), out int lowerBound);

            Console.Write($"Please enter a upper bound (default is {int.MaxValue-1}): ");
            if(!int.TryParse(Console.ReadLine(), out int upperBound))
            {
                upperBound = int.MaxValue;
            }
            else
            {
                upperBound++; // This is to make the upper bound inclusive instead of exclusive
            }

            Console.WriteLine($"\n\tRandom Number: {RandomGenerator.Next(lowerBound, upperBound)}");
        }
    }
}
