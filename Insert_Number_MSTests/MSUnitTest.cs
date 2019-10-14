using Insert_Number;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Insert_Number_MSTests
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        public void MSTest_151500_15()
        {
            int firstNum = 15, secondNum = 15, firstIndex = 0, secondIndex = 0;
            int expectedResult = 15;
            int result = Program.InsertNumber(firstNum, secondNum, firstIndex, secondIndex);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MSTest_81500_9()
        {
            int firstNum = 8, secondNum = 15, firstIndex = 0, secondIndex = 0;
            int expectedResult = 9;
            int result = Program.InsertNumber(firstNum, secondNum, firstIndex, secondIndex);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MSTest_81538_120()
        {
            int firstNum = 8, secondNum = 15, firstIndex = 3, secondIndex = 8;
            int expectedResult = 120;
            int result = Program.InsertNumber(firstNum, secondNum, firstIndex, secondIndex);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
