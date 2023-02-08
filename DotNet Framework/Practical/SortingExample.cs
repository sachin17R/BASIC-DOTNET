using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFrameworksApp.Practical;
namespace FrameWorksApp.Practical
{
    class SortingExample
    {
        static void Main(string[] args)
        {
            //SortBasedOnString();
            // SortBasedOnCustomer();
            SortBAsedOnMultiCriteria();
        }

        private static void SortBAsedOnMultiCriteria()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { CustomerId = 125, CustomerName = "sachin", CustomerAddress = "mysore", BillAmount = 150 });
            customer.Add(new Customer { CustomerId = 152, CustomerName = "pavan", CustomerAddress = "bangalore", BillAmount = 1620 });
            customer.Add(new Customer { CustomerId = 512, CustomerName = "vishwa", CustomerAddress = "kallapur", BillAmount = 50 });
            customer.Add(new Customer { CustomerId = 265, CustomerName = "abhi", CustomerAddress = "valagere", BillAmount = 120 });
            customer.Add(new Customer { CustomerId = 451, CustomerName = "daya", CustomerAddress = "mumbai", BillAmount = 20 });
            customer.Add(new Customer { CustomerId = 120, CustomerName = "harsh", CustomerAddress = "krpete", BillAmount = 15 });

            Array types = Enum.GetValues(typeof(options));
            foreach (var item in types)
            {
                Console.WriteLine(item);
            }
            options choosed =(options) Enum.Parse(typeof(options), Console.ReadLine());
            customer.Sort(new SortComparer(choosed));

            foreach (var item in customer)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(item);
            }

        }

        private static void SortBasedOnCustomer()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { CustomerId = 125, CustomerName = "sachin", CustomerAddress = "mysore", BillAmount = 150 });
            customer.Add(new Customer { CustomerId = 152, CustomerName = "pavan", CustomerAddress = "bangalore", BillAmount = 1620 });
            customer.Add(new Customer { CustomerId = 52, CustomerName = "vishwa", CustomerAddress = "chikballapaura", BillAmount = 50 });
            customer.Add(new Customer { CustomerId = 65, CustomerName = "abhi", CustomerAddress = "valagere", BillAmount = 120 });
            customer.Add(new Customer { CustomerId = 451, CustomerName = "daya", CustomerAddress = "mumbai", BillAmount = 20 });
            customer.Add(new Customer { CustomerId = 120, CustomerName = "harsh", CustomerAddress = "krpete", BillAmount = 15 });

            customer.Sort();
            foreach (var item in customer)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortBasedOnString()
        {
            List<string> names = new List<string>();
            names.Add("sachin");
            names.Add("pavan");
            names.Add("abhi");
            names.Add("basava");
            names.Add("vishwas");
            names.Add("dileep");

            names.Sort();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
