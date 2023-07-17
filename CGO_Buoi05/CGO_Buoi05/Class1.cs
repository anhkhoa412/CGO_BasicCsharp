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

        public void Main(string[] args) {
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
                        Console.WriteLine("Input Faren: ");
                        fahrenheit = int.Parse(Console.ReadLine());
                        FaToCel(fahrenheit);
                        break;
                    case 2:
                        Console.WriteLine("Input Cel: "); 
                        celsius = int.Parse(Console.ReadLine());
                        CelToFa(celsius);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }
    }
}
