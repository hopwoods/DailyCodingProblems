using System;

namespace Rand5
{
    internal class RandomNumberGenerator : IRandomNumberGenerator
    {
        public static int Rand7()
        {
            return new Random().Next(1, 8);
        }

        public int Rand5()
        {
            var x = Rand7();
            while (x > 5)
            {
                x = Rand7();
            }

            return x;
        }
    }
}
