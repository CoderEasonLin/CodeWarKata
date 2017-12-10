﻿using NUnit.Framework;

[TestFixture]
public class BraceValidatorTests
{
    [TestCase("()")]
    [TestCase("[]")]
    [TestCase("{}")]
    [TestCase("{[]}")]
    [TestCase("{[()]}")]
    [TestCase("{[()]}{[(){[]()}]}")]
    public void CorrectTests(string input)
    {
        Assert.IsTrue(BraceValidator.Validate(input));
    }
}