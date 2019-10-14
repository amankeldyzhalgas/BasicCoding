using System;

namespace Insert_Number
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    /// </summary>
    public class Program
    {
        private const int maxIndex = 31;

        /// <summary>
        /// Метод вводит биты из второго числа  в диапазон позиций первого числа.
        /// </summary>
        /// <param name="numberSource">Первое число</param>
        /// <param name="numberIn">Второе число</param>
        /// <param name="indexI">Первый индекс</param>
        /// <param name="indexJ">Второй индекс</param>
        /// <exception cref="ArgumentException">Выдает исключение при получении неправильного диапазона индексов</exception>
        /// <returns>Число на выходе</returns> 
        public static int InsertNumber(int numberSource, int numberIn, int indexI, int indexJ)
        {
            if (indexI > indexJ || indexI < 0 || indexJ < 0 || indexI > maxIndex || indexJ > maxIndex)
            {
                throw new ArgumentException("Wrong range of indexies. Check the values.");
            }

            int[] binarySource = NumberToBinaryArray(numberSource);
            int[] binaryIn = NumberToBinaryArray(numberIn);
            for (int i = binarySource.Length - 1 - indexI, j = binarySource.Length - 1; i >= binarySource.Length - 1 - indexJ; i--, j--)
            {
                binarySource[i] = binaryIn[j];
            }

            return BinaryArrayToNumber(binarySource);
        }

        /// <summary>
        /// Метод возвращает двоичное представление полученного числа.
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Массив целых чисел</returns>
        private static int[] NumberToBinaryArray(int number)
        {
            int[] binaryArr = new int[32];
            int i = binaryArr.Length - 1;
            while (number >= 1)
            {
                if (number % 2 == 0)
                {
                    binaryArr[i] = 0;
                }
                else
                {
                    binaryArr[i] = 1;
                }

                number /= 2;
                i--;
            }

            return binaryArr;
        }

        /// <summary>
        /// Метод возвращает число переобразованного от массива.
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <returns>Число</returns>
        private static int BinaryArrayToNumber(int[] arr)
        {
            int number = 0;
            for (int i = arr.Length - 1, power = 1; i >= 0; i--, power *= 2)
            {
                number += arr[i] * power;
            }

            return number;
        }
    }

}
