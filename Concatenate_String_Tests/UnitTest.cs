using Concatenate_String;
using NUnit.Framework;

namespace Concatenate_String_Tests
{
    public class UnitTest
    {

        [TestCase("AsdfeAd", "Assqaasssqs", "AsdfeAdqaaq")]
        public void UTestStringConcatenation(string firstStr, string secondStr, string expected)
        {
            string result = Program.StringConcatenation(firstStr, secondStr);
            Assert.AreEqual(expected, result);
        }
    }
}