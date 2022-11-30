namespace cp
{
    partial class DealForm
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
            this.DealFormLabelCode = new System.Windows.Forms.Label();
            this.DealFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.DealFormButtonOK = new System.Windows.Forms.Button();
            this.DealFormButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DealFormLabelCode
            // 
            this.DealFormLabelCode.AutoSize = true;
            this.DealFormLabelCode.Location = new System.Drawing.Point(20, 20);
            this.DealFormLabelCode.Name = "DealFormLabelCode";
            this.DealFormLabelCode.Size = new System.Drawing.Size(29, 13);
            this.DealFormLabelCode.TabIndex = 0;
            this.DealFormLabelCode.Text = "Код:";
            // 
            // DealFormTextBoxCode
            // 
            this.DealFormTextBoxCode.Location = new System.Drawing.Point(140, 17);
            this.DealFormTextBoxCode.Name = "DealFormTextBoxCode";
            this.DealFormTextBoxCode.ReadOnly = true;
            this.DealFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.DealFormTextBoxCode.TabIndex = 1;
            this.DealFormTextBoxCode.TabStop = false;
            // 
            // DealFormButtonOK
            // 
            this.DealFormButtonOK.Location = new System.Drawing.Point(240, 388);
            this.DealFormButtonOK.Name = "DealFormButtonOK";
            this.DealFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.DealFormButtonOK.TabIndex = 2;
            this.DealFormButtonOK.Text = "OK";
            this.DealFormButtonOK.UseVisualStyleBackColor = true;
            // 
            // DealFormButtonCancel
            // 
            this.DealFormButtonCancel.Location = new System.Drawing.Point(340, 388);
            this.DealFormButtonCancel.Name = "DealFormButtonCancel";
            this.DealFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.DealFormButtonCancel.TabIndex = 3;
            this.DealFormButtonCancel.Text = "Cancel";
            this.DealFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // DealForm
            // 
            this.AcceptButton = this.DealFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DealFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DealFormButtonCancel);
            this.Controls.Add(this.DealFormButtonOK);
            this.Controls.Add(this.DealFormTextBoxCode);
            this.Controls.Add(this.DealFormLabelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DealForm";
            this.Text = "Сделка";
            this.Load += new System.EventHandler(this.DealForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DealFormLabelCode;
        private System.Windows.Forms.TextBox DealFormTextBoxCode;
        private System.Windows.Forms.Button DealFormButtonOK;
        private System.Windows.Forms.Button DealFormButtonCancel;
    }
}