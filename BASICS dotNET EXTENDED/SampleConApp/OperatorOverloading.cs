using System;

namespace SampleConApp
{
    class Employee
    {
        public int accno { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        public static Employee operator +(Employee emp,int amount)
        {
            emp.salary += amount;
            return emp;
        }
        public static Employee operator -(Employee emp, int amount)
        {
            emp.salary -= amount;
            return emp;
        }
        public static Employee operator *(Employee emp, int amount)
        {
            emp.salary *= amount;
            return emp;
        }
    }
    class OperatorOverloading
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                accno = 12345,
                name = "sachin",
                salary = 5000
            };

            emp += 3000;
            Console.WriteLine($"salary amount is {emp.salary} ");
            emp *= 5;
            Console.WriteLine($"salary amount is {emp.salary} ");

        }
    }
}
