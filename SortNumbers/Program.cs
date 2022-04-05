using System;
using System.Linq;

namespace SortNumbers
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            numbers.Sort();

            Console.WriteLine(String.Join(" <= ", numbers));
        }
    }
}
