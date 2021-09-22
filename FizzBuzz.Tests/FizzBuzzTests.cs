using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        private IFizzBuzz _fizzBuzzer;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzer = new FizzBuzz();
        }

        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(7,"7")]
        public void InputIsReturned(int input, string expectedResult)
        {
            var result = _fizzBuzzer.Calculate(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(3,"Fizz")]
        [TestCase(6,"Fizz")]
        [TestCase(9,"Fizz")]
        public void WhenInputIsMultipleOfThreeReturnFizz(int input, string expectedResult)
        {
            var result = _fizzBuzzer.Calculate(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(5,"Buzz")]
        [TestCase(10,"Buzz")]
        [TestCase(25,"Buzz")]
        public void WhenInputIsMultipleOfFiveReturnBuzz(int input, string expectedResult)
        {
            var result = _fizzBuzzer.Calculate(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(15,"FizzBuzz")]
        public void WhenInputIsMultipleOfThreeAndFiveReturnFizzBuzz(int input, string expectedResult)
        {
            var result = _fizzBuzzer.Calculate(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }


    }
}