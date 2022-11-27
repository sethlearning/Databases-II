namespace cp
{
    partial class RoleForm
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
            this.RoleFormLabelCode = new System.Windows.Forms.Label();
            this.RoleFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.RoleFormButtonOK = new System.Windows.Forms.Button();
            this.RoleFormaButtonCancel = new System.Windows.Forms.Button();
            this.RoleFormLabelName = new System.Windows.Forms.Label();
            this.RoleFormTextBoxName = new System.Windows.Forms.TextBox();
            this.RoleFormLabelAccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoleFormLabelCode
            // 
            this.RoleFormLabelCode.AutoSize = true;
            this.RoleFormLabelCode.Location = new System.Drawing.Point(20, 20);
            this.RoleFormLabelCode.Name = "RoleFormLabelCode";
            this.RoleFormLabelCode.Size = new System.Drawing.Size(29, 13);
            this.RoleFormLabelCode.TabIndex = 0;
            this.RoleFormLabelCode.Text = "Код:";
            // 
            // RoleFormTextBoxCode
            // 
            this.RoleFormTextBoxCode.Location = new System.Drawing.Point(140, 17);
            this.RoleFormTextBoxCode.Name = "RoleFormTextBoxCode";
            this.RoleFormTextBoxCode.ReadOnly = true;
            this.RoleFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.RoleFormTextBoxCode.TabIndex = 1;
            // 
            // RoleFormButtonOK
            // 
            this.RoleFormButtonOK.Location = new System.Drawing.Point(324, 369);
            this.RoleFormButtonOK.Name = "RoleFormButtonOK";
            this.RoleFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.RoleFormButtonOK.TabIndex = 2;
            this.RoleFormButtonOK.Text = "OK";
            this.RoleFormButtonOK.UseVisualStyleBackColor = true;
            this.RoleFormButtonOK.Click += new System.EventHandler(this.RoleFormButtonOK_Click);
            // 
            // RoleFormaButtonCancel
            // 
            this.RoleFormaButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RoleFormaButtonCancel.Location = new System.Drawing.Point(459, 368);
            this.RoleFormaButtonCancel.Name = "RoleFormaButtonCancel";
            this.RoleFormaButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.RoleFormaButtonCancel.TabIndex = 3;
            this.RoleFormaButtonCancel.Text = "Cancel";
            this.RoleFormaButtonCancel.UseVisualStyleBackColor = true;
            // 
            // RoleFormLabelName
            // 
            this.RoleFormLabelName.AutoSize = true;
            this.RoleFormLabelName.Location = new System.Drawing.Point(20, 65);
            this.RoleFormLabelName.Name = "RoleFormLabelName";
            this.RoleFormLabelName.Size = new System.Drawing.Size(35, 13);
            this.RoleFormLabelName.TabIndex = 4;
            this.RoleFormLabelName.Text = "Роль:";
            // 
            // RoleFormTextBoxName
            // 
            this.RoleFormTextBoxName.Location = new System.Drawing.Point(140, 62);
            this.RoleFormTextBoxName.Name = "RoleFormTextBoxName";
            this.RoleFormTextBoxName.Size = new System.Drawing.Size(275, 20);
            this.RoleFormTextBoxName.TabIndex = 5;
            // 
            // RoleFormLabelAccess
            // 
            this.RoleFormLabelAccess.AutoSize = true;
            this.RoleFormLabelAccess.Location = new System.Drawing.Point(20, 110);
            this.RoleFormLabelAccess.Name = "RoleFormLabelAccess";
            this.RoleFormLabelAccess.Size = new System.Drawing.Size(47, 13);
            this.RoleFormLabelAccess.TabIndex = 6;
            this.RoleFormLabelAccess.Text = "Доступ:";
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RoleFormaButtonCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoleFormLabelAccess);
            this.Controls.Add(this.RoleFormTextBoxName);
            this.Controls.Add(this.RoleFormLabelName);
            this.Controls.Add(this.RoleFormaButtonCancel);
            this.Controls.Add(this.RoleFormButtonOK);
            this.Controls.Add(this.RoleFormTextBoxCode);
            this.Controls.Add(this.RoleFormLabelCode);
            this.Name = "RoleForm";
            this.Text = "Роль";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleFormLabelCode;
        private System.Windows.Forms.TextBox RoleFormTextBoxCode;
        private System.Windows.Forms.Button RoleFormButtonOK;
        private System.Windows.Forms.Button RoleFormaButtonCancel;
        private System.Windows.Forms.Label RoleFormLabelName;
        private System.Windows.Forms.TextBox RoleFormTextBoxName;
        private System.Windows.Forms.Label RoleFormLabelAccess;
    }
}