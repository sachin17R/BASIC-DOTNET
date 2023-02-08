using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp.Practical
{
    class HashSetCollection
    {
        HashSet<Customer> customers = new HashSet<Customer>();
        public void addNewCustomer(Customer cst)
        {
           customers.Add(cst);
        }
        public HashSet<Customer> AllCustomers => customers;
    }
}
