using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class GenericCollection
    {
        static void Main(string[] args)
        {
            // ListExample();
            //hashSetExample();
            DictionaryExample();
        }

        static Dictionary<string, int> users = new Dictionary<string, int>();
        public static void DictionaryExample()
        {
            do
            {
                string selected = Utilities.Prompt("press 1 to register and press 2 for login");
                if (selected == "1")
                {
                    RegisterFunc();
                }
                else if (selected == "2")
                {
                    LoginFunc();
                }
                else
                {
                    Console.WriteLine("wrong selection broooo");
                }

            } while (true);

        }

        private static void LoginFunc()
        {
            RETRY:
                string UName = Utilities.Prompt("enyter the user name");
            int Pass = Utilities.GetNumber("enter the password");
            if (users.ContainsKey(UName))
            {
                if (users[UName] == Pass)
                {
                    Console.WriteLine("login successsfull");
                }
                else
                {
                    goto RETRY;
                }
            }
            else
            {
                Console.WriteLine("user not exists");
                DictionaryExample();
            }
        }

        public static void RegisterFunc()
        {

            string UName = Utilities.Prompt("enter the user name");
            int Pass = Utilities.GetNumber("enter the password");
            if (users.ContainsKey(UName))
            {
                Console.WriteLine("user already exists please login");
                return;
            }
            else
            {
                users.Add(UName, Pass);
                Console.WriteLine("registered successfully");
                DictionaryExample();
            }
        }

        private static void hashSetExample()
        {
            HashSet<string> hash = new HashSet<string>();
            hash.Add("sachin");
            hash.Add("vishwas");
            hash.Add("pavan");
            hash.Add("sudarshan");
            hash.Add("sudarshan");
            hash.Add("sudarshan");
            //            hash.Remove("sachin");
            // hash.Intersect("sachin");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
            if (!hash.Add("sachin"))
            {
                Console.WriteLine("already added " + hash.Count);
            }
        }

        private static void ListExample()
        {
            string[] names = { "dfdsfd", "ffdfd", "dfdsfd" };
            List<string> cars = new List<string>(names);
            cars.Add("sasdhklsad");
            cars.Add("sdsdsd");
            cars.Add("sdsdsdsd");
            cars.Add("dsdsd");
            cars.Add("sdsdsds");
            cars.Insert(2, "sachin");

            names = cars.ToArray();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
