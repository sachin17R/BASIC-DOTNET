using System;

namespace Assaignment_ConsoleApp
{
    class help
    {
        public static int number(string msg)
        {
            Console.Write(msg);
            Console.WriteLine();
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
            
        }

        public static string text(string msg)
        {
            Console.Write(msg);
            Console.WriteLine();
            string txt = Console.ReadLine();
            return txt;
        }
    }
}
