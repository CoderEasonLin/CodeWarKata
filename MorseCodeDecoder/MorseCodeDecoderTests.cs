using NUnit.Framework;

[TestFixture]
public class MorseCodeDecoderTests
{
    [TestCase(".-", "A")]
    [TestCase("-...", "B")]
    [TestCase("-.-.", "C")]
    [TestCase(".- -... -.-.", "ABC")]
    [TestCase(".-   -...   -.-.", "A B C")]
    [TestCase(".... . -.--   .--- ..- -.. .", "HEY JUDE")]
    [TestCase("...---...", "SOS")]
    [TestCase(" . ", "E")]
    public void CorrectTest(string input, string expected)
    {
        Assert.AreEqual(expected, MorseCodeDecoder.Decode(input));
    }
}