using System;

namespace Assaignment_ConsoleApp
{
    class ArrayAssaignment
    {
        public static void ArrayModifier(int[,] arr)
        {
            int rank = arr.Rank;
           // Console.WriteLine(rank);
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j <arr.GetLength(0); j++)
                {
                    Console.Write( arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayAdder(int[,] arr)
        {
            int rank = arr.Rank;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            int[,] arr =new int[,] { { 1, 2, 3 }, { 4, 5, 6 },{ 7,8,9} };
            ArrayAssaignment.ArrayModifier(arr);
        }
    }
}
