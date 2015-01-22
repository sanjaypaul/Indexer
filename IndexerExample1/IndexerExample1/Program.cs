using System;

namespace IndexerExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            DayCollection week = new DayCollection();
            int a = week["Monday"];

            

            Console.WriteLine(week["Friday"]);

            // Raises ArgumentOutOfRangeException
            //Console.WriteLine(week["Made-up Day"]);

            Console.WriteLine(week[0]);

            Console.ReadKey();
        }
    }
}
