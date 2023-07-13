using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi4_chengiatri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            int value, index;
            Console.Write("number you want to add: ");
            value = int.Parse(Console.ReadLine());
            Console.Write("Where do you want to add? ");
            index = int.Parse(Console.ReadLine());  


        }
    }
}
