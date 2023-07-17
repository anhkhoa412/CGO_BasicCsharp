using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_TimMin
{
    internal class Program
    {
        public static int MinValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }
        static void Main(string[] args)
        {
                int[] arr = { 1,2,4,2,3,1,4,5,9 };
                int index = MinValue(arr);
                Console.WriteLine("The smallest element in the array is: " + arr[index]);
            
        }
    }
}
