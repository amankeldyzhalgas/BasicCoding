using Find_Bigger_Number;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Find_Bigger_Number_MSTest
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        public void MSTestFindNextBiggerNumber_1234321()
        {
            int number = 1234321;
            int expectedResult = 1241233;
            int result = Program.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MSTestFindNextBiggerNumber_1234126()
        {
            int number = 1234126;
            int expectedResult = 1234162;
            int result = Program.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MSTestFindNextBiggerNumber_3456432()
        {
            int number = 3456432;
            int expectedResult = 3462345;
            int result = Program.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
