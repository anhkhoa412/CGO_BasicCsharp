using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_InsertElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns:");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter the value for element at position [{i}, {j}]:");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Input the number X you want to replace: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Input the row you want to replace: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Input the collumn you want to replace: ");
            int c = int.Parse(Console.ReadLine());  

            if (r > rows || c > columns)
            {
                Console.WriteLine("Cannot insert");
            }
            else
            {
                matrix[r, c] = x; 
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
