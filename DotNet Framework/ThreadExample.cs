using System;
using System.IO;
using System.Threading;

namespace SampleFrameworksApp
{
    class Ex_11_MultiThreading
    {
        static void LargeFuncWithParameters(object data)
        {
            string filename = data.ToString();
            var contents = File.ReadAllLines(filename);

            foreach (var line in contents)
            {
                Thread.Sleep(1000);

                foreach (var ch in line.ToCharArray())
                {
                    Console.Write(ch);
                    Thread.Sleep(200);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Complete set of Records is read");
        }

        static void LargeFunction()
        {
            Console.WriteLine("The large function has started");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Large Func is doing some job!!!");
            }
            Console.Clear();
            Console.WriteLine("The large function has completed");


        }

        static void ParameterizedThreadOperation()
        {
            ParameterizedThreadStart threadOp = new ParameterizedThreadStart(LargeFuncWithParameters);
            Thread th = new Thread(threadOp);
            th.IsBackground = true;
            th.Start("../../MOCK_DATA.csv");
            th.Join();
        }
        static void Main(string[] args)
        {

            ParameterizedThreadOperation();
            //Console.WriteLine("Main is doing its job");
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Main is doing some job!!!");
            //}
            //Console.WriteLine("The Main has ended, UR App now Terminates!!!!");


            //ThreadStart tFunc = new ThreadStart(LargeFunction);
            //Thread thread = new Thread(tFunc);
            //thread.Start();
            //Console.WriteLine("Main is doing its job");
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Main is doing some job!!!");
            //}
            //Console.WriteLine("The Main has ended, UR App now Terminates!!!!");
        }
    }
}