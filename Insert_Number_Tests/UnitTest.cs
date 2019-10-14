using Insert_Number;
using NUnit.Framework;

namespace Insert_Number_Tests
{
    public class UnitTest
    {
        [TestCase(15, 15, 0, 0, 15)]
        [TestCase(8, 15, 0, 0, 9)]
        [TestCase(8, 15, 3, 8, 120)]
        public void UTestInsertNumber(int nSource, int nIn, int i, int j, int expected)
        {
            int result = Program.InsertNumber(nSource, nIn, i, j);
            NUnit.Framework.Assert.AreEqual(expected, result);
        }
    }
}