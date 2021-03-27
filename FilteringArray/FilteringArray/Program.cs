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
            int[] MyArray = new int[] { 1, 23, 54, 67, 6, 90, 5, 7, 33, 73, 98, 55887, 38, 369, 95894, 561279, 12345637, 542987, 7774 };
            int IntWhatWeFinde = 7;

            ArrayMethods.ArraySorting(MyArray);
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"{MyArray[i]}\t");
            }

            ArrayMethods.FindeNumeralInArray(MyArray,IntWhatWeFinde);
            Console.ReadLine();
        }
    }
}
