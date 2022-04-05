using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var squareNums = new List<int>();

            foreach (var number in numbers)
            {
                if (Math.Sqrt(number) % 1 == 0)
                {
                    squareNums.Add(number);
                }
            }

            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ", squareNums));
        }
    }
}
