using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_ChinhNhietDo
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

        static void Decrease(int[] a, int n)
        {
            Console.Write("Hien thi mang giam dan:");
            int t;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        // Hoan vi 2 so a[i] va a[j]
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
                Console.Write(a[i] + " ");
            }

        }

        static void Increase(int[] a, int n)
        {
            Console.Write("Hien thi mang tang dan:");
            int t;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        // Hoan vi 2 so a[i] va a[j]
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
                Console.Write(a[i] + " ");
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so ptu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Input(arr, n);
            Output(arr, n);
            Console.WriteLine();
            Decrease(arr, n);
            Console.WriteLine();
            Increase(arr, n);
            Console.WriteLine();

            List<int> a = new List<int>();  
           
            for(int i = 0; i < n; i++)
            {
               Console.Write("Gia tri thu {0}= ", i);
               a.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join("|", a));
            Console.WriteLine("Sx Tang: " + string.Join("|", a.OrderBy(p => p)));
            Console.WriteLine("Sx Giam: " + string.Join("|", a.OrderByDescending(p=>p)));


            a.Sort();

            Console.Write("Hien thi mang tang dan:");
            foreach (int item in a){
                Console.Write(item);
            }
            Console.WriteLine();
            Console.Write("Hien thi mang giam dan:");
            a.Reverse();
            foreach (int ite in a)
            {
                Console.Write(ite);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
