using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using NUnit.Framework.Constraints;

namespace BingoCard
{
    public class BingoCard
    {
        public static string[] GetCard()
        {
            var BNumbers = NumberGenerator.Generate(min: 1, max: 15, count: 5);
            var INumbers = NumberGenerator.Generate(min: 16, max: 30, count: 5);
            var NNumbers = NumberGenerator.Generate(min: 31, max: 45, count: 4);
            var GNumbers = NumberGenerator.Generate(min: 46, max: 60, count: 5);
            var ONumbers = NumberGenerator.Generate(min: 61, max: 75, count: 5);
            return BNumbers.Select(x => "B" + x.ToString()).Concat(
                   INumbers.Select(x => "I" + x.ToString()).Concat(
                   NNumbers.Select(x => "N" + x.ToString()).Concat(
                   GNumbers.Select(x => "G" + x.ToString()).Concat(
                   ONumbers.Select(x => "O" + x.ToString()))))).ToArray();
        }
    }

    public class NumberGenerator
    {
        public static List<int> Generate(int min, int max, int count)
        {
            var result = new List<int>();
            var random = new Random();
            while(result.Count < count)
            {
                var number = random.Next(min, max);
                if (!result.Contains(number))
                    result.Add(number);
            }
            return result;
        }
    }
}
