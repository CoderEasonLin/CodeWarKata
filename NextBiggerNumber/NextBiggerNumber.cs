using System;
using System.Linq;

namespace NextBiggerNumber
{
    public class NextBiggerNumber
    {
        public static long By(long number)
        {
            var digits = number.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();
            for (int i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i - 1] < digits[i])
                {
                    var nextBiggerDigitIndex = NextBiggerDigitIndex(digits, i, digits[i-1]);
                    Swap(digits, i - 1, nextBiggerDigitIndex == -1 ? i : nextBiggerDigitIndex);
                    Array.Sort(digits, i, digits.Length - i);
                    break;
                }
            }
            var result = Convert.ToInt64(string.Concat(digits));
            return number == result ? -1 : result;
        }

        private static int NextBiggerDigitIndex(int[] digits, int startFrom, int value)
        {
            
            var tempDigits = digits.ToList().GetRange(startFrom, digits.Length).OrderByDescending(i => i).ToList();
            var index = tempDigits.IndexOf(value);
            return digits.


            var result = -1;
            var biggerDigit = 10;
            for (int i = startFrom; i < digits.Length; i++)
            {
                if (digits[i] > value && digits[i] < biggerDigit)
                {
                    result = i;
                    biggerDigit = digits[i];
                }
            }
            return result;
        }

        private static void Swap(int[] digits, int index1, int index2)
        {
            int temp = digits[index1];
            digits[index1] = digits[index2];
            digits[index2] = temp;
        }
    }
}
