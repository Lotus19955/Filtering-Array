using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringArrayLib
{
    public class ArrayMethods
    {
        /// <summary>
        /// A method for sorting integers from smallest to largest. Takes an array of integers
        /// </summary>
        /// <param name="MyArray">Array of integers</param>
        public static void ArraySorting(int[] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int y = i + 1; y < MyArray.Length; y++)
                {
                    if (MyArray[i] > MyArray[y])
                    {
                        int num = MyArray[i];
                        MyArray[i] = MyArray[y];
                        MyArray[y] = num;
                    }
                }
            }
        }

        /// <summary>
        /// Search method for a value in an array. Takes 2 parameters: 1) an array of integers; 2) the number to be found.
        /// </summary>
        /// <param name="MyArray">Array of integers</param>
        /// <param name="IntWhatWeFinde">The number you need to find</param>
        public static void FindeNumeralInArray(int[] MyArray, int IntWhatWeFinde)
        {
            char StrWhatWeFinde = Char.Parse(IntWhatWeFinde.ToString());
            string[] StrArray = new string[MyArray.Length];
            for (int i = 0; i < MyArray.Length; i++)
            {
                StrArray[i] = MyArray[i].ToString();
            }
            for (int i = 0; i < StrArray.Length; i++)
            {
                if (StrArray[i].Contains(StrWhatWeFinde))
                {
                    int ValueForShow = int.Parse(StrArray[i]);
                    Console.WriteLine(ValueForShow);
                }
            }
        }
        /// <summary>
        /// Method for checking if the array is full or null; Accepts an array of integers.
        /// </summary>
        /// <param name="MyArray">Array of integers</param>
        private static void CheckArrayForNull (int [] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] == 0)
                {
                    Console.WriteLine($"Индекс массив {MyArray[i]} равен 0");
                }
                if (i == MyArray.Length)
                {
                    break;
                }
            }
        }//не особо понял задание + как вывести "privat" в мейн
        /// <summary>
        /// The method checks the length of the array by 20 indices
        /// </summary>
        /// <param name="MyArray">Array of integers</param>
        private static void CheckArrayForLength(int[] MyArray)
        {
            if (MyArray.Length > 20)
            {
                Console.WriteLine($"Массив MyArray не прошел проверку на вместимость");
                Console.WriteLine("Массив будет увеличен на 1 индекс");
                Array.Resize(ref MyArray, MyArray.Length + 1);
            }
        } //не особо понял задание + как вывести "privat" в мейн
    }
}

