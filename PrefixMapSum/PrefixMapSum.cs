using System;
using System.Collections.Generic;
using System.Linq;

namespace PrefixMapSum
{
    public class PrefixMapSum : IMapSum
    {
        public IDictionary<string, int> Map { get; set; }

        public PrefixMapSum()
        {
            Map = new Dictionary<string, int>();
        }

        public void Insert(string key, int value)
        {
            var keyExists = Map.ContainsKey(key);

            if (!keyExists)
            {
                Map.Add(new KeyValuePair<string, int>(key, value));
            }

            Map[key] = value;
        }

        public int Sum(string prefix)
        {
            var keysWithPrefix = Map.Keys.Where(currentKey => currentKey.Contains(prefix)).ToList();
            var sum = 0;

            if (!keysWithPrefix.Any()) return sum;

            foreach (var key in keysWithPrefix)
            {
                sum += Map[key];
            }

            return sum;
        }
    }
}