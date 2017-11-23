using System.Collections.Generic;
using System.Linq;

namespace BasicNicoVariation
{
    public class BasicNico
    {
        private Dictionary<int, int> _indexMapping;
        private string _key;

        public BasicNico(string key)
        {
            _key = key;
            var sortedKey = string.Concat(key.OrderBy(x => x));
            _indexMapping = key.ToDictionary(c => key.IndexOf(c), c => sortedKey.IndexOf(c));
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

        private int GetEncryptedCharIndex(int messageIndex)
        {
            return messageIndex - messageIndex % _key.Length + _indexMapping[messageIndex % _key.Length];
        }
    }
}