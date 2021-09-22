using FizzBuzz.Extensions;

namespace FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        private const string FizzBuzzString = "FizzBuzz";
        private const string FizzString = "Fizz";
        private const string BuzzString = "Buzz";

        #region Implementation of IFizzBuzz

        /// <inheritdoc />
        public string Calculate(int input)
        {
            if (input.IsMultipleOf(3) && input.IsMultipleOf(5)) return FizzBuzzString;
            if (input.IsMultipleOf(3)) return FizzString;
            if (input.IsMultipleOf(5)) return BuzzString;

            return input.ToString();
        }


        #endregion
    }
}
