using System.Linq;

namespace BasicNicoVariation
{
    public class BasicNico
    {
        public static string Encrypt(string key, string message)
        {
            var sortedKey = string.Concat(key.OrderBy(x => x));
            var encryptedIndex = key.ToDictionary(c => sortedKey.IndexOf(c), c => key.IndexOf(c));

            if(message.Length % key.Length > 0)
                message = message.PadRight(message.Length + key.Length - message.Length % key.Length);

            var result = "";
            for (int i = 0; i < message.Length; i++)
            {
                var indexFromKeyLength = i % key.Length;
                var encryptedCharIndex = i - indexFromKeyLength + encryptedIndex[indexFromKeyLength];
                result += message[encryptedCharIndex];
            }

            return result;
        }
    }
}