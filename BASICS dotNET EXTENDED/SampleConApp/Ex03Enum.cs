using System;
namespace SampleConApp
{
    enum city {mysore,bangalore,chennai,mumbai,kolkata};
    class EnumExpample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the possible option ");
            Array Possible = Enum.GetValues(typeof(city));
            Console.WriteLine();
            for(int i = 0; i < Possible.Length; i++)
            {
                Console.Write(Possible.GetValue(i)+", ");
                
            }
            Console.WriteLine();
            object inputValue = Enum.Parse(typeof(city), Console.ReadLine(), true);

            city selected = (city)inputValue;
            Console.WriteLine("selected city is " + selected);

        }
    }
}