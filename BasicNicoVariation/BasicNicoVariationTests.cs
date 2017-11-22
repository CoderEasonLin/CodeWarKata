using NUnit.Framework;

namespace BasicNicoVariation
{
    [TestFixture]
    public class BasicNicoVariationTests
    {
        [TestCase("", "", "")]
        [TestCase("abc", "abc", "abc")]
        [TestCase("abc", "cba", "cba")]
        public void BasicNicoVariationTest(string key, string message, string expected)
        {
            Assert.AreEqual(expected, BasicNico.Encrypt(key, message));
        }
    }
}