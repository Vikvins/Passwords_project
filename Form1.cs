using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwords_project
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numericLength.Value;
            bool useUpper = cbUpper.Checked;
            bool useDigits = cbDigits.Checked;
            bool useSymbols = cbSymbols.Checked;
            bool useRussian = cbRussian.Checked;

            string password = GeneratePassword(length, useUpper, useDigits, useSymbols, useRussian);
            lblPassword.Text = password;
        }

        private string GeneratePassword(int length, bool useUpper, bool useDigits, bool useSymbols, bool useRussian)
        {
            if (length < 1) return "";

            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string symbols = "!@#$%^&*()-_=+";
            string russian = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            string allChars = lower;

            if (useUpper) allChars += upper;
            if (useDigits) allChars += digits;
            if (useSymbols) allChars += symbols;
            if (useRussian) allChars += russian;

            List<char> passwordChars = new List<char>();

            passwordChars.Add(lower[rnd.Next(lower.Length)]);
            if (useUpper) passwordChars.Add(upper[rnd.Next(upper.Length)]);
            if (useDigits) passwordChars.Add(digits[rnd.Next(digits.Length)]);
            if (useSymbols) passwordChars.Add(symbols[rnd.Next(symbols.Length)]);
            if (useRussian) passwordChars.Add(russian[rnd.Next(russian.Length)]);

            for (int i = passwordChars.Count; i < length; i++)
            {
                passwordChars.Add(allChars[rnd.Next(allChars.Length)]);
            }

            return new string(passwordChars.OrderBy(x => rnd.Next()).ToArray());
        }




        private void btnValidate_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            int score = 0;

            if (password.Length >= 12) score += 2;
            else if (password.Length >= 8) score += 1;

            if (password.Any(char.IsLower)) score += 1;

            if (password.Any(char.IsUpper)) score += 1;

            if (password.Any(char.IsDigit)) score += 1;

            if (password.Any(ch => "!@#$%^&*()-_=+".Contains(ch))) score += 1;

            if (!HasRepeatedChars(password)) score += 1;

            if (!HasSequentialChars(password)) score += 1;

            if (password.Length >= 16) score += 1;

            if (password.Any(char.IsLower) && password.Any(char.IsUpper) &&
                password.Any(char.IsDigit) && password.Any(ch => "!@#$%^&*()-_=+".Contains(ch)))
                score += 1;

            if (password.Distinct().Count() >= 8) score += 1;

            lblResult.Text = $"Надёжность: {score}/10";

            if (score <= 3) lblResult.ForeColor = Color.Red;
            else if (score <= 6) lblResult.ForeColor = Color.Orange;
            else if (score <= 8) lblResult.ForeColor = Color.Blue;
            else lblResult.ForeColor = Color.Green;
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
            }
            return false;
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblPassword.Text))
            {
                Clipboard.SetText(lblPassword.Text);
                MessageBox.Show("Пароль скопирован в буфер обмена!");
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте пароль!");
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
