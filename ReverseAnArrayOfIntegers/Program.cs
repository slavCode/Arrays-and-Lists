using System;
namespace ReverseAnArrayOfIntegers
{
    internal class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            int[] arrOfIntegers = new int[index];

            for (int i = 0; i < index; i++)
            {
                arrOfIntegers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = index - 1; i >= 0; i--)
            {
                Console.WriteLine(arrOfIntegers[i]);
            }
        }
    }
}
