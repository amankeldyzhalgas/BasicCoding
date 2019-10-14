using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_Digit
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод принимает массив целых чисел и фильтрует его таким образом, 
        /// чтобы на выходе остались только числа, содержащие заданную цифру
        /// </summary>
        /// <param name="arr">Массивв</param>
        /// <param name="index">Цифра</param>
        /// <returns>Отфильрованный масиив</returns>
        public static int[] FilterDigit(int[] arr, int digit)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Contains(arr[i], digit))
                    result.Add(arr[i]);
            }
            return result.ToArray<int>();
        }

        /// <summary>
        /// Метод сравнивает элемент массива и заданную 
        /// цифру и возвращает логический результат 
        /// </summary>
        /// <param name="arrayElement">Элемент массива</param>
        /// <param name="digit">Цифра</param>
        /// <returns>Логический результат</returns>
        private static bool Contains(int arrayElement, int digit)
        {
            arrayElement = Math.Abs(arrayElement);

            while (arrayElement > 0)
            {
                if (arrayElement % 10 == digit)
                {
                    return true;
                }

                arrayElement /= 10;
            }

            return false;

        }
    }
}
