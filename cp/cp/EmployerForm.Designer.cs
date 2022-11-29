namespace cp
{
    partial class EmployerForm
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
            this.EmployerFormLabelCode = new System.Windows.Forms.Label();
            this.EmployerFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.EmployerFormLabelName = new System.Windows.Forms.Label();
            this.EmployerFormTextBoxName = new System.Windows.Forms.TextBox();
            this.EmployerFormLabelAddress = new System.Windows.Forms.Label();
            this.EmployerFormTextBoxAddress = new System.Windows.Forms.TextBox();
            this.EmployerFormLabelPhone = new System.Windows.Forms.Label();
            this.EmployerFormTextBoxPhone = new System.Windows.Forms.TextBox();
            this.EmployerFormButtonOK = new System.Windows.Forms.Button();
            this.EmployerFormButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployerFormLabelCode
            // 
            this.EmployerFormLabelCode.AutoSize = true;
            this.EmployerFormLabelCode.Location = new System.Drawing.Point(20, 20);
            this.EmployerFormLabelCode.Name = "EmployerFormLabelCode";
            this.EmployerFormLabelCode.Size = new System.Drawing.Size(29, 13);
            this.EmployerFormLabelCode.TabIndex = 0;
            this.EmployerFormLabelCode.Text = "Код:";
            // 
            // EmployerFormTextBoxCode
            // 
            this.EmployerFormTextBoxCode.Location = new System.Drawing.Point(140, 17);
            this.EmployerFormTextBoxCode.Name = "EmployerFormTextBoxCode";
            this.EmployerFormTextBoxCode.ReadOnly = true;
            this.EmployerFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.EmployerFormTextBoxCode.TabIndex = 1;
            this.EmployerFormTextBoxCode.TabStop = false;
            // 
            // EmployerFormLabelName
            // 
            this.EmployerFormLabelName.AutoSize = true;
            this.EmployerFormLabelName.Location = new System.Drawing.Point(20, 65);
            this.EmployerFormLabelName.Name = "EmployerFormLabelName";
            this.EmployerFormLabelName.Size = new System.Drawing.Size(60, 13);
            this.EmployerFormLabelName.TabIndex = 2;
            this.EmployerFormLabelName.Text = "Название:";
            // 
            // EmployerFormTextBoxName
            // 
            this.EmployerFormTextBoxName.Location = new System.Drawing.Point(140, 62);
            this.EmployerFormTextBoxName.Name = "EmployerFormTextBoxName";
            this.EmployerFormTextBoxName.Size = new System.Drawing.Size(275, 20);
            this.EmployerFormTextBoxName.TabIndex = 0;
            // 
            // EmployerFormLabelAddress
            // 
            this.EmployerFormLabelAddress.AutoSize = true;
            this.EmployerFormLabelAddress.Location = new System.Drawing.Point(20, 110);
            this.EmployerFormLabelAddress.Name = "EmployerFormLabelAddress";
            this.EmployerFormLabelAddress.Size = new System.Drawing.Size(41, 13);
            this.EmployerFormLabelAddress.TabIndex = 4;
            this.EmployerFormLabelAddress.Text = "Адрес:";
            // 
            // EmployerFormTextBoxAddress
            // 
            this.EmployerFormTextBoxAddress.Location = new System.Drawing.Point(140, 107);
            this.EmployerFormTextBoxAddress.Name = "EmployerFormTextBoxAddress";
            this.EmployerFormTextBoxAddress.Size = new System.Drawing.Size(275, 20);
            this.EmployerFormTextBoxAddress.TabIndex = 1;
            // 
            // EmployerFormLabelPhone
            // 
            this.EmployerFormLabelPhone.AutoSize = true;
            this.EmployerFormLabelPhone.Location = new System.Drawing.Point(20, 155);
            this.EmployerFormLabelPhone.Name = "EmployerFormLabelPhone";
            this.EmployerFormLabelPhone.Size = new System.Drawing.Size(55, 13);
            this.EmployerFormLabelPhone.TabIndex = 6;
            this.EmployerFormLabelPhone.Text = "Телефон:";
            // 
            // EmployerFormTextBoxPhone
            // 
            this.EmployerFormTextBoxPhone.Location = new System.Drawing.Point(140, 152);
            this.EmployerFormTextBoxPhone.Name = "EmployerFormTextBoxPhone";
            this.EmployerFormTextBoxPhone.Size = new System.Drawing.Size(275, 20);
            this.EmployerFormTextBoxPhone.TabIndex = 2;
            // 
            // EmployerFormButtonOK
            // 
            this.EmployerFormButtonOK.Location = new System.Drawing.Point(240, 200);
            this.EmployerFormButtonOK.Name = "EmployerFormButtonOK";
            this.EmployerFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.EmployerFormButtonOK.TabIndex = 3;
            this.EmployerFormButtonOK.Text = "OK";
            this.EmployerFormButtonOK.UseVisualStyleBackColor = true;
            this.EmployerFormButtonOK.Click += new System.EventHandler(this.EmployerFormButtonOK_Click);
            // 
            // EmployerFormButtonCancel
            // 
            this.EmployerFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EmployerFormButtonCancel.Location = new System.Drawing.Point(340, 200);
            this.EmployerFormButtonCancel.Name = "EmployerFormButtonCancel";
            this.EmployerFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.EmployerFormButtonCancel.TabIndex = 4;
            this.EmployerFormButtonCancel.Text = "Cancel";
            this.EmployerFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // EmployerForm
            // 
            this.AcceptButton = this.EmployerFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.EmployerFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(444, 244);
            this.Controls.Add(this.EmployerFormButtonCancel);
            this.Controls.Add(this.EmployerFormButtonOK);
            this.Controls.Add(this.EmployerFormTextBoxPhone);
            this.Controls.Add(this.EmployerFormLabelPhone);
            this.Controls.Add(this.EmployerFormTextBoxAddress);
            this.Controls.Add(this.EmployerFormLabelAddress);
            this.Controls.Add(this.EmployerFormTextBoxName);
            this.Controls.Add(this.EmployerFormLabelName);
            this.Controls.Add(this.EmployerFormTextBoxCode);
            this.Controls.Add(this.EmployerFormLabelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployerForm";
            this.Text = "EmployerForm";
            this.Load += new System.EventHandler(this.EmployerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployerFormLabelCode;
        private System.Windows.Forms.TextBox EmployerFormTextBoxCode;
        private System.Windows.Forms.Label EmployerFormLabelName;
        private System.Windows.Forms.TextBox EmployerFormTextBoxName;
        private System.Windows.Forms.Label EmployerFormLabelAddress;
        private System.Windows.Forms.TextBox EmployerFormTextBoxAddress;
        private System.Windows.Forms.Label EmployerFormLabelPhone;
        private System.Windows.Forms.TextBox EmployerFormTextBoxPhone;
        private System.Windows.Forms.Button EmployerFormButtonOK;
        private System.Windows.Forms.Button EmployerFormButtonCancel;
    }
}