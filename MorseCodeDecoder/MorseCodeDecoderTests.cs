using NUnit.Framework;

[TestFixture]
public class MorseCodeDecoderTests
{
    [TestCase(".-", "A")]
    public void CorrectTest(string input, string expected)
    {
        Assert.AreEqual(expected, MorseCodeDecoder.Decode(input));
    }
}