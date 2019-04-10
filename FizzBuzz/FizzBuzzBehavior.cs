using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzBehavior
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void ValidatePrint(int input, string expectedOutput)
        {
            Assert.Equal(expectedOutput, FizzBuzz.Print(input, FizzBuzz.DefaultTranslations));
        }

        [Fact]
        public void ValidatePrintRange()
        {
            Assert.Equal(ExpectedOutputOfRange_1_to_30, FizzBuzz.Print(1, 30, FizzBuzz.DefaultTranslations));
        }

        [Fact]
        public void ValidateCustomTranslations()
        {
            var translations = FizzBuzz.DefaultTranslations;
            translations.Add(new Translation((x)=> x.ToString().Contains('3'), "Fizz"));

            Assert.Equal("Fizz", FizzBuzz.Print(13, translations));
        }

        #region private parts

        private static string ExpectedOutputOfRange_1_to_30
        {
            get
            {
                return
                     "1" + "\n" +
                     "2" + "\n" +
                  "Fizz" + "\n" +
                     "4" + "\n" +
                  "Buzz" + "\n" +
                  "Fizz" + "\n" +
                     "7" + "\n" +
                     "8" + "\n" +
                  "Fizz" + "\n" +
                  "Buzz" + "\n" +
                    "11" + "\n" +
                  "Fizz" + "\n" +
                    "13" + "\n" +
                    "14" + "\n" +
              "FizzBuzz" + "\n" +
                    "16" + "\n" +
                    "17" + "\n" +
                  "Fizz" + "\n" +
                    "19" + "\n" +
                  "Buzz" + "\n" +
                  "Fizz" + "\n" +
                    "22" + "\n" +
                    "23" + "\n" +
                  "Fizz" + "\n" +
                  "Buzz" + "\n" +
                    "26" + "\n" +
                  "Fizz" + "\n" +
                    "28" + "\n" +
                    "29" + "\n" +
              "FizzBuzz" + "\n";
            }
        }
        #endregion
    }
}