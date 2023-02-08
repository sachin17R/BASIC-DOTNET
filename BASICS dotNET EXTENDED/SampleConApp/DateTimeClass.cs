using System;

using System.Threading;
namespace SampleConApp
{
    class DateTimeClass
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);
            //Console.WriteLine(dt.ToLongDateString());
            // Console.WriteLine(dt.ToShortDateString());
            // Console.WriteLine(dt.ToLongTimeString());
            // Console.WriteLine(dt.ToShortTimeString());
            //Console.WriteLine(dt.ToString("dd--mm--yyyy"));
            // Console.WriteLine($"{dt.Day}/{dt.Month}/{dt.Year}");
            //Console.WriteLine("enter date");
            // dt = DateTime.Parse(Console.ReadLine());
            // Console.WriteLine(dt);

            Console.WriteLine("enter date in same format dd/mm/yy");
            dt = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yy", null);
            Console.WriteLine(dt);


            Console.WriteLine("Enter the date as dd/MM/yyyy");
            dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Enter the Date of Birth");
            dt = DateTime.Parse(Console.ReadLine());
            var currDate = DateTime.Now;
            var span = DateTime.Now - dt;
            Console.WriteLine("The no of Days: " + span.TotalDays);
            Console.WriteLine("The no of Years: " + (currDate.Year - dt.Year));
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int no = random.Next(10, 50);
                Console.WriteLine("The Date entered: " + currDate.AddDays(no).ToLongDateString());
                Thread.Sleep(2000);
            }



        }
    }
}
