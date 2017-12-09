using System.Collections.Generic;

public class MorseCodeDecoder
{
    public static string Decode(string input)
    {
        var morseCodeMapping = new Dictionary<string, string>
        {
            {".-", "A"},
            {"-...", "B"}
        };
        return morseCodeMapping[input];
    }
}