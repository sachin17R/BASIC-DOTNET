using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLayer;

namespace SampleFrameworksApp.Practical
{
    class MainUI
    {
        static IDataComponent component = null;
        static MainUI()
        {
          //  Console.WriteLine("Enter the Name of the Component as : List or ArrayList");
            //component = CustomerFactory.GetComponent(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            //factoryTesting();
            HashSetCollection collection = new HashSetCollection();
            collection.addNewCustomer(new Customer { CustomerId = 112, CustomerName = "sachin", CustomerAddress = "Bangalore", BillAmount = 5600 });
            collection.addNewCustomer(new Customer { CustomerId = 111, CustomerName = "sachin", CustomerAddress = "Mysore", BillAmount = 5600 });
            collection.addNewCustomer(new Customer { CustomerId = 111, CustomerName = "sachin", CustomerAddress = "Chennai", BillAmount = 5600 });
            collection.addNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            collection.addNewCustomer(new Customer { CustomerId = 112, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            Console.WriteLine("The Total no of Customers: " + collection.AllCustomers.Count);

            foreach (var customer in collection.AllCustomers)
                Console.WriteLine(customer);

        }
        private static void factoryTesting()
        {
            component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Kundapur", BillAmount = 5600 });
            component.UpdateCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Udupi", BillAmount = 5600 });
            var data = component.GetAllCustomers();
            foreach (Customer customer in data)
                Console.WriteLine(customer);
            component.DeleteCustomer(111);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
