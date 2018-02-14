using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndForArray = rnd.Next(3, 8);

            int[][] arr = new int[rndForArray][];
            int[][] mirrorarray = new int[rndForArray][];

            int Index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rnd.Next(1, 5)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (Index <= arr[i].Length)
                    {
                        Index = arr[i].Length;

                    }
                    arr[i][j] = rnd.Next(0, 10);
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" index = " + Index);



            for (int i = 0; i < mirrorarray.Length; i++)
            {
                mirrorarray[i] = new int[Index * 2];
            }


            Console.WriteLine("\n\n");
            for (int i = 0; i < mirrorarray.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    // if (arr[i][j] != null)
                    mirrorarray[i][j] = arr[i][j];
                    // else mirrorarray[i][j] = 0;
                    Console.Write(mirrorarray[i][j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < mirrorarray.Length; i++)
            {
                for (int j = 0; j < /*mirrorarray[i].Length*/mirrorarray[i].Length; j++)
                {
                    if (mirrorarray[i][j] == null)
                        mirrorarray[i][j] = 10;
                    Console.Write(mirrorarray[i][j] + " ");
                }
                Console.WriteLine();

            }

            // int q = 0;

            for (int i = 0; i < mirrorarray.Length; i++)
            {
                int q = mirrorarray[i].Length - 1;
                Console.WriteLine("q = " + q);
                for (int j = 0; j <= arr[i].Length && q >= arr[i].Length; j++, q--)
                {

                    if (mirrorarray[i][j] == 0)
                    {
                        mirrorarray[i][q] = 0;
                    }
                    else if (mirrorarray[i][j] != 0) { mirrorarray[i][q] = 10 - mirrorarray[i][j]; }
                    Console.WriteLine("q " + q);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < mirrorarray.Length; i++)
            {

                for (int j = 0; j < mirrorarray[i].Length; j++)
                {
                    Console.Write(mirrorarray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}