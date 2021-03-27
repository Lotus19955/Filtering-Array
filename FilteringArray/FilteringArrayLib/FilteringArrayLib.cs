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
        /// Метод сортировки массива целых чисел от меньшего к большему. Принимает массив целых чисел.
        /// </summary>
        /// <param name="MyArray">Массив целых чисел</param>
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
        /// Метод поиска значение в массиве. Принимает 2 параметра: 1)массив целых чисел; 2)число которое нужно найти.
        /// </summary>
        /// <param name="MyArray">Массив целых чисел</param>
        /// <param name="IntWhatWeFinde">Число которое необходимо найти</param>
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
        /// Метод проверки на заполненяемость массива; Принимает массив челых чисел.
        /// </summary>
        /// <param name="MyArray">Массив целых чисел</param>
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
        /// Метод проверяет длинну массива на 20 индексов
        /// </summary>
        /// <param name="MyArray">Массив целых чисел</param>
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

