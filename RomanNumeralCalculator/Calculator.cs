using System.Linq;

namespace RomanNumeralCalculator
{
    internal class Calculator : ICalculator
    {
        public string Convert(int arabic)
        {
            if (arabic == 0) return "";

            foreach (var (key, value) in RomanNumeralLookup.Numerals.OrderByDescending(i => i.Key))
            {
                if (arabic >= key) return value + Convert(arabic - key);
            }

            return RomanNumeralLookup.Numerals[arabic];
        }
    }
}
