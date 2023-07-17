using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_DelElement
{
    internal class Program
    {
        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Output(int[] a, int n)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
        private static void DelElement(int m, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == m)
                {
                    arr[i] = arr[i + 1];
                    arr[arr.Length - 1] = 0;
                }
                else
                    Console.Write("Not Found");
            }
            

            Console.WriteLine("The modified array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Nhap so ptu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Input(arr, n);
            Output(arr, n);
            Console.WriteLine("Nhap so ban muon xoa");
            int index = int.Parse(Console.ReadLine());  
            DelElement(index, arr);

        }
    }
}
