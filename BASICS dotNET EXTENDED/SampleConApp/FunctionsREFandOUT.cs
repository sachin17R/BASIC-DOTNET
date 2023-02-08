using System;


namespace SampleConApp
{
    class extraclass
    {
       public static int adding(int v1,int v2)
        {
            return (v1 + v2);
        }
        public int multiply()
        {
            int a = 2, b = 3;
            return a * b;
        }
        internal void rootingFunc(int pval, ref double sqrvalue, ref double sqrtval)
        {
            sqrvalue = pval * pval;
            sqrtval = Math.Sqrt(pval);
        }

        internal void mathOpertaionOut(int v1, int v2, out double adding, out double substract, out double multiply,out double divide)
        {
            adding = v1 + v2;
            substract = v1 - v2;
            multiply = v1 * v2;
            divide= v1 / v2;
        }
    }
    class FunctionsREFandOUT
    {
        static void Main(string[] args)
        {
            extraclass eclass = new extraclass();
            //int res=  extraclass.adding(10, 20);
            //  Console.WriteLine(res);

            // int res1 = eclass.multiply();
            //  Console.WriteLine(res1);

            //////pass by reff///////
            ///
            //int pvalue = 16;
            //double sqrvalue = 0, sqrtval = 0;
            //eclass.rootingFunc(pvalue, ref sqrvalue, ref sqrtval);
            //Console.WriteLine($"square value id {sqrvalue} and sqrt value is {sqrtval}");


            ///////pass by out//////
            int value1 = 120, value2 = 12;
            double add, sub, mul, div;

            eclass.mathOpertaionOut( value1, value2, out add,out sub,out mul,out div);

            Console.WriteLine($"add= {add}\n  sub= {sub}\n  mul={mul}\n div={div}");

        }

    }
}
