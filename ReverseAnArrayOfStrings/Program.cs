using System;

namespace ReverseAnArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int length = input.Length;

            string[] reversed = new string[length];

            for (int i = 1; i <= length; i++)
            {
                reversed[i - 1] = input[length - i];
            }

            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}
