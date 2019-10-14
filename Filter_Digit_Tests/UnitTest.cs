using Filter_Digit;
using NUnit.Framework;

namespace Filter_Digit_Tests
{
    public class UnitTest
    {

        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, new int[] { 7, 7, 70, 17 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -69, 70, 15, 17 }, 6, new int[] { 6, 68, -69 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -69, 70, 15, 17 }, 9, new int[] { -69 })]
        public void UTestFilterDigit(int[] arr, int digit, int[] expected)
        {
            int[] result = Program.FilterDigit(arr, digit);
            Assert.AreEqual(expected, result);
        }
    }
}