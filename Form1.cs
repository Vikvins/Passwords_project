// Файл: Form1.cs
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие 'using' остаются без изменений

namespace passwords_project
{
    public partial class Form1 : Form
    {
        private readonly PasswordGenerator _generator = new PasswordGenerator();
        private readonly PasswordValidator _validator = new PasswordValidator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numericLength.Value;
            bool useUpper = cbUpper.Checked;
            bool useDigits = cbDigits.Checked;
            bool useSymbols = cbSymbols.Checked;
            bool useRussian = cbRussian.Checked;

            string password = _generator.GeneratePassword(length, useUpper, useDigits, useSymbols, useRussian);

            lblPassword.Text = password;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            int score = _validator.Validate(password);

            lblResult.Text = $"Надёжность: {score}/10";

            if (password.Length < 8)
            {
                lblResult.ForeColor = Color.Red;
            }
            else if (score <= 3)
            {
                lblResult.ForeColor = Color.Red;
            }
            else if (score <= 6)
            {
                lblResult.ForeColor = Color.Orange;
            }
            else if (score <= 8)
            {
                lblResult.ForeColor = Color.Blue;
            }
            else
            {
                lblResult.ForeColor = Color.Green;
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}