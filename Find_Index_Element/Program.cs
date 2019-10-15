using System;
using System.Linq;

namespace Find_Index_Element
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод возвращает индекс элемента в неотсортированном вещественном  массиве
        /// для которого сумма элементов слева и сумма элементов справа равны.
        /// </summary>
        /// <param name="arr">Массивв</param>
        /// <param name="index">Индекс массива</param>
        /// <returns>Индекс элемента массива</returns>
        public static int GetIndexElementFromArray(double[] arr, int index = 0)
        {
            if (arr == null)
                throw new ArgumentNullException("Array must not be null");
            decimal leftSum = 0.0M, rigthSum = 0.0M;
            int nextIndex = index;
            if (arr.Length > index)
            {
                for (int i = 0; i < nextIndex; i++)
                    leftSum += (decimal)arr[i]; //double to decimal(IEEE 754) 
                for (int i = ++nextIndex; i < arr.Length; i++)
                    rigthSum += (decimal)arr[i]; //double to decimal(IEEE 754)
                return (leftSum == rigthSum) ? index : GetIndexElementFromArray(arr, index + 1);
            }
            return -1;
        }
    }
}
