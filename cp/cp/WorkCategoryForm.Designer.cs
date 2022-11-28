namespace cp
{
    partial class WorkCategoryForm
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
            this.WorkCategoryFormLabelCode = new System.Windows.Forms.Label();
            this.WorkCategoryFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.WorkCategoryLabelName = new System.Windows.Forms.Label();
            this.WorkCategoryFormTextBoxName = new System.Windows.Forms.TextBox();
            this.WorkCategoryFormButtonOK = new System.Windows.Forms.Button();
            this.WorkCategoryButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkCategoryFormLabelCode
            // 
            this.WorkCategoryFormLabelCode.AutoSize = true;
            this.WorkCategoryFormLabelCode.Location = new System.Drawing.Point(20, 20);
            this.WorkCategoryFormLabelCode.Name = "WorkCategoryFormLabelCode";
            this.WorkCategoryFormLabelCode.Size = new System.Drawing.Size(29, 13);
            this.WorkCategoryFormLabelCode.TabIndex = 0;
            this.WorkCategoryFormLabelCode.Text = "Код:";
            // 
            // WorkCategoryFormTextBoxCode
            // 
            this.WorkCategoryFormTextBoxCode.Location = new System.Drawing.Point(140, 17);
            this.WorkCategoryFormTextBoxCode.Name = "WorkCategoryFormTextBoxCode";
            this.WorkCategoryFormTextBoxCode.ReadOnly = true;
            this.WorkCategoryFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.WorkCategoryFormTextBoxCode.TabIndex = 1;
            this.WorkCategoryFormTextBoxCode.TabStop = false;
            // 
            // WorkCategoryLabelName
            // 
            this.WorkCategoryLabelName.AutoSize = true;
            this.WorkCategoryLabelName.Location = new System.Drawing.Point(20, 65);
            this.WorkCategoryLabelName.Name = "WorkCategoryLabelName";
            this.WorkCategoryLabelName.Size = new System.Drawing.Size(63, 13);
            this.WorkCategoryLabelName.TabIndex = 2;
            this.WorkCategoryLabelName.Text = "Категория:";
            // 
            // WorkCategoryFormTextBoxName
            // 
            this.WorkCategoryFormTextBoxName.Location = new System.Drawing.Point(140, 62);
            this.WorkCategoryFormTextBoxName.Name = "WorkCategoryFormTextBoxName";
            this.WorkCategoryFormTextBoxName.Size = new System.Drawing.Size(275, 20);
            this.WorkCategoryFormTextBoxName.TabIndex = 0;
            // 
            // WorkCategoryFormButtonOK
            // 
            this.WorkCategoryFormButtonOK.Location = new System.Drawing.Point(240, 110);
            this.WorkCategoryFormButtonOK.Name = "WorkCategoryFormButtonOK";
            this.WorkCategoryFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.WorkCategoryFormButtonOK.TabIndex = 1;
            this.WorkCategoryFormButtonOK.Text = "OK";
            this.WorkCategoryFormButtonOK.UseVisualStyleBackColor = true;
            this.WorkCategoryFormButtonOK.Click += new System.EventHandler(this.WorkCategoryFormButtonOK_Click);
            // 
            // WorkCategoryButtonCancel
            // 
            this.WorkCategoryButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WorkCategoryButtonCancel.Location = new System.Drawing.Point(340, 110);
            this.WorkCategoryButtonCancel.Name = "WorkCategoryButtonCancel";
            this.WorkCategoryButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.WorkCategoryButtonCancel.TabIndex = 2;
            this.WorkCategoryButtonCancel.Text = "Cancel";
            this.WorkCategoryButtonCancel.UseVisualStyleBackColor = true;
            // 
            // WorkCategoryForm
            // 
            this.AcceptButton = this.WorkCategoryFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.WorkCategoryButtonCancel;
            this.ClientSize = new System.Drawing.Size(444, 153);
            this.Controls.Add(this.WorkCategoryButtonCancel);
            this.Controls.Add(this.WorkCategoryFormButtonOK);
            this.Controls.Add(this.WorkCategoryFormTextBoxName);
            this.Controls.Add(this.WorkCategoryLabelName);
            this.Controls.Add(this.WorkCategoryFormTextBoxCode);
            this.Controls.Add(this.WorkCategoryFormLabelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkCategoryForm";
            this.Text = "Вид деятельности";
            this.Load += new System.EventHandler(this.WorkCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WorkCategoryFormLabelCode;
        private System.Windows.Forms.TextBox WorkCategoryFormTextBoxCode;
        private System.Windows.Forms.Label WorkCategoryLabelName;
        private System.Windows.Forms.TextBox WorkCategoryFormTextBoxName;
        private System.Windows.Forms.Button WorkCategoryFormButtonOK;
        private System.Windows.Forms.Button WorkCategoryButtonCancel;
    }
}