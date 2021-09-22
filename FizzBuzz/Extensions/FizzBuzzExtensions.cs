namespace FizzBuzz.Extensions
{
    static class FizzBuzzExtensions
    {
        internal static bool IsMultipleOf(this int input, int divisor)
        {
            return input % divisor == 0;
        }
    }
}
