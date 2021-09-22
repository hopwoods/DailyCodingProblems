namespace FizzBuzz
{
    public class FizzBuzzFactory : IFizzBuzzFactory
    {
        public FizzBuzz Create()
        {
            return new FizzBuzz();
        }
    }
}
