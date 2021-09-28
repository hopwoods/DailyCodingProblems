namespace RomanNumeralCalculator.Factories
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator Create()
        {
            return new Calculator();
        }
    }
}
