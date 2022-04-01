using System;

namespace RoundingNumbersAwayFromZero
{
    internal class Program
    {
        static void Main()
        {
            string[] inputNums = Console.ReadLine().Split(' ');
            double[] numbers = new double[inputNums.Length];

            var current = double.Parse(inputNums[0]);

            for (int i = 0; i < inputNums.Length - 1; i++)
            {

                numbers[i] = double.Parse(inputNums[i]);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
