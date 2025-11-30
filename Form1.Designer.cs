namespace passwords_project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbDigits = new System.Windows.Forms.CheckBox();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRussian = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Генератор и валидатор паролей";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(429, 134);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(163, 61);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Сгенерировать пароль";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(429, 270);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(332, 61);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Проверить пароль";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(426, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 16);
            this.lblPassword.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(426, 334);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.Location = new System.Drawing.Point(31, 134);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(240, 20);
            this.cbUpper.TabIndex = 6;
            this.cbUpper.Text = "Использовать заглавные буквы";
            this.cbUpper.UseVisualStyleBackColor = true;
            // 
            // cbDigits
            // 
            this.cbDigits.AutoSize = true;
            this.cbDigits.Location = new System.Drawing.Point(31, 160);
            this.cbDigits.Name = "cbDigits";
            this.cbDigits.Size = new System.Drawing.Size(170, 20);
            this.cbDigits.TabIndex = 7;
            this.cbDigits.Text = "Использовать цифры";
            this.cbDigits.UseVisualStyleBackColor = true;
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Location = new System.Drawing.Point(31, 186);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(214, 20);
            this.cbSymbols.TabIndex = 8;
            this.cbSymbols.Text = "Использовать спецсимволы";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // numericLength
            // 
            this.numericLength.Location = new System.Drawing.Point(220, 290);
            this.numericLength.Name = "numericLength";
            this.numericLength.Size = new System.Drawing.Size(120, 22);
            this.numericLength.TabIndex = 9;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(598, 134);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(163, 61);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Скопировать в буфер обмена";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(388, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите ваш пароль:";
            // 
            // cbRussian
            // 
            this.cbRussian.AutoSize = true;
            this.cbRussian.Location = new System.Drawing.Point(31, 212);
            this.cbRussian.Name = "cbRussian";
            this.cbRussian.Size = new System.Drawing.Size(191, 20);
            this.cbRussian.TabIndex = 12;
            this.cbRussian.Text = "Добавить русские буквы";
            this.cbRussian.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Изменить размер пароля:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRussian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.numericLength);
            this.Controls.Add(this.cbSymbols);
            this.Controls.Add(this.cbDigits);
            this.Controls.Add(this.cbUpper);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbDigits;
        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.NumericUpDown numericLength;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRussian;
        private System.Windows.Forms.Label label3;
    }
}