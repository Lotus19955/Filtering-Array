using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilteringArrayLib;

namespace FilteringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray= new int[] {1, 23, 54, 67, 6, 90, 5, 7, 33, 73, 98, 55887, 38, 369, 95894, 561279, 12345637, 542987, 7774};
            int number = 7;

            int[] newArray = ArrayMethods.FindNumeralInArray(myArray,number);
            if (newArray != null)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.WriteLine(newArray[i]);
                }
            }
            else
            {
                Console.WriteLine("Array is null or empty");
            }
            Console.ReadLine();
        }
    }
}
