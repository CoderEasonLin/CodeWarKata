using NUnit.Framework;

namespace BasicNicoVariation
{
    [TestFixture]
    public class BasicNicoVariationTests
    {
        [TestCase("abc", "abc", "abc")]
        [TestCase("abc", "cba", "cba")]
        [TestCase("cba", "cba", "abc")]
        [TestCase("key", "key", "eky")]
        [TestCase("abc", "abcdef", "abcdef")]
        [TestCase("abc", "abcd", "abcd  ")]
        [TestCase("crazy", "secretinformation", "cseerntiofarmit on  ")]
        public void BasicNicoVariationTest(string key, string message, string expected)
        {
            Assert.AreEqual(expected, BasicNico.Encrypt(key, message));
        }
    }
}