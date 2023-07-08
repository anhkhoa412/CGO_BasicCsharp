using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGO_Buoi03_Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int i, j;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Print the rectangle");
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 7; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine("Print the square triangle");
                        for (i = 1; i <= 5; i++)
                        {
                            for (j = 0; j < i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        Console.WriteLine("Print isosceles triangle");
                        for (i = 5; i >= 1; i--)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            } while (choice != 0);
            

           

           

        }
    }
}
    
