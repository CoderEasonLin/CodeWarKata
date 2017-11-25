using NUnit.Framework;

namespace NextBiggerNumber
{
    [TestFixture]
    public class NextBiggerNumberTests
    {
        [TestCase(0, -1)]
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(20170, 20701)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(111, -1)]
        [TestCase(531, -1)]
        [TestCase(12321, 13122)]
        [TestCase(1232123212321, 1232123213122)]
        [TestCase(59884848459853, 59884848483559)]
        public void NextBiggerNumberTest(long input, long expected)
        {
            Assert.AreEqual(expected, NextBiggerNumber.By(input));
        }
    }
}