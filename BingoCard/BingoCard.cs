using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoCard
{
    public class BingoCard
    {
        public static string[] GetCard()
        {
            var set = new HashSet<string>();
            var random = new Random();
            while (set.Count < 24)
            {
                set.Add(random.Next(1000).ToString());
            }
            return set.ToArray();
        }
    }

}
