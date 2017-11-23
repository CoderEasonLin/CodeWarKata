﻿using NUnit.Framework;

namespace NextBiggerNumber
{
    [TestFixture]
    public class NextBiggerNumberTests
    {
        [TestCase(0, -1)]
        [TestCase(12, 21)]
        public void NextBiggerNumberTest(int input, int expected)
        {
            Assert.AreEqual(expected, NextBiggerNumber.By(input));
        }
    }
}