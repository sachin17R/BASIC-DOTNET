using System;

namespace Assaignment_ConsoleApp
{
    class CharCount
    {
        public static void CharCounter( string str)
        {
            int Alpha = 0;
            int num = 0;
            int spcl = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ltr = str[i];
                if(ltr <'1' && ltr > 9)
                {
                    //Console.WriteLine(ltr);
                    spcl++;
                }
                else if((ltr ==' ')||((char)ltr>='a' && (char)ltr<='z') || ((char)ltr >= 'A' && (char)ltr <= 'Z'))
                {
                    Alpha++;
                }
                else
                {
                    num++;
                }

            }

            Console.WriteLine($"alphabets         {Alpha}");
            Console.WriteLine($"numbers           {num}");
            Console.WriteLine($"special chars     {spcl}");
        }
        static void Main(string[] args)
        {
            string str = help.text("enter the string");
            CharCounter(str);
        }
    }
}
