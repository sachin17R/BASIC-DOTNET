using System;


namespace SampleConApp
{
    class Ex02datatype
    {

        static void Main(string[] args)
        {
            byte a = 123;
            short b = 456;
            int c = 789;
            long d = 0212012212121012;
            Console.WriteLine($"value byteis{a},shortis {b}, int is {c},long is{d}");



            Console.WriteLine($"the val of byte is {byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"the val of int is {int.MinValue} and {int.MaxValue}");


            int vv = (int)1221240.233;
        }




    }
}
