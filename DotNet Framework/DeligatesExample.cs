using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorksApp
{
    delegate int ArithmeticOperations(int v1, int v2);
    class SubClass
    {
      public  static void Performer(ArithmeticOperations operation)
        {
            int v1 = HelperClasses.GetNumber("enter first value");
            int v2 = HelperClasses.GetNumber("enter second value");
            var functions = operation.GetInvocationList();
            foreach (Delegate item in functions)
            {
                Console.WriteLine(item.Method.Name);
                Delegate func = item as Delegate;
                Console.WriteLine("result is "+ func.DynamicInvoke(v1,v2));
            }
           //Console.WriteLine(res);
        }
    }
    class DeligatesExample
    {
        static int  mulFunc(int v1,int v2)
        {
            return v1 * v2;
        }
        static int addFunc(int v1,int v2)=>v1+v2;
        static int subFunc(int v1,int v2)=>v1-v2;
        static int divFunc(int v1,int v2)=>v1/v2;

        static void Main(string[] args)
        {
            //SubClass.Performer(delegate (int v1, int v2)
            //{
            //    return v1 + v2;
            //});
            //SubClass.Performer(new ArithmeticOperations(mulFunc));
            //SubClass.Performer((a1, a2) => a1 - a2);
            ArithmeticOperations ops = new ArithmeticOperations(mulFunc);
            ops += new ArithmeticOperations(addFunc);
            ops += new ArithmeticOperations(subFunc);
            ops += new ArithmeticOperations(divFunc);

            SubClass.Performer(ops);
        }
    }
}
