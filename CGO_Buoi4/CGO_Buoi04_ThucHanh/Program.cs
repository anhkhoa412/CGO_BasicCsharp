using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CGO_Buoi04_ThucHanh
{
    internal class Program
    {
        private void useArray()
        {
            Console.WriteLine("Input number of n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int tong = 0;
            foreach (int item in a)
            {
                Console.Write(item + ": ");
                tong = tong + item;
            }
            Console.WriteLine("Overall ", +tong);
            Console.ReadKey();
        }
        private void useList()
        {
            Console.WriteLine("Input number of n: ");
            int n = int.Parse(Console.ReadLine());

            List<int> lstInpt = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}= ", i);
                lstInpt.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join("|",lstInpt));
           
            Console.WriteLine("\nOverall " + lstInpt.Sum());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of n: ");
            int n = int.Parse(Console.ReadLine());

            List<int> lstInpt = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}= ", i);
                lstInpt.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join("|", lstInpt));

            Console.WriteLine("\nOverall " + lstInpt.Sum());

            int find = 5;
            

            int position = lstInpt.IndexOf(find);
            if (position > 0)
            {
                Console.WriteLine("Tim thay tai thu {0} ", +position);
            }
            else
                Console.WriteLine("No found");

            int maxValue = lstInpt.Max();
            
            Console.WriteLine("So lon nhat la {1} Tim thay tai thu {0} ", +lstInpt.IndexOf(maxValue), maxValue);
            Console.ReadKey();
        }
    }
}
