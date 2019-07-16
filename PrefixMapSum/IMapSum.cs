using System;
using System.Collections.Generic;
using System.Text;

namespace PrefixMapSum
{
    public interface IMapSum
    {
        IDictionary<string, int> Map { get; set; }

        void Insert(string key, int value);

        int Sum(string prefix);
    }
}
