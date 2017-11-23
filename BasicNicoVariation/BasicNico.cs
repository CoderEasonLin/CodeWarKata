using System.Linq;

namespace BasicNicoVariation
{
    public class BasicNico
    {
        public static string Encrypt(string key, string message)
        {
            var sortedKey = key.ToCharArray().OrderBy(x => x);
            var result = "";
            for (int i = 0; i < message.Length; i++)
            {
                var charPos = key.IndexOf(sortedKey.ElementAt(i % sortedKey.Count()));
                result += message[charPos];
            }

            return result;
        }
    }
}