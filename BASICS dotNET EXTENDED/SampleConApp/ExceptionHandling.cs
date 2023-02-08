using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Infotainment
    {
        public string Name { get; set; }
        public bool HasMaps { get; set; }
        public bool HasUSB { get; set; } = true;
        public bool HasAuxillary { get; set; } = true;
        public bool HasCd { get; set; }
        public string CurrentPlayer { get; set; } = "CD Player";
    }
    class Car
    {
        public string ChasisNo { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public int NoOfSeats { get; set; }

        public Car(Infotainment infotainment)
        {
            this.Infotainment = infotainment;
        }

        public void ReplaceInfotainment(Infotainment infotainment)
        {
            this.Infotainment = infotainment;
        }
        public Infotainment Infotainment { get; private set; }

        public void Run()
        {
            Console.WriteLine("Car has started");
            Console.WriteLine("Player of the type {0} has started in {1}", Infotainment.CurrentPlayer, Infotainment.Name);
        }

    }

    class BaseClass2
    {
        public BaseClass2()
        {
            Console.WriteLine("this is baseclass default constructor");
        }
        public BaseClass2(int no):this("sachin")
        {
            Console.WriteLine($"para {no} int");
        }
        public BaseClass2(string name):this()
        {
            Console.WriteLine("this is {0} constructor ",name);
        }
    }
    class DerivedClass2 : BaseClass2
    {
        public DerivedClass2(int no):base(no+100)
        {
            
            Console.WriteLine($"this is {no} derived class default constructor");
        }
    }
    class ConstructorTopic
    {
        static void Main(string[] args)
        {
            //Car car = new Car(new Infotainment
            //{
            //    Name = "SONY",
            //    HasMaps = false
            //});
            //car.Run();

            DerivedClass2 deri = new DerivedClass2(100);
        }
    }
}
