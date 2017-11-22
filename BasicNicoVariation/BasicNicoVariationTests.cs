using NUnit.Framework;

namespace BasicNicoVariation
{
    [TestFixture]
    public class BasicNicoVariationTests
    {
        [TestCase("", "", "")]
        public void BasicNicoVariationTest(string expected, string key, string message)
        {
            Assert.AreEqual(expected, BasicNico.Encrypt(key, message));
        }
    }
}