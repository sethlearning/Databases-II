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
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoleFormTextBoxCode);
            this.Controls.Add(this.RoleFormLabelCode);
            this.Name = "RoleForm";
            this.Text = "Роль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleFormLabelCode;
        private System.Windows.Forms.TextBox RoleFormTextBoxCode;
    }
}