using System;
using System.Linq;

namespace TripleSum
{
    internal class Program
    {
        static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');

            int[] numbersArr = ParseStringArreyToInt(inputNumbers, inputNumbers.Length);
            PrintAllTriplets(numbersArr);
        }

        private static void PrintAllTriplets(int[] numbersArr)
        {
            int triplesCount = 0;
            for (int i = 0; i < numbersArr.Length; i++)
            {
                for (int j = i + 1; j < numbersArr.Length; j++)
                {
                    int summed = numbersArr[j] + numbersArr[i];

                    if (numbersArr.Contains(summed))
                    {
                        Console.WriteLine($"{numbersArr[i]} + {numbersArr[j]} == {numbersArr[i] + numbersArr[j]}");
                        triplesCount++;
                    }
                }
            }
            if (triplesCount == 0) Console.WriteLine("No");
        }

        private static int[] ParseStringArreyToInt(string[] stringArr, int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = int.Parse(stringArr[i]);
            }

            return result;
        }
    }
}
