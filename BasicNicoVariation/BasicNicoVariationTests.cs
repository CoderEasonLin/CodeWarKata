using NUnit.Framework;

namespace BasicNicoVariation
{
    [TestFixture]
    public class BasicNicoVariationTests
    {
        [TestCase("", "", "")]
        [TestCase("abc", "abc", "abc")]
        public void BasicNicoVariationTest(string expected, string key, string message)
        {
            Assert.AreEqual(expected, BasicNico.Encrypt(key, message));
        }
    }
}