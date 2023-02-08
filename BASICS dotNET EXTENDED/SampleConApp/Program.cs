using System;

namespace SampleConApp
{
    class EX01first
    {
    public static void Main(String[] args)
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = Convert.ToInt32( Console.ReadLine());

            // Console.WriteLine("the name is " + name + " and age is " + age);

            Console.WriteLine($"name is {name} and age is {age}.");
            
        }
    }
}