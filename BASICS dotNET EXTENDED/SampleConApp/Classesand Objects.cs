using System;

namespace SampleConApp
{
    class account
    {
        public int accountId { get; set; }
        public string Name { get; set; }
        public double balance { get;private set; }=1000;

       public void Credit(int amount)
        {
            balance += amount;
        }
        public void Debit(int amount)
        {
            if (amount > balance)
            {
                throw new Exception("insufficient balance");
            }
            else
            {
                balance -= amount;
            }
        }
    }
    class employee1
    {
        int id;
        string name, address;
        double salary;

        public int empId
        {
            get { return id; }
            set { id = value; }
        }
        public string empName
        {
            get { return name; }
            set { name = value; }
        }
        public string empaddress
        {
            get { return address; }
            set { address = value; }
        }
        public double empsalary
        {
            get { return salary; }
            set { salary = value; }
        }

    }
    class accountManager
    {
       
    }
    class Classesand_Objects
    {
        static void Main(string[] args)
        {
            account acc = new account { accountId = 3338, Name = "sachin" };
            Console.WriteLine("balance is "+ acc.balance);
            acc.Credit(2000);
            Console.WriteLine("acc balance is "+ acc.balance);
            try
            {
                acc.Debit(10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


            employee1 emp = new employee1 { empaddress = "Bangalore", empId = 111, empName = "sachin", empsalary = 56000 };
            Console.WriteLine("the name is  "+ emp.empName);

        }   
    }
}
