using System.Linq;

namespace BasicNicoVariation
{
    public class BasicNico
    {
        private static string _key;
        private static IOrderedEnumerable<char> _sortedKey;

        public BasicNico(string key)
        {
            _key = key;
            _sortedKey = key.ToCharArray().OrderBy(x => x);
        }

        public string Encrypt(string message)
        {
            var result = "";
            for (int i = 0; i < message.Length; i++)
            {
                var charPos = GetEncryptedCharIndex(i);
                result += message[charPos];
            }

            return result;
        }

        private static int GetEncryptedCharIndex(int i)
        {
            var processedLength = i - (i % _sortedKey.Count());
            return _key.IndexOf(_sortedKey.ElementAt(i % _sortedKey.Count())) + processedLength;
        }
    }
}