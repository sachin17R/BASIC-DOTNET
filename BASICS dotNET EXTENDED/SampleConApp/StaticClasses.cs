using System;


namespace SampleConApp
{
    class Sachin
    {
        public static string name;
        public Sachin()
        {
            Console.WriteLine("this is non static constructor");
        }

        static Sachin()
        {
           name = "sachin R";
            Console.WriteLine("this is static constructor");
        }
    }

    class StaticClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sachin.name);
            Sachin obj = new Sachin();
            Sachin obj1 = new Sachin();
            obj = new Sachin();
            obj = new Sachin();
            //obj = new Sachin();
            //obj = new Sachin();
            //obj = new Sachin();
        }
    }
}
