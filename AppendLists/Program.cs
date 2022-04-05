using System;
using System.Collections.Generic;

namespace AppendLists
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var tokens = input.Split('|');
            var result = new List<string>();
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                var token = tokens[i].Trim().Split();
                for (int j = 0; j < token.Length; j++)
                {
                    if (token[j] != "") result.Add(token[j]);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
