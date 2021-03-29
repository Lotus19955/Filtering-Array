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
        /// Search method for a value in an array. Takes 2 parameters: 1) an array of integers; 2) the number to be found.
        /// </summary>
        /// <param name="myArray">Array of integers</param>
        /// <param name="number">The number you need to find</param>
        public static int[] FindNumeralInArray(int[] myArray, int number)
        {
            if (ValidateArray(myArray) == false)
            {
                return null;
            }
            
            int[] arrayToShow= new int[1];
            char chrNumber = char.Parse(number.ToString());
            int counter = 0;
            
            for (int i = 0; i < myArray.Length; i++)
            {
                string intParsedToString = myArray[i].ToString();
                for (int j = 0; j < intParsedToString.Length; j++)
                {
                    if (intParsedToString[j] == chrNumber)
                    {
                        int valueForShow = int.Parse(intParsedToString);
                        Array.Resize(ref arrayToShow, arrayToShow.Length + 1);
                        arrayToShow[counter] = valueForShow;
                        counter++;
                        break;
                    }
                }
            }
            Array.Resize(ref arrayToShow, arrayToShow.Length - 1);
            return arrayToShow;
        }
        /// <summary>
        /// Method for checking if the array is full or null; Accepts an array of integers.
        /// </summary>
        /// <param name="myArray">Array of integers</param>
        private static bool ValidateArray(int[] myArray)
        {
            if (myArray != null)
            {
                if (myArray.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

