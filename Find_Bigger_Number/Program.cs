using System;
using System.Diagnostics;

namespace Find_Bigger_Number
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод принимает положительное целое число и возвращает ближайшее наибольшее 
        /// целое, состоящее из цифр исходного числа, и null (или -1)
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Число или -1 если такого числа не существует</returns>
        public static int FindNextBiggerNumber(int number)
        {
            int[] arr = new int[number.ToString().Length];
            for (int i = 0; i < number.ToString().Length; i++)
            {
                arr[i] = int.Parse((number.ToString())[i].ToString());
            }
            return ArrayToNumber(arr);
        }

        /// <summary>
        /// Метод идет с конца массива на начало, находит следующую большую цифру 
        /// после текущего, меняет их местами и сортирует массив
        /// </summary>
        /// <param name="arr">Массивв</param>
        /// <returns>Индекс элемента массива</returns>
        private static int ArrayToNumber(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    Swap(ref arr[i], ref arr[i - 1]);
                    if (i != arr.Length - 1)
                    {
                        QuickSort(arr, i, arr.Length - 1);
                    }
                    return Convert.ToInt32(string.Concat(arr));
                }
            }
            return -1;
        }

        /// <summary>
        /// Метод заменяет два элемента в массиве
        /// </summary>
        /// <param name="firstElement">Первый элемент</param>
        /// <param name="secondElement">Второй элемент</param>
        private static void Swap(ref int firstElement, ref int secondElement)
        {
            var temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }

        /// <summary>
        /// Метод возвращает время нахождения ближайшего наибольшего числа
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Время</returns>
        public static Stopwatch GetTime(int number)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            FindNextBiggerNumber(number);
            timer.Stop();
            return timer;
        }

        /// <summary>
        /// Метод сортирует массив по алгоритму быстрой сортировки
        /// </summary>
        /// <param name="arr">Массивв</param>
        /// <param name="left">Начальный индекс массива</param>
        /// <param name="right">Последний индекс массива</param>
        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        /// <summary>
        /// Метод сортирует массив по алгоритму быстрой сортировки
        /// </summary>
        /// <param name="arr">Массивв</param>
        /// <param name="left">Начальный индекс массива</param>
        /// <param name="right">Последний индекс массива</param>
        /// <returns>Индекс элемента массива</returns>
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    Swap(ref arr[left], ref arr[right]);
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
