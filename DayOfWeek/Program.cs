using System;

namespace DayOfWeek
{
    internal class Program
    {
        static void Main()
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int index = int.Parse(Console.ReadLine());
            if (index >= 1 && index <= 7)
            {
                Console.WriteLine(days[index - 1]);
            }
            else Console.WriteLine("Invalid Day!");
        }
    }
}
