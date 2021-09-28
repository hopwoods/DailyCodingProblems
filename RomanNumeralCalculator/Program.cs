using System;
using RomanNumeralCalculator.Factories;

namespace RomanNumeralCalculator
{
    internal class Program
    {
        private static ICalculatorFactory _factory;

        private static void Main(string[] args)
        {
            _factory = new CalculatorFactory();
            var romanNumeralCalculator = _factory.Create();

            Console.WriteLine(romanNumeralCalculator.Convert(550));

        }
    }
}
