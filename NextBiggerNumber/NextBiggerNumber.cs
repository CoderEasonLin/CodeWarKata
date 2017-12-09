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

            var NotExistedIndex = -1;
            if (swapIndex == NotExistedIndex)
                return -1;

            var biggerIndex = FindIndexBeforeAndBiggerThan(swapIndex);
            Swap(swapIndex, biggerIndex);
            SortBefore(swapIndex);

            return Convert.ToInt64(string.Concat(_digits));
        }

        private static void SortBefore(int index)
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

        private static int FindIndexBeforeAndBiggerThan(int index)
        {
            var result = -1;
            var nextBiggerNumber = 10;
            var compareNumber = _digits[index];
            for (var i = index + 1; i < _digits.Length; i++)
            {
                if (_digits[i] > compareNumber && _digits[i] < nextBiggerNumber)
                {
                    nextBiggerNumber = _digits[i];
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
