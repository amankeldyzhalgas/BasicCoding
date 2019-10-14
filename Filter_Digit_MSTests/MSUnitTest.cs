using Filter_Digit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Filter_Digit_MSTests
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        public void MSTestFilterDigit()
        {
            int[] arr = new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int digit = 7;
            int[] expectedResult = new int[] { 7, 7, 70, 17 };
            int[] result = Program.FilterDigit(arr, digit);
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
