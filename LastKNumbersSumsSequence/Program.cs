using System;
namespace LastKNumbersSumsSequence
{
    internal class Program
    {
        static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                long sum = 0;
                int count = k;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (count == 0) break;

                    sum += numbers[j];
                    count--;
                }

                numbers[i] = sum;


            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
