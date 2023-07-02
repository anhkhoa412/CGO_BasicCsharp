using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi02_CountNumber
{
    class Program
    {
        private void OneNumber(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twele ");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Forteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("NineTeen");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }
        }
        private void TwoNumber(int number)
        {
                int tens = number / 10;               
                int ones = number % 10;          
                string te = "";
                string on = "";
                switch (tens)
                {
                    case 2:
                        te = "Twenty" ;
                        break;
                    case 3:
                        te = "Thirty";
                        break;
                    case 4:
                        te = "Forty";
                        break;
                    case 5:
                        te = "Fifty";
                        break;
                    case 6:
                        te = "Sixty";
                        break;
                    case 7:
                        te = "Seventy";
                        break;
                    case 8:
                        te = "Eighty";
                        break;
                    case 9:
                        te = "Ninety";
                        break;
                    default:
                        Console.WriteLine("Out of ability");
                        break;

                }
                switch (ones)
                {
                    case 1:
                        on = "One";
                        break;
                    case 2:
                        on = "Two";
                        break;
                    case 3:
                        on = "Three";
                        break;
                    case 4:
                        on = "Four";
                        break;
                    case 5:
                        on = "Five";
                        break;
                    case 6:
                        on = "Six";
                        break;
                    case 7:
                        on = "Seven";
                        break;
                    case 8:
                       on = "Eight";
                        break;
                    case 9:
                        on = "Nine";
                        break;
                }

                Console.WriteLine(te +" "+on);
            }
        private void ThreeNumber(int number)
        {
            int hundred = number / 100;
            int ones = number % 10;           
            int tens = number / 10 % 10;           
            string hun = "";
            string te = "";
            string on = "";
            switch (hundred)
            {
                case 1:
                    hun = "One hundred";
                    break;
                case 2:
                    hun = "Two hundred";
                    break;
                case 3:
                    hun = "Three hundred";
                    break;
                case 4:
                    hun = "Four hundred";
                    break;
                case 5:
                    hun = "Five hundred";
                    break;
                case 6:
                    hun = "Six hundred";
                    break;
                case 7:
                    hun = "Seven hundred";
                    break;
                case 8:
                    hun = "Eight hundred";
                    break;
                case 9:
                    hun = "Nine hundred";
                    break;
            }
            switch (tens)
            {
                case 2:
                    te = "twenty";
                    break;
                case 3:
                    te = "thirty";
                    break;
                case 4:
                    te = "forty";
                    break;
                case 5:
                    te = "fifty";
                    break;
                case 6:
                    te = "sixty";
                    break;
                case 7:
                    te = "seventy";
                    break;
                case 8:
                    te = "eighty";
                    break;
                case 9:
                    te = "ninety";
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;

            }
            switch (ones)
            {
                case 1:
                    on = "One";
                    break;
                case 2:
                    on = "Two";
                    break;
                case 3:
                    on = "Three";
                    break;
                case 4:
                    on = "Four";
                    break;
                case 5:
                    on = "Five";
                    break;
                case 6:
                    on = "Six";
                    break;
                case 7:
                    on = "Seven";
                    break;
                case 8:
                    on = "Eight";
                    break;
                case 9:
                    on = "Nine";
                    break;
            }

            Console.WriteLine(hun + " and " + te + " " + on);
        }
        static void Main(string[] args)
        {

            Console.Write("Input your number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 20)
            {
                Program program = new Program();
                program.OneNumber(number);
            }
            if (number > 20 && number < 100)
            {
                Program program = new Program();
                program.TwoNumber(number);
            }

            if (number >= 100 )
            {
                Program program = new Program();
                program.ThreeNumber(number);

            }

        }
    }
}
