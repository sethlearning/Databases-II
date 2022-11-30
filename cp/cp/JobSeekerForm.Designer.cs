namespace cp
{
    partial class JobSeekerForm
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
            this.JobSeekerFormLabelCode = new System.Windows.Forms.Label();
            this.JobSeekerFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.JobSeekerFormButtonOK = new System.Windows.Forms.Button();
            this.JobSeekerFormButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobSeekerFormLabelCode
            // 
            this.JobSeekerFormLabelCode.AutoSize = true;
            this.JobSeekerFormLabelCode.Location = new System.Drawing.Point(20, 20);
            this.JobSeekerFormLabelCode.Name = "JobSeekerFormLabelCode";
            this.JobSeekerFormLabelCode.Size = new System.Drawing.Size(29, 13);
            this.JobSeekerFormLabelCode.TabIndex = 0;
            this.JobSeekerFormLabelCode.Text = "Код:";
            // 
            // JobSeekerFormTextBoxCode
            // 
            this.JobSeekerFormTextBoxCode.Location = new System.Drawing.Point(140, 17);
            this.JobSeekerFormTextBoxCode.Name = "JobSeekerFormTextBoxCode";
            this.JobSeekerFormTextBoxCode.ReadOnly = true;
            this.JobSeekerFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.JobSeekerFormTextBoxCode.TabIndex = 1;
            this.JobSeekerFormTextBoxCode.TabStop = false;
            // 
            // JobSeekerFormButtonOK
            // 
            this.JobSeekerFormButtonOK.Location = new System.Drawing.Point(240, 391);
            this.JobSeekerFormButtonOK.Name = "JobSeekerFormButtonOK";
            this.JobSeekerFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.JobSeekerFormButtonOK.TabIndex = 2;
            this.JobSeekerFormButtonOK.Text = "OK";
            this.JobSeekerFormButtonOK.UseVisualStyleBackColor = true;
            // 
            // JobSeekerFormButtonCancel
            // 
            this.JobSeekerFormButtonCancel.Location = new System.Drawing.Point(340, 391);
            this.JobSeekerFormButtonCancel.Name = "JobSeekerFormButtonCancel";
            this.JobSeekerFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.JobSeekerFormButtonCancel.TabIndex = 3;
            this.JobSeekerFormButtonCancel.Text = "Cancel";
            this.JobSeekerFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // JobSeekerForm
            // 
            this.AcceptButton = this.JobSeekerFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.JobSeekerFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.JobSeekerFormButtonCancel);
            this.Controls.Add(this.JobSeekerFormButtonOK);
            this.Controls.Add(this.JobSeekerFormTextBoxCode);
            this.Controls.Add(this.JobSeekerFormLabelCode);
            this.Name = "JobSeekerForm";
            this.Text = "Соискатель";
            this.Load += new System.EventHandler(this.JobSeekerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JobSeekerFormLabelCode;
        private System.Windows.Forms.TextBox JobSeekerFormTextBoxCode;
        private System.Windows.Forms.Button JobSeekerFormButtonOK;
        private System.Windows.Forms.Button JobSeekerFormButtonCancel;
    }
}