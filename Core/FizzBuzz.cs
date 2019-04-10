using System.Collections.Generic;

namespace Core
{
    public static class FizzBuzz
    {
        #region default translations
        public static List<Translation> DefaultTranslations
        { get
            {
                return new List<Translation>()
                {
                    FizzBuzz.DivisableByThreeAndFiveTranslation,
                    FizzBuzz.DivisableByThreeTranslation,
                    FizzBuzz.DivisableByFiveTranslation
                };
            }
        }

        public static Translation DivisableByThreeTranslation
        { get { return new Translation((x) => x % 3 == 0, "Fizz"); } }

        public static Translation DivisableByFiveTranslation
        { get { return new Translation((x) => x % 5 == 0, "Buzz"); } }

        public static Translation DivisableByThreeAndFiveTranslation
        { get { return new Translation((x) =>(x % 3 == 0) && (x % 5 == 0), "FizzBuzz"); } }
        #endregion

        public static string Print(int input, List<Translation> translations) { return Print(input, translations.ToArray()); }
        public static string Print(int input, params Translation[] translations)
        {
            foreach (var translation in translations) { if (translation.IsTriggeredBy(input)) return translation.Output; }
            
            return input.ToString();
        }

        public static string Print(int from, int untilAndIncluding, List<Translation> translations) { return Print(from, untilAndIncluding, translations.ToArray()); }
        public static string Print(int from, int untilAndIncluding, params Translation[] translations)
        {
            var result = string.Empty;

            for (int i = from; i < untilAndIncluding + 1; i++) { result += Print(i, translations) + "\n"; }

            return result;
        }
    }
}