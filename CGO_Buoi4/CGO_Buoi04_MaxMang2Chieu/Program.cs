using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_MaxMang2Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random matrix 
            Random rd = new Random();
            int w = 3, h = 3;
            int[,] arr2d = new int[h, w];
            int c = 0;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    arr2d[i, j] = rd.Next(0, 9);
                    Console.Write(arr2d[i, j] + " ");

                    if (c < arr2d[i, j])
                    {
                        c = arr2d[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Max is: {0} ", c);

            //Input from user: 
            int y = 0;
            Console.Write("Enter the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns:");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter the value for element at position [{i}, {j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));

                    if (y < matrix[i, j])
                    {
                        y = matrix[i, j];
                    }
                }
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine();
            Console.WriteLine("Max is: {0} ", y);
        }
    }
}
       
        

   