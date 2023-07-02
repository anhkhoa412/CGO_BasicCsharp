using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi01_DoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int rate = 23000;
            Console.Write("Input your money in USD: ");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("Your money in VND is: " + (money * rate) + " VND");

        }
    }
}
