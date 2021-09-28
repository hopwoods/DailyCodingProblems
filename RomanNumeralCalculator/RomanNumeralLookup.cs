using System.Collections.Generic;

namespace RomanNumeralCalculator
{
    internal static class RomanNumeralLookup
    {
        internal static readonly Dictionary<int, string> Numerals = new Dictionary<int, string>
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"}
        };
    }
}