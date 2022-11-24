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
            this.components = new System.ComponentModel.Container();
            this.LoginFormLabelDescription = new System.Windows.Forms.Label();
            this.LoginFormLabelUser = new System.Windows.Forms.Label();
            this.LoginFormLabelPassword = new System.Windows.Forms.Label();
            this.LoginFormComboBoxUsername = new System.Windows.Forms.ComboBox();
            this.activeUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.LoginFormTextBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginFormButtonOK = new System.Windows.Forms.Button();
            this.LoginFormButtonCancel = new System.Windows.Forms.Button();
            this.activeUsersTableAdapter = new cp.CPDBDataSetTableAdapters.ActiveUsersTableAdapter();
            this.LoginFormLabelWrongPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
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
            // LoginFormComboBoxUsername
            // 
            this.LoginFormComboBoxUsername.DataSource = this.activeUsersBindingSource;
            this.LoginFormComboBoxUsername.DisplayMember = "UserName";
            this.LoginFormComboBoxUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginFormComboBoxUsername.FormattingEnabled = true;
            this.LoginFormComboBoxUsername.Location = new System.Drawing.Point(160, 53);
            this.LoginFormComboBoxUsername.Name = "LoginFormComboBoxUsername";
            this.LoginFormComboBoxUsername.Size = new System.Drawing.Size(188, 21);
            this.LoginFormComboBoxUsername.TabIndex = 3;
            this.LoginFormComboBoxUsername.ValueMember = "Code";
            this.LoginFormComboBoxUsername.SelectedValueChanged += new System.EventHandler(this.LoginFormComboBoxUsername_SelectedValueChanged);
            // 
            // activeUsersBindingSource
            // 
            this.activeUsersBindingSource.DataMember = "ActiveUsers";
            this.activeUsersBindingSource.DataSource = this.cPDBDataSet;
            // 
            // cPDBDataSet
            // 
            this.cPDBDataSet.DataSetName = "CPDBDataSet";
            this.cPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoginFormTextBoxPassword
            // 
            this.LoginFormTextBoxPassword.Location = new System.Drawing.Point(160, 86);
            this.LoginFormTextBoxPassword.Name = "LoginFormTextBoxPassword";
            this.LoginFormTextBoxPassword.PasswordChar = '*';
            this.LoginFormTextBoxPassword.Size = new System.Drawing.Size(188, 20);
            this.LoginFormTextBoxPassword.TabIndex = 4;
            this.LoginFormTextBoxPassword.TextChanged += new System.EventHandler(this.LoginFormTextBoxPassword_TextChanged);
            // 
            // LoginFormButtonOK
            // 
            this.LoginFormButtonOK.Location = new System.Drawing.Point(160, 138);
            this.LoginFormButtonOK.Name = "LoginFormButtonOK";
            this.LoginFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.LoginFormButtonOK.TabIndex = 5;
            this.LoginFormButtonOK.Text = "Enter";
            this.LoginFormButtonOK.UseVisualStyleBackColor = true;
            this.LoginFormButtonOK.Click += new System.EventHandler(this.LoginFormButtonOK_Click);
            // 
            // LoginFormButtonCancel
            // 
            this.LoginFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginFormButtonCancel.Location = new System.Drawing.Point(272, 137);
            this.LoginFormButtonCancel.Name = "LoginFormButtonCancel";
            this.LoginFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.LoginFormButtonCancel.TabIndex = 6;
            this.LoginFormButtonCancel.Text = "Close";
            this.LoginFormButtonCancel.UseVisualStyleBackColor = true;
            this.LoginFormButtonCancel.Click += new System.EventHandler(this.LoginFormButtonCancel_Click);
            // 
            // activeUsersTableAdapter
            // 
            this.activeUsersTableAdapter.ClearBeforeFill = true;
            // 
            // LoginFormLabelWrongPassword
            // 
            this.LoginFormLabelWrongPassword.AutoSize = true;
            this.LoginFormLabelWrongPassword.ForeColor = System.Drawing.Color.Red;
            this.LoginFormLabelWrongPassword.Location = new System.Drawing.Point(86, 115);
            this.LoginFormLabelWrongPassword.Name = "LoginFormLabelWrongPassword";
            this.LoginFormLabelWrongPassword.Size = new System.Drawing.Size(214, 13);
            this.LoginFormLabelWrongPassword.TabIndex = 7;
            this.LoginFormLabelWrongPassword.Text = "Неверное имя пользователя или пароль";
            this.LoginFormLabelWrongPassword.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.LoginFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(388, 178);
            this.ControlBox = false;
            this.Controls.Add(this.LoginFormLabelWrongPassword);
            this.Controls.Add(this.LoginFormButtonCancel);
            this.Controls.Add(this.LoginFormButtonOK);
            this.Controls.Add(this.LoginFormTextBoxPassword);
            this.Controls.Add(this.LoginFormComboBoxUsername);
            this.Controls.Add(this.LoginFormLabelPassword);
            this.Controls.Add(this.LoginFormLabelUser);
            this.Controls.Add(this.LoginFormLabelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginFormLabelDescription;
        private System.Windows.Forms.Label LoginFormLabelUser;
        private System.Windows.Forms.Label LoginFormLabelPassword;
        private System.Windows.Forms.ComboBox LoginFormComboBoxUsername;
        private System.Windows.Forms.TextBox LoginFormTextBoxPassword;
        private System.Windows.Forms.Button LoginFormButtonOK;
        private System.Windows.Forms.Button LoginFormButtonCancel;
        private CPDBDataSet cPDBDataSet;
        private System.Windows.Forms.BindingSource activeUsersBindingSource;
        private CPDBDataSetTableAdapters.ActiveUsersTableAdapter activeUsersTableAdapter;
        private System.Windows.Forms.Label LoginFormLabelWrongPassword;
    }
}

