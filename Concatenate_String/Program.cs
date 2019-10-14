using System.Linq;

namespace Concatenate_String
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод возвращает конкатенацию двух строк, содержащих только символы 
        /// латинского алфавита, исключая повторяющиеся символы.
        /// </summary>
        /// <param name="firstString">Первая строка</param>
        /// <param name="secondString">Вторая строка</param>
        /// <returns>Строка на выходе</returns>
        public static string StringConcatenation(string firstString, string secondString)
        {
            var str = firstString;
            for (int i = 0; i < secondString.Length; i++)
            {
                if (!firstString.Contains(secondString[i]))
                    str += secondString[i];
            }
            return str;
        }
    }
}
