using System;
using System.Globalization;
using System.Linq;

namespace NextBiggerNumber
{
    public class NextBiggerNumber
    {
        private static int[] _digits;

        public static long By(long number)
        {
            ToDigitsArray(number);

            var swapIndex = FindSwapIndex();

            var NotExisted = -1;
            if (swapIndex == NotExisted)
                return -1;

            Swap(swapIndex, FindBiggerDigitIndexAfter(swapIndex));
            SortAfter(swapIndex);

            return Convert.ToInt64(string.Concat(_digits));
        }

        private static void SortAfter(int index)
        {
            var startIndex = index + 1;
            Array.Sort(_digits, startIndex, _digits.Length - startIndex);
        }

        private static void Swap(int index1, int index2)
        {
            int temp = _digits[index1];
            _digits[index1] = _digits[index2];
            _digits[index2] = temp;
        }

        private static int FindBiggerDigitIndexAfter(int index)
        {
            var seed = _digits[index];

            var result = -1;
            var biggerDigit = 10;
            for (var i = index + 1; i < _digits.Length; i++)
            {
                if (_digits[i] > seed && _digits[i] < biggerDigit)
                {
                    biggerDigit = _digits[i];
                    result = i;
                }
            }
            return result;
        }

        private static int FindSwapIndex()
        {
            for (var i = _digits.Length - 1; i >= 1; i--)
            {
                if (_digits[i - 1] < _digits[i])
                    return i - 1;
            }
            return -1;
        }

        private static void ToDigitsArray(long number)
        {
            _digits = number.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();
        }
    }
}
