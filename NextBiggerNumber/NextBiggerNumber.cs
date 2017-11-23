using System;
using System.Linq;

namespace NextBiggerNumber
{
    public class NextBiggerNumber
    {
        public static int By(int input)
        {
            var result = Convert.ToInt32(string.Concat(input.ToString().OrderByDescending(x => x)));
            return input == result ? -1 : result;
        }
    }
}
