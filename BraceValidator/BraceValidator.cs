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
        int length;
        do
        {
            length = input.Length;
            Braces.ForEach(brace => input = input.Replace(brace, ""));
        } while (length != input.Length);

        return length == 0;
    }
}
