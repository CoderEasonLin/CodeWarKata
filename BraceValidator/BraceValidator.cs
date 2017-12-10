using System.Collections.Generic;

public class BraceValidator
{
    private static readonly List<string> Braces = new List<string>
    {
        "()",
        "[]",
        "{}",
    };

    public static bool Validate(string input)
    {
        var length = -1;
        while (length != input.Length)
        {
            length = input.Length;
            Braces.ForEach(brace => input = input.Replace(brace, ""));
        }
        return length == 0;
    }
}
