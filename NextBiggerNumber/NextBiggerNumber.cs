using System;
using System.Linq;

namespace NextBiggerNumber
{
    public class NextBiggerNumber
    {
        public static int By(int number)
        {
            var digits = number.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();
            for (int i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i - 1] < digits[i])
                {
                    Swap(digits, i - 1, i);
                    Array.Sort(digits, i, digits.Length - i);
                    break;
                }
            }
            var result = Convert.ToInt32(string.Concat(digits));
            return number == result ? -1 : result;
        }

        private static void Swap(int[] digits, int index1, int index2)
        {
            int temp = digits[index1];
            digits[index1] = digits[index2];
            digits[index2] = temp;
        }
    }
}
