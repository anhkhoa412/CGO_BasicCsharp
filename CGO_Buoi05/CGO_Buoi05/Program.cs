using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05
{
    internal class Program
    {
        static void swap (ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c ; 
        }
        static void main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            swap(ref a, ref b);

            Console.WriteLine("After swap a= " + a + " b= " + b);

        }
    }
}
