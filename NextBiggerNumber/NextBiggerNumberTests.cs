using NUnit.Framework;

namespace NextBiggerNumber
{
    [TestFixture]
    public class NextBiggerNumberTests
    {
        [TestCase(0, 0)]
        public void NextBiggerNumberTest(int input, int expected)
        {
            Assert.AreEqual(expected, NextBiggerNumber.By(input));
        }
    }
}