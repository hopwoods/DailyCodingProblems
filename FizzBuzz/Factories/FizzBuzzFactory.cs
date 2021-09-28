namespace FizzBuzz.Factories
{
    public class FizzBuzzFactory : IFizzBuzzFactory
    {
        public FizzBuzz Create()
        {
            return new FizzBuzz();
        }
    }
}
