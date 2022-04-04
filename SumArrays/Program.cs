using System;
using System.Linq;

namespace SumArrays
{
    internal class Program
    {
        static void Main()
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int firstLength = firstArr.Length;
            int secondLength = secondArr.Length;

            int longestLength = Math.Max(firstLength, secondLength);
            int[] result = new int[longestLength];

            for (int i = 0; i < longestLength; i++)
            {
                result[i] = firstArr[i % firstLength] + secondArr[i % secondLength];
            }

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
