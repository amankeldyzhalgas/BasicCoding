using Find_Max_Element;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Find_Max_Element_MSTests
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        public void MSTestGetMaxElementFromArray()
        {
            int[] array = new int[] { 0, -1, 11, 21, 1, 2, 8, 65, 34, 21, 765, -12, 566, 7878, -199, 0, 34, 65, 87, 12, 34 };
            int expectedResult = 7878;
            int result = Program.GetMaxElementFromArray(array);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
