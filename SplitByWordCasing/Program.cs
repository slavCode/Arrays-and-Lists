using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new string[] { ",", ";", ":", ".", "!", "(", ")", "\"", "'", "\"", "/", "[", "]", " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var upperCase = new List<string>();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();

            SortWordsByCase(input, upperCase, lowerCase, mixedCase);
            PrintAllCases(upperCase, lowerCase, mixedCase);

        }

        private static void PrintAllCases(List<string> upperCase, List<string> lowerCase, List<string> mixedCase)
        {
            Console.WriteLine($"Lower-case: {String.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", upperCase)}");
        }

        private static void SortWordsByCase(List<string> input, List<string> upperCase, List<string> lowerCase, List<string> mixedCase)
        {
            foreach (var item in input)
            {
                int lower = 0;
                int upper = 0;
                foreach (var i in item)
                {
                    if (char.IsLower(i)) lower++;
                    else if (char.IsUpper(i)) upper++;
                }

                if (lower == item.Length) lowerCase.Add(item);
                else if (upper == item.Length) upperCase.Add(item);
                else mixedCase.Add(item);
            }
        }
    }
}
