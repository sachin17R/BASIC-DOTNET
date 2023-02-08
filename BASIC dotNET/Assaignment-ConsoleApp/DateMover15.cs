using System;

namespace Assaignment_ConsoleApp
{
    class DateMover15
    {
        public static void Main()
        {
            DateTime baseDate = new DateTime(2016, 3, 12);
            Console.WriteLine("    Base Date:        {0:d}\n", baseDate);

            // Show dates of previous fifteen years.
            for (int ctr = -1; ctr >= -15; ctr--)
                Console.WriteLine("{0,2} year(s) ago:        {1:d}",Math.Abs(ctr), baseDate.AddYears(ctr));
            Console.WriteLine();

            // Show dates of next fifteen years.
            for (int ctr = 1; ctr <= 15; ctr++)
                Console.WriteLine("{0,2} year(s) from now:   {1:d}",ctr, baseDate.AddYears(ctr));
        }
    }
}

