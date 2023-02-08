using System;

namespace SampleConApp
{
    interface IGrow
    {
        void trading();
    }
    interface Igrow2
    {
        void trading();
    }

    class DerivedClass1 : IGrow,Igrow2
    {
        void IGrow.trading()
        {
            Console.WriteLine("this is interface");
        }
       void Igrow2.trading()
        {
            Console.WriteLine("this is second interface");
        }
    } 
    class InterfaceToopic
    {
        static void Main(string[] args)
        {
            IGrow obj = new DerivedClass1();

            obj.trading();

            Igrow2 obj1 = new DerivedClass1();
            obj1.trading();
        }
    }
}
