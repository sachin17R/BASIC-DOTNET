using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp.Practical
{
    /// <summary>
    /// Represents the entity of our application.
    /// </summary>
    class Customer : IComparable<Customer>
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int BillAmount { get; set; }

        public void Copy(Customer cst)
        {
            CustomerId = cst.CustomerId;
            CustomerName = cst.CustomerName;
            CustomerAddress = cst.CustomerAddress;
            BillAmount = cst.BillAmount;
        }
        public override int GetHashCode()
        {
            return CustomerId.GetHashCode();
        }
        //Logical equivalence of UR object
        public override bool Equals(object obj)
        {
            if (obj is Customer)
            {
                var unBoxed = obj as Customer;
                if (CustomerId == unBoxed.CustomerId && CustomerName == unBoxed.CustomerName && CustomerAddress == unBoxed.CustomerAddress)
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Id: {CustomerId} \t Name: {CustomerName} \t from: {CustomerAddress} \t Amount: {BillAmount}";
        }

        public int CompareTo(Customer other)
        {
            return BillAmount.CompareTo(other.BillAmount);
        }
    }
    enum options { Id,Name,Address,Bill}
    class SortComparer : IComparer<Customer>
    {
        private options select;
        public SortComparer(options select)
        {
            this.select = select;
        }

        public int Compare(Customer x, Customer y)
        {
            switch (select)
            {
                case options.Id:
                    return x.CustomerId.CompareTo(y.CustomerId);
                case options.Name:
                    return x.CustomerName.CompareTo(y.CustomerName);
                case options.Address:
                    return x.CustomerAddress.CompareTo(y.CustomerAddress);
                case options.Bill:
                    return x.CompareTo(y);
            }
            return 0;
        }
    }
}
