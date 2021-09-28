using System;
using FizzBuzz.Factories;

namespace FizzBuzz
{
    class Program
    {
        private static readonly IFizzBuzzFactory FizzBuzzFactory = new FizzBuzzFactory();
        private static IFizzBuzz _fizzBuzzer;

        private static void Main(string[] args)
        {
            _fizzBuzzer = FizzBuzzFactory.Create();
            Console.WriteLine(_fizzBuzzer.Calculate(3));
            Console.WriteLine(_fizzBuzzer.Calculate(5));
            Console.WriteLine(_fizzBuzzer.Calculate(15));
        }
    }
}
