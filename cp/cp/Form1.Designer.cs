namespace cp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginFormLabelDescription = new System.Windows.Forms.Label();
            this.LoginFormLabelUser = new System.Windows.Forms.Label();
            this.LoginFormLabelPassword = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginFormLabelDescription
            // 
            this.LoginFormLabelDescription.AutoSize = true;
            this.LoginFormLabelDescription.Location = new System.Drawing.Point(32, 23);
            this.LoginFormLabelDescription.Name = "LoginFormLabelDescription";
            this.LoginFormLabelDescription.Size = new System.Drawing.Size(226, 13);
            this.LoginFormLabelDescription.TabIndex = 0;
            this.LoginFormLabelDescription.Text = "Выберите пользователя и введите пароль:";
            // 
            // LoginFormLabelUser
            // 
            this.LoginFormLabelUser.AutoSize = true;
            this.LoginFormLabelUser.Location = new System.Drawing.Point(32, 61);
            this.LoginFormLabelUser.Name = "LoginFormLabelUser";
            this.LoginFormLabelUser.Size = new System.Drawing.Size(83, 13);
            this.LoginFormLabelUser.TabIndex = 1;
            this.LoginFormLabelUser.Text = "Пользователь:";
            // 
            // LoginFormLabelPassword
            // 
            this.LoginFormLabelPassword.AutoSize = true;
            this.LoginFormLabelPassword.Location = new System.Drawing.Point(32, 93);
            this.LoginFormLabelPassword.Name = "LoginFormLabelPassword";
            this.LoginFormLabelPassword.Size = new System.Drawing.Size(48, 13);
            this.LoginFormLabelPassword.TabIndex = 2;
            this.LoginFormLabelPassword.Text = "Пароль:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 136);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoginFormLabelPassword);
            this.Controls.Add(this.LoginFormLabelUser);
            this.Controls.Add(this.LoginFormLabelDescription);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginFormLabelDescription;
        private System.Windows.Forms.Label LoginFormLabelUser;
        private System.Windows.Forms.Label LoginFormLabelPassword;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

