using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoCard
{
    public class BingoCard
    {
        public static string[] GetCard()
        {
            return GenerateNumbers(startWith: "B", count: 5, min: 1, max: 15)
                .Concat(GenerateNumbers(startWith: "I", count: 5, min: 16, max: 30)
                .Concat(GenerateNumbers(startWith: "N", count: 4, min: 31, max: 45)
                .Concat(GenerateNumbers(startWith: "G", count: 5, min: 46, max: 60)
                .Concat(GenerateNumbers(startWith: "O", count: 5, min: 61, max: 75)
                )))).ToArray();
        }

        private static HashSet<string> GenerateNumbers(string startWith, int count, int min, int max)
        {
            var random = new Random();
            var numbers = new HashSet<string>();
            while (numbers.Count < count)
                numbers.Add($"{startWith}{random.Next(min, max)}");
            return numbers;
        }
    }
}
