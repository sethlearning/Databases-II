namespace cp
{
    partial class VacancyForm
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
            this.VacancyFormLabelCode = new System.Windows.Forms.Label();
            this.VacancyFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.VacancyFormButtonOK = new System.Windows.Forms.Button();
            this.VacancyFormButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VacancyFormLabelCode
            // 
            this.VacancyFormLabelCode.AutoSize = true;
            this.VacancyFormLabelCode.Location = new System.Drawing.Point(20, 20);
            this.VacancyFormLabelCode.Name = "VacancyFormLabelCode";
            this.VacancyFormLabelCode.Size = new System.Drawing.Size(29, 13);
            this.VacancyFormLabelCode.TabIndex = 0;
            this.VacancyFormLabelCode.Text = "Код:";
            // 
            // VacancyFormTextBoxCode
            // 
            this.VacancyFormTextBoxCode.Location = new System.Drawing.Point(140, 17);
            this.VacancyFormTextBoxCode.Name = "VacancyFormTextBoxCode";
            this.VacancyFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.VacancyFormTextBoxCode.TabIndex = 1;
            // 
            // VacancyFormButtonOK
            // 
            this.VacancyFormButtonOK.Location = new System.Drawing.Point(240, 383);
            this.VacancyFormButtonOK.Name = "VacancyFormButtonOK";
            this.VacancyFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.VacancyFormButtonOK.TabIndex = 2;
            this.VacancyFormButtonOK.Text = "OK";
            this.VacancyFormButtonOK.UseVisualStyleBackColor = true;
            // 
            // VacancyFormButtonCancel
            // 
            this.VacancyFormButtonCancel.Location = new System.Drawing.Point(340, 383);
            this.VacancyFormButtonCancel.Name = "VacancyFormButtonCancel";
            this.VacancyFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.VacancyFormButtonCancel.TabIndex = 3;
            this.VacancyFormButtonCancel.Text = "Cancel";
            this.VacancyFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // VacancyForm
            // 
            this.AcceptButton = this.VacancyFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.VacancyFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.VacancyFormButtonCancel);
            this.Controls.Add(this.VacancyFormButtonOK);
            this.Controls.Add(this.VacancyFormTextBoxCode);
            this.Controls.Add(this.VacancyFormLabelCode);
            this.Name = "VacancyForm";
            this.Text = "VacancyForm";
            this.Load += new System.EventHandler(this.VacancyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VacancyFormLabelCode;
        private System.Windows.Forms.TextBox VacancyFormTextBoxCode;
        private System.Windows.Forms.Button VacancyFormButtonOK;
        private System.Windows.Forms.Button VacancyFormButtonCancel;
    }
}