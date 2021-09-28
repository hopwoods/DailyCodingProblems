using NUnit.Framework;
using RomanNumeralCalculator.Factories;

namespace RomanNumeralCalculator.Tests
{
    [TestFixture]
    public class RomanNumeralCalculatorShould
    {
        private ICalculatorFactory _factory;

        [SetUp]
        public void Setup()
        {
            _factory = new CalculatorFactory();
        }

        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(12, "XII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(40, "XL")]
        [TestCase(42, "XLII")]
        [TestCase(50, "L")]
        [TestCase(60, "LX")]
        [TestCase(70, "LXX")]
        [TestCase(80, "LXXX")]
        [TestCase(90, "XC")]
        [TestCase(99, "XCIX")]
        [TestCase(100, "C")]
        [TestCase(149, "CXLIX")]
        [TestCase(200, "CC")]
        [TestCase(300, "CCC")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(600, "DC")]
        [TestCase(700, "DCC")]
        [TestCase(800, "DCCC")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        [TestCase(846, "DCCCXLVI")]
        [TestCase(1999, "MCMXCIX")]
        [TestCase(2008, "MMVIII")]
        public void ConvertIntoRomanWhenGivenArabic(int input, string expectedResult)
        {
            var romanNumeralCalculator = _factory.Create();
        
            var result = romanNumeralCalculator.Convert(input);
        
            Assert.AreEqual(expectedResult, result);
        }
    }
    }
