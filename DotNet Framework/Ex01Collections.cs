using System;
using System.Collections;


namespace FrameWorksApp
{
    class Ex01Collections
    {
        static void Main(string[] args)
        {
            ArrayListExample();
        }

        private static void ArrayListExample()
        {

            ArrayList cars = new ArrayList();
            cars.Add("Range Rover");
            cars.Add("X U V");
            cars.Add("wolksvagon");
            cars.Add("benz");
            cars.Add("ford");
            cars.Add("ferrari");
            cars.Remove("benz");
            cars.Insert(3, "sachin");
            cars.RemoveAt(3);

            Console.WriteLine("no of cars are " + cars.Count);

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}

