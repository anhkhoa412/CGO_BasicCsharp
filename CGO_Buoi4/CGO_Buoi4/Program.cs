using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            int[] arr1 = new int [3];
            int[] arr2 = new int[3] {7,3,1};
            int[] arr3 = new int[3] { 7, 3, 1 };
            int[] arr4 = { 7, 3, 1, 4 };
            Console.WriteLine("{0} | {1} | {2} | {3}", arr1[0], arr2[0], arr3[0], arr4[0]);
            Console.WriteLine("{0} | {1} | {2} | {3}", arr1[3], arr2[3], arr3[3], arr4[3]);
            **/
            Name();

            Console.ReadKey();

            void Name()
            {
                int n = 0;
                string[] arrHoTen = new string[n];
                Console.WriteLine("Input number of n: ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap gia tri thu {0}:", i);
                    arrHoTen[i] = Console.ReadLine();
                }
                Console.WriteLine();
                Console.WriteLine("Output: ");
                for (int i = 0; i < n; i++)
                    Console.WriteLine("{0} la {1}", i, arrHoTen[i]);
            }
        }
    }
}
