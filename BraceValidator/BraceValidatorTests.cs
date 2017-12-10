using NUnit.Framework;

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

    [TestCase("[}")]
    public void IncorrectTests(string input)
    {
        Assert.IsFalse(BraceValidator.Validate(input));
    }
}