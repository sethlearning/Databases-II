﻿namespace cp
{
    partial class UserForm
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
            this.UserFormLabelCode = new System.Windows.Forms.Label();
            this.UserFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.UserFormButtonOK = new System.Windows.Forms.Button();
            this.UserFormButtonCancel = new System.Windows.Forms.Button();
            this.UserFormLabelUsername = new System.Windows.Forms.Label();
            this.UserFormTextBoxUsername = new System.Windows.Forms.TextBox();
            this.UserFormLabelPassword = new System.Windows.Forms.Label();
            this.UserFormTextBoxPassword = new System.Windows.Forms.TextBox();
            this.UserFormLabelPasswordDescription = new System.Windows.Forms.Label();
            this.UserFormLabelRole = new System.Windows.Forms.Label();
            this.UserFormComboBoxRole = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.UserFormLabelActive = new System.Windows.Forms.Label();
            this.UserFormCheckBoxActive = new System.Windows.Forms.CheckBox();
            this.rolesTableAdapter = new cp.CPDBDataSetTableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UserFormLabelCode
            // 
            this.UserFormLabelCode.AutoSize = true;
            this.UserFormLabelCode.Location = new System.Drawing.Point(20, 20);
            this.UserFormLabelCode.Name = "UserFormLabelCode";
            this.UserFormLabelCode.Size = new System.Drawing.Size(29, 13);
            this.UserFormLabelCode.TabIndex = 0;
            this.UserFormLabelCode.Text = "Код:";
            // 
            // UserFormTextBoxCode
            // 
            this.UserFormTextBoxCode.Location = new System.Drawing.Point(140, 17);
            this.UserFormTextBoxCode.Name = "UserFormTextBoxCode";
            this.UserFormTextBoxCode.ReadOnly = true;
            this.UserFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.UserFormTextBoxCode.TabIndex = 1;
            this.UserFormTextBoxCode.TabStop = false;
            // 
            // UserFormButtonOK
            // 
            this.UserFormButtonOK.Location = new System.Drawing.Point(240, 249);
            this.UserFormButtonOK.Name = "UserFormButtonOK";
            this.UserFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.UserFormButtonOK.TabIndex = 5;
            this.UserFormButtonOK.Text = "OK";
            this.UserFormButtonOK.UseVisualStyleBackColor = true;
            this.UserFormButtonOK.Click += new System.EventHandler(this.UserFormButtonOK_Click);
            // 
            // UserFormButtonCancel
            // 
            this.UserFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UserFormButtonCancel.Location = new System.Drawing.Point(340, 249);
            this.UserFormButtonCancel.Name = "UserFormButtonCancel";
            this.UserFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.UserFormButtonCancel.TabIndex = 6;
            this.UserFormButtonCancel.Text = "Cancel";
            this.UserFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // UserFormLabelUsername
            // 
            this.UserFormLabelUsername.AutoSize = true;
            this.UserFormLabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFormLabelUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserFormLabelUsername.Location = new System.Drawing.Point(20, 65);
            this.UserFormLabelUsername.Name = "UserFormLabelUsername";
            this.UserFormLabelUsername.Size = new System.Drawing.Size(106, 13);
            this.UserFormLabelUsername.TabIndex = 4;
            this.UserFormLabelUsername.Text = "Имя пользователя:";
            // 
            // UserFormTextBoxUsername
            // 
            this.UserFormTextBoxUsername.Location = new System.Drawing.Point(140, 62);
            this.UserFormTextBoxUsername.Name = "UserFormTextBoxUsername";
            this.UserFormTextBoxUsername.Size = new System.Drawing.Size(275, 20);
            this.UserFormTextBoxUsername.TabIndex = 1;
            // 
            // UserFormLabelPassword
            // 
            this.UserFormLabelPassword.AutoSize = true;
            this.UserFormLabelPassword.Location = new System.Drawing.Point(20, 110);
            this.UserFormLabelPassword.Name = "UserFormLabelPassword";
            this.UserFormLabelPassword.Size = new System.Drawing.Size(83, 13);
            this.UserFormLabelPassword.TabIndex = 6;
            this.UserFormLabelPassword.Text = "Новый пароль:";
            // 
            // UserFormTextBoxPassword
            // 
            this.UserFormTextBoxPassword.Location = new System.Drawing.Point(140, 107);
            this.UserFormTextBoxPassword.Name = "UserFormTextBoxPassword";
            this.UserFormTextBoxPassword.Size = new System.Drawing.Size(275, 20);
            this.UserFormTextBoxPassword.TabIndex = 2;
            // 
            // UserFormLabelPasswordDescription
            // 
            this.UserFormLabelPasswordDescription.AutoSize = true;
            this.UserFormLabelPasswordDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFormLabelPasswordDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserFormLabelPasswordDescription.Location = new System.Drawing.Point(143, 129);
            this.UserFormLabelPasswordDescription.Name = "UserFormLabelPasswordDescription";
            this.UserFormLabelPasswordDescription.Size = new System.Drawing.Size(269, 13);
            this.UserFormLabelPasswordDescription.TabIndex = 8;
            this.UserFormLabelPasswordDescription.Text = "Оставить пустым, если смена пароля не требуется";
            // 
            // UserFormLabelRole
            // 
            this.UserFormLabelRole.AutoSize = true;
            this.UserFormLabelRole.Location = new System.Drawing.Point(20, 155);
            this.UserFormLabelRole.Name = "UserFormLabelRole";
            this.UserFormLabelRole.Size = new System.Drawing.Size(35, 13);
            this.UserFormLabelRole.TabIndex = 9;
            this.UserFormLabelRole.Text = "Роль:";
            // 
            // UserFormComboBoxRole
            // 
            this.UserFormComboBoxRole.DataSource = this.rolesBindingSource;
            this.UserFormComboBoxRole.DisplayMember = "Name";
            this.UserFormComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserFormComboBoxRole.FormattingEnabled = true;
            this.UserFormComboBoxRole.Location = new System.Drawing.Point(140, 152);
            this.UserFormComboBoxRole.Name = "UserFormComboBoxRole";
            this.UserFormComboBoxRole.Size = new System.Drawing.Size(275, 21);
            this.UserFormComboBoxRole.TabIndex = 3;
            this.UserFormComboBoxRole.ValueMember = "Code";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.cPDBDataSet;
            // 
            // cPDBDataSet
            // 
            this.cPDBDataSet.DataSetName = "CPDBDataSet";
            this.cPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserFormLabelActive
            // 
            this.UserFormLabelActive.AutoSize = true;
            this.UserFormLabelActive.Location = new System.Drawing.Point(20, 200);
            this.UserFormLabelActive.Name = "UserFormLabelActive";
            this.UserFormLabelActive.Size = new System.Drawing.Size(52, 13);
            this.UserFormLabelActive.TabIndex = 11;
            this.UserFormLabelActive.Text = "Активен:";
            // 
            // UserFormCheckBoxActive
            // 
            this.UserFormCheckBoxActive.AutoSize = true;
            this.UserFormCheckBoxActive.Location = new System.Drawing.Point(140, 197);
            this.UserFormCheckBoxActive.Name = "UserFormCheckBoxActive";
            this.UserFormCheckBoxActive.Size = new System.Drawing.Size(15, 14);
            this.UserFormCheckBoxActive.TabIndex = 4;
            this.UserFormCheckBoxActive.UseVisualStyleBackColor = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AcceptButton = this.UserFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.UserFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.UserFormCheckBoxActive);
            this.Controls.Add(this.UserFormLabelActive);
            this.Controls.Add(this.UserFormComboBoxRole);
            this.Controls.Add(this.UserFormLabelRole);
            this.Controls.Add(this.UserFormLabelPasswordDescription);
            this.Controls.Add(this.UserFormTextBoxPassword);
            this.Controls.Add(this.UserFormLabelPassword);
            this.Controls.Add(this.UserFormTextBoxUsername);
            this.Controls.Add(this.UserFormLabelUsername);
            this.Controls.Add(this.UserFormButtonCancel);
            this.Controls.Add(this.UserFormButtonOK);
            this.Controls.Add(this.UserFormTextBoxCode);
            this.Controls.Add(this.UserFormLabelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserFormLabelCode;
        private System.Windows.Forms.TextBox UserFormTextBoxCode;
        private System.Windows.Forms.Button UserFormButtonOK;
        private System.Windows.Forms.Button UserFormButtonCancel;
        private System.Windows.Forms.Label UserFormLabelUsername;
        private System.Windows.Forms.TextBox UserFormTextBoxUsername;
        private System.Windows.Forms.Label UserFormLabelPassword;
        private System.Windows.Forms.TextBox UserFormTextBoxPassword;
        private System.Windows.Forms.Label UserFormLabelPasswordDescription;
        private System.Windows.Forms.Label UserFormLabelRole;
        private System.Windows.Forms.ComboBox UserFormComboBoxRole;
        private System.Windows.Forms.Label UserFormLabelActive;
        private System.Windows.Forms.CheckBox UserFormCheckBoxActive;
        private CPDBDataSet cPDBDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private CPDBDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
    }
}