using Find_Bigger_Number;
using NUnit.Framework;

namespace Find_Bigger_Number_Tests
{
    public class UnitTest
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(1234321, 1241233)]
        [TestCase(1234126, 1234162)]
        [TestCase(3456432, 3462345)]
        [TestCase(10, -1)]
        [TestCase(20, -1)]
        public void UTestFindNextBiggerNumber(int number, int expected)
        {
            int result = Program.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, result);
        }
    }
}