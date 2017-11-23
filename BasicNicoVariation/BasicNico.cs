using System.Linq;

namespace BasicNicoVariation
{
    public class BasicNico
    {
        public static string Encrypt(string key, string message)
        {
            var sortedKey = string.Concat(key.OrderBy(x => x));
            var encryptedIndex = key.ToDictionary(c => key.IndexOf(c), c => sortedKey.IndexOf(c));

            var result = "";
            for (int i = 0; i < message.Length; i++)
            {
                var indexOfKey = i % key.Length;
                var charPos = i - indexOfKey + encryptedIndex[indexOfKey];
                result += message[charPos];
            }

            return result;
        }
    }
}