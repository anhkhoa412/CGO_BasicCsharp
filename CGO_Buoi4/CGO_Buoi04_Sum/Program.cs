using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of n ");
            int n = int.Parse(Console.ReadLine());  
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gia tri thu {0}= ", i);
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join("|", list));
            Console.WriteLine("Sum is: {0} ", +list.Sum());
        }
    }
}
