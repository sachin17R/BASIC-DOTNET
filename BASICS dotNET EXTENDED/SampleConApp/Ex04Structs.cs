using System;

namespace SampleConApp
{
    struct employeee
    {
        /* public int empId { get; set; }
         public string empName { get; set; }
         public string empaddress { get; set; }

      */
      public  int empId;
       public string empName;
       public string empaddress;
         employeee(int aa,string bb,string cc)
        {
            this.empId = aa;
            this.empName = bb;
            this.empaddress = cc;
        }
        public string gettingvalues()
        {
            return $"employyee ID is {empId} and Name Is {empName} and address is {empaddress}";
        }

    }
    class Ex04Structs
    {
        static void Main(string[] args)
        {
            employeee emp = new employeee { empId = 1234, empName = "sachin", empaddress = "mysore" };
            Console.WriteLine(emp.gettingvalues());
        }
    }
}
