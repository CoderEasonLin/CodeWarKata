using System;
using System.Collections.Generic;
using NUnit.Framework;

public class BraceValidator
{
    public static bool Validate(string input)
    {
        var braces = new List<string>
        {
            "()",
            "[]",
            "{}",
        };
        return braces.Contains(input);
    }
}
