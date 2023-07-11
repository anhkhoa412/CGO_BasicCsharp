using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_TimMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine()); 
            List<int> list = new List<int>();   
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input element {0}: ",i);
                list.Add(int.Parse(Console.ReadLine()));
            }

            int maxValue = list.Max();
            Console.WriteLine("Max Value is {0} at possition {1}", maxValue, list.IndexOf(maxValue));

            Console.ReadKey();
        }
    }
}
