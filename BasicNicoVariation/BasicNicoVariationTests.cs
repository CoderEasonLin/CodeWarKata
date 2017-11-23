using NUnit.Framework;

namespace BasicNicoVariation
{
    [TestFixture]
    public class BasicNicoVariationTests
    {
        [TestCase("", "", "")]
        [TestCase("abc", "abc", "abc")]
        [TestCase("abc", "cba", "cba")]
        [TestCase("cba", "cba", "abc")]
        [TestCase("key", "key", "eky")]
        [TestCase("abc", "abcd", "abcd  ")]
        public void BasicNicoVariationTest(string key, string message, string expected)
        {
            var basicNico = new BasicNico(key);
            Assert.AreEqual(expected, basicNico.Encrypt(message));
        }
    }
}