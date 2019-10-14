using System;
using System.Linq;

namespace Find_Max_Element
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод возвращает максимального элемента в неотсортированном 
        /// целочисленом массиве с применением рекурсивного алгоритма .
        /// </summary>
        /// <param name="arr">Массивв</param>
        /// <param name="index">Индекс массива</param>
        /// <exception cref="ArgumentNullException">Выдает исключение если массив null</exception>
        /// <exception cref="ArgumentException">Выдает исключение если массив пустой</exception>
        /// <returns>Максимальный элемент массива</returns>
        public static int GetMaxElementFromArray(int[] arr, int index = 0)
        {
            if (arr == null)
                throw new ArgumentNullException("Array must not be null");
            if (!arr.Any())
                throw new ArgumentException("Array cannot be empty");
            var max = arr[0];
            if (arr.Length > index)
            {
                max = GetMaxElementFromArray(arr, index + 1);
                return (arr[index] > max) ? arr[index] : max;
            }
            else
            {
                return max;
            }
        }
    }
}
