using System.Linq;

namespace passwords_project
{
    public class PasswordValidator
    {
        private const string AllSymbols = "!@#$%^&*()-_=+[{]}\\|;:',<.>/?`~";

        public int Validate(string password)
        {
            if (string.IsNullOrEmpty(password)) return 0;

            int score = 0;
            int length = password.Length;
            int maxPossibleScore = 10;

            if (length > 24)
            {
                return 10;
            }

            if (length >= 8) score += 1;
            if (length >= 12) score += 2;
            if (length >= 16) score += 1;

            bool hasLower = password.Any(char.IsLower);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSymbol = password.Any(ch => AllSymbols.Contains(ch));
            bool hasCyrillicLower = password.Any(ch => (ch >= 'а' && ch <= 'я') || ch == 'ё');
            bool hasCyrillicUpper = password.Any(ch => (ch >= 'А' && ch <= 'Я') || ch == 'Ё');

            if (hasLower || hasCyrillicLower) score += 1;
            if (hasUpper || hasCyrillicUpper) score += 1;
            if (hasDigit) score += 1;
            if (hasSymbol) score += 1;

            if (!HasRepeatedChars(password)) score += 1;
            if (!HasSequentialChars(password)) score += 1;

            int finalScore = System.Math.Min(score, maxPossibleScore);

            if (length < 16 && finalScore == 10)
            {
                finalScore = 9;
            }

            if (length < 8 && finalScore > 5)
            {
                return 5;
            }

            return finalScore;
        }

        private bool HasRepeatedChars(string password)
        {
            for (int i = 1; i < password.Length; i++)
            {
                if (password[i] == password[i - 1]) return true;
            }
            return false;
        }

        private bool HasSequentialChars(string password)
        {
            for (int i = 0; i < password.Length - 2; i++)
            {
                int diff1 = password[i + 1] - password[i];
                int diff2 = password[i + 2] - password[i + 1];
                if (diff1 == 1 && diff2 == 1) return true;

                if (diff1 == -1 && diff2 == -1) return true;
            }
            return false;
        }
    }
}