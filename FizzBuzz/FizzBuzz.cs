﻿using System.Collections.Generic;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        #region default translations
        internal static List<Translation> DefaultTranslations
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

        internal static Translation DivisableByThreeTranslation
        { get { return new Translation((x) => x % 3 == 0, "Fizz"); } }

        internal static Translation DivisableByFiveTranslation
        { get { return new Translation((x) => x % 5 == 0, "Buzz"); } }

        internal static Translation DivisableByThreeAndFiveTranslation
        { get { return new Translation((x) =>(x % 3 == 0) && (x % 5 == 0), "FizzBuzz"); } }
        #endregion

        internal static string Print(int input, List<Translation> translations) { return Print(input, translations.ToArray()); }
        internal static string Print(int input, params Translation[] translations)
        {
            foreach (var translation in translations) { if (translation.IsTriggeredBy(input)) return translation.Output; }
            
            return input.ToString();
        }

        internal static string Print(int from, int untilAndIncluding, List<Translation> translations) { return Print(from, untilAndIncluding, translations.ToArray()); }
        internal static string Print(int from, int untilAndIncluding, params Translation[] translations)
        {
            var result = string.Empty;

            for (int i = from; i < untilAndIncluding + 1; i++) { result += Print(i, translations) + "\n"; }

            return result;
        }
    }
}