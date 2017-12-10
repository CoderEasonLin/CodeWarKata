using NUnit.Framework;

[TestFixture]
public class BraceValidatorTests
{
    [TestCase("()")]
    public void CorrectTests(string input)
    {
        Assert.IsTrue(BraceValidator.Validate(input));
    }
}