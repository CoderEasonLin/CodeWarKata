using System;
using System.Linq;

public class MorseCodeDecoder
{
    public static string Decode(string input)
    {
        var words = input.Trim().Split(new[] {"   "}, StringSplitOptions.None);
        return string.Join(" ", words.Select(Translate));
    }

    private static string Translate(string word)
    {
        return string.Join("", word.Split(' ').Select(MorseCode.Get));
    }
}