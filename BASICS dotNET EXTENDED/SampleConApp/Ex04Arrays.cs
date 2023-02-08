using System;


namespace SampleConApp
{
    class Ex04Arrays
    {
        static void Main(string[] args)
        {
            string[] cars = { "lamb", "benx", "shelby", "ford" };

            Console.WriteLine(cars.Length);
            Console.WriteLine(cars.Rank);

            foreach (string names in cars)
            {
                Console.WriteLine(names);
            }

            Console.WriteLine(  );
            Console.WriteLine(  );
            Console.WriteLine(  );
            int[] arr = new int[5];
            //Console.WriteLine("enter the values of array");
            //for(int i = 0; i < 5; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write(item+" " );
            //}
            //{

            //}
            ////////////////////////////multi dimentional array//////////////////////////

            int[,] data = new int[,] { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i = 0; i < data.GetLength(0); i++)
            {
                string row = "";
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    row += data[i, j] + " "; 
                }
                Console.WriteLine(row.TrimEnd());
                Console.WriteLine();
            }

        }
    }
}
