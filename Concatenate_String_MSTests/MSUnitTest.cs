using Concatenate_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Concatenate_String_MSTests
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        public void MSUTestStringConcatenation()
        {
            string firstStr = "AsdfeAd";
            string secondStr = "Assqaasssqs";
            string expectedResult = "AsdfeAdqaaq";
            string result = Program.StringConcatenation(firstStr, secondStr);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
