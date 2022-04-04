using System;
using System.Linq;

namespace ExtractMiddleOneTwoOrThreeElements
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = numbers.Length;

            if (counter == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
                return;
            }
            if (counter % 2 == 0)
            {
                Console.WriteLine($"{{ {numbers[counter / 2 - 1]}, {numbers[(counter / 2)]} }}");
            }
            else
            {
                var index = (int)Math.Ceiling(counter / 2m);
                var prevIndex = index - 1;
                var nextIndex = index + 1;
                Console.WriteLine($"{{ {prevIndex}, {index}, {nextIndex} }}");
            }
        }
    }
}
