using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi4_Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int w = 3, h = 3;
            int[,] arr2d = new int[h, w];
            for (int i = 0; i <h; i++)
            {
                for(int j =0; j <w; j++)
                {
                    arr2d[i,j] = rd.Next(0,9);
                    Console.Write(arr2d[i,j] + " ");  
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
