using System;

namespace Assaignment_ConsoleApp
{
    class CharConverterAssaignmnet
    {
        public static void Converter(string str)
        {
            String result = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if(ch>='a' && ch <= 'z')
                {
                    result += (char)(((int)ch) - 32);
                }
                else if(ch ==' ')
                {
                    result += ' ';
                }
                else 
                {
                    result += (char)(((int)ch) + 32);
                }
            }
            Console.WriteLine(result);

        }

        private static string toUpper(char ch)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the string it countains both upper and lower case");
            string str = Console.ReadLine();
            Converter(str);
        }
    }
}
