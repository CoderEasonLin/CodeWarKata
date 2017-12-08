using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoCard
{
    public class BingoCard
    {
        public static string[] GetCard()
        {
            return GenerateNumbers(startWith: "B", count: 5)
                .Concat(GenerateNumbers(startWith: "I", count: 5)
                .Concat(GenerateNumbers(startWith: "N", count: 4)
                .Concat(GenerateNumbers(startWith: "G", count: 5)
                .Concat(GenerateNumbers(startWith: "O", count: 5)
                )))).ToArray();
        }

        private static HashSet<string> GenerateNumbers(string startWith, int count)
        {
            var random = new Random();
            var hashSet = new HashSet<string>();
            while (hashSet.Count < count)
            {
                hashSet.Add($"{startWith}{random.Next(1000)}");
            }
            return hashSet;
        }
    }

}
