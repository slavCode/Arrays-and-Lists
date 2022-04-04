using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (input.Length == 1)
            {
                Console.WriteLine($"{input[0]} is already condensed to number");
            }
            else
            {
                int[] condensed = new int[input.Length - 1];

                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length - 1; j++)
                    {
                        condensed[j] = input[j] + input[j + 1];
                    }
                    input = condensed;
                }


                Console.WriteLine(String.Join(" ", condensed[0]));
            }
        }
    }
}
