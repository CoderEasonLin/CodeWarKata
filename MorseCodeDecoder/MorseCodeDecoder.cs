using System;
using System.Collections.Generic;
using System.Linq;

public class MorseCodeDecoder
{
    private static Dictionary<string, string> _morseCodeMapping;

    public static string Decode(string input)
    {
        Console.WriteLine(input);
        _morseCodeMapping = new Dictionary<string, string>
        {
            {".- ", "A"},
            {"-... ", "B"},
            {"-.-. ", "C"},
            {"-.. ", "D"},
            {". ", "E"},
            {"..-. ", "F"},
            {"--. ", "G"},
            {".... ", "H"},
            {".. ", "I"},
            {".--- ", "J"},
            {"-.- ", "K"},
            {".-.. ", "L"},
            {"-- ", "M"},
            {"-. ", "N"},
            {"--- ", "O"},
            {".--. ", "P"},
            {"--.- ", "Q"},
            {".-. ", "R"},
            {"... ", "S"},
            {"- ", "T"},
            {"..- ", "U"},
            {"...- ", "V"},
            {".-- ", "W"},
            {"-..- ", "X"},
            {"-.-- ", "Y"},
            {"--.. ", "Z"},
            {".---- ", "1"},
            {"..--- ", "2"},
            {"...-- ", "3"},
            {"....- ", "4"},
            {"..... ", "5"},
            {"-.... ", "6"},
            {"--... ", "7"},
            {"---.. ", "8"},
            {"----. ", "9"},
            {"----- ", "0"},
            {"...---... ", "SOS"},
            {"  ", " "},
        };
        
        input = $"{input.Trim()} ";
        foreach (var mapping in _morseCodeMapping.OrderByDescending(pair => pair.Key))
        {
            input = input.Replace(mapping.Key, mapping.Value);
        }
        return input;
    }
}