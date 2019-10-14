using Find_Max_Element;
using NUnit.Framework;

namespace Find_Max_Element_Tests
{
    public class UnitTest
    {

        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1 }, 1)]
        [TestCase(new int[] { 0, -1, 11, 21, 1, 2, 8, 65, 34, 21, 765, -12, 566, 7878, -199, 0, 34, 65, 87, 12, 34 }, 7878)]
        public void UTestGetMaxElementFromArray(int[] array, int expected)
        {
            int result = Program.GetMaxElementFromArray(array);
            Assert.AreEqual(expected, result);
        }
    }
}