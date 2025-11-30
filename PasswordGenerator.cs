// Файл: PasswordGenerator.cs
using System;
using System.Linq;
using System.Text;

namespace passwords_project
{
    public class PasswordGenerator
    {
        private static readonly Random Rnd = new Random();

        private const string Lower = "abcdefghijklmnopqrstuvwxyz";
        private const string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";
        private const string Symbols = "!@#$%^&*()-_=+[{]}\\|;:',<.>/?`~";
        private const string RussianLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private const string RussianUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";


        public string GeneratePassword(int length, bool useUpper, bool useDigits, bool useSymbols, bool useRussian)
        {
            if (length < 1) return string.Empty;

            var allCharsBuilder = new StringBuilder(Lower);
            var requiredChars = new System.Collections.Generic.List<char>();

            requiredChars.Add(Lower[Rnd.Next(Lower.Length)]);

            if (useUpper)
            {
                allCharsBuilder.Append(Upper);
                requiredChars.Add(Upper[Rnd.Next(Upper.Length)]);
            }
            if (useDigits)
            {
                allCharsBuilder.Append(Digits);
                requiredChars.Add(Digits[Rnd.Next(Digits.Length)]);
            }
            if (useSymbols)
            {
                allCharsBuilder.Append(Symbols);
                requiredChars.Add(Symbols[Rnd.Next(Symbols.Length)]);
            }
            if (useRussian)
            {
                allCharsBuilder.Append(RussianLower).Append(RussianUpper);
                string russianChars = RussianLower + RussianUpper;
                requiredChars.Add(russianChars[Rnd.Next(russianChars.Length)]);
            }

            string allChars = allCharsBuilder.ToString();

            if (length < requiredChars.Count)
            {
                requiredChars = requiredChars.Take(length).ToList();
            }

            int remainingLength = length - requiredChars.Count;
            for (int i = 0; i < remainingLength; i++)
            {
                requiredChars.Add(allChars[Rnd.Next(allChars.Length)]);
            }

            return new string(requiredChars.OrderBy(x => Rnd.Next()).ToArray());
        }
    }
}