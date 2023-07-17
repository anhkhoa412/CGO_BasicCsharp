using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05
{

    class NhietDo
    {
        public static double CelToFa(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        public static double FaToCel(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }

        public static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Input Faren: ");
                        fahrenheit = int.Parse(Console.ReadLine());
                        Console.WriteLine(FaToCel(fahrenheit) + "C" );
                        break;
                    case 2:
                        Console.Write("Input Cel: ");
                        celsius = int.Parse(Console.ReadLine());
                        Console.WriteLine(CelToFa(celsius) + "F" );
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }
    }
}
