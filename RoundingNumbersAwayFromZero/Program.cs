using System;
using System.Linq;

namespace RoundingNumbersAwayFromZero
{
    internal class Program
    {
        static void Main()
        {
			//var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


			//for (int i = 0; i < nums.Length - 1; i++)
			//{
			//    var converted = Convert.ToDouble(nums[i]);
			//}



			//Console.WriteLine(string.Join(" ", nums));

			string input = Console.ReadLine();

            string[] items = input.Split();

            double[] numbers = new double[items.Length];


            for (int i = 0; i < items.Length; i++)

            {

                numbers[i] = double.Parse(items[i]);

                Console.WriteLine(items[i] + " => " + Math.Round(numbers[i]));

            }

        }

    }
}
