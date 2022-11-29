﻿namespace cp
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
            this.components = new System.ComponentModel.Container();
            this.VacancyFormLabelCode = new System.Windows.Forms.Label();
            this.VacancyFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.VacancyFormButtonOK = new System.Windows.Forms.Button();
            this.VacancyFormButtonCancel = new System.Windows.Forms.Button();
            this.VacancyFormLabelWorkCategory = new System.Windows.Forms.Label();
            this.VacancyFormComboBoxWorkCategory = new System.Windows.Forms.ComboBox();
            this.workCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.workCategoriesTableAdapter = new cp.CPDBDataSetTableAdapters.WorkCategoriesTableAdapter();
            this.VacancyFormLabelPosition = new System.Windows.Forms.Label();
            this.VacancyFormTextBoxPosition = new System.Windows.Forms.TextBox();
            this.VacancyFormLabelSalary = new System.Windows.Forms.Label();
            this.VacancyFormTextBoxSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.workCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
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
            this.VacancyFormTextBoxCode.ReadOnly = true;
            this.VacancyFormTextBoxCode.Size = new System.Drawing.Size(275, 20);
            this.VacancyFormTextBoxCode.TabIndex = 1;
            this.VacancyFormTextBoxCode.TabStop = false;
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
            this.VacancyFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.VacancyFormButtonCancel.Location = new System.Drawing.Point(340, 383);
            this.VacancyFormButtonCancel.Name = "VacancyFormButtonCancel";
            this.VacancyFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.VacancyFormButtonCancel.TabIndex = 3;
            this.VacancyFormButtonCancel.Text = "Cancel";
            this.VacancyFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // VacancyFormLabelWorkCategory
            // 
            this.VacancyFormLabelWorkCategory.AutoSize = true;
            this.VacancyFormLabelWorkCategory.Location = new System.Drawing.Point(20, 65);
            this.VacancyFormLabelWorkCategory.Name = "VacancyFormLabelWorkCategory";
            this.VacancyFormLabelWorkCategory.Size = new System.Drawing.Size(102, 13);
            this.VacancyFormLabelWorkCategory.TabIndex = 4;
            this.VacancyFormLabelWorkCategory.Text = "Вид деятельности:";
            // 
            // VacancyFormComboBoxWorkCategory
            // 
            this.VacancyFormComboBoxWorkCategory.DataSource = this.workCategoriesBindingSource;
            this.VacancyFormComboBoxWorkCategory.DisplayMember = "Name";
            this.VacancyFormComboBoxWorkCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VacancyFormComboBoxWorkCategory.FormattingEnabled = true;
            this.VacancyFormComboBoxWorkCategory.Location = new System.Drawing.Point(140, 62);
            this.VacancyFormComboBoxWorkCategory.Name = "VacancyFormComboBoxWorkCategory";
            this.VacancyFormComboBoxWorkCategory.Size = new System.Drawing.Size(275, 21);
            this.VacancyFormComboBoxWorkCategory.TabIndex = 5;
            this.VacancyFormComboBoxWorkCategory.ValueMember = "Code";
            // 
            // workCategoriesBindingSource
            // 
            this.workCategoriesBindingSource.DataMember = "WorkCategories";
            this.workCategoriesBindingSource.DataSource = this.cPDBDataSet;
            // 
            // cPDBDataSet
            // 
            this.cPDBDataSet.DataSetName = "CPDBDataSet";
            this.cPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workCategoriesTableAdapter
            // 
            this.workCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // VacancyFormLabelPosition
            // 
            this.VacancyFormLabelPosition.AutoSize = true;
            this.VacancyFormLabelPosition.Location = new System.Drawing.Point(20, 110);
            this.VacancyFormLabelPosition.Name = "VacancyFormLabelPosition";
            this.VacancyFormLabelPosition.Size = new System.Drawing.Size(68, 13);
            this.VacancyFormLabelPosition.TabIndex = 6;
            this.VacancyFormLabelPosition.Text = "Должность:";
            // 
            // VacancyFormTextBoxPosition
            // 
            this.VacancyFormTextBoxPosition.Location = new System.Drawing.Point(140, 107);
            this.VacancyFormTextBoxPosition.Name = "VacancyFormTextBoxPosition";
            this.VacancyFormTextBoxPosition.Size = new System.Drawing.Size(275, 20);
            this.VacancyFormTextBoxPosition.TabIndex = 7;
            // 
            // VacancyFormLabelSalary
            // 
            this.VacancyFormLabelSalary.AutoSize = true;
            this.VacancyFormLabelSalary.Location = new System.Drawing.Point(20, 155);
            this.VacancyFormLabelSalary.Name = "VacancyFormLabelSalary";
            this.VacancyFormLabelSalary.Size = new System.Drawing.Size(64, 13);
            this.VacancyFormLabelSalary.TabIndex = 8;
            this.VacancyFormLabelSalary.Text = "Зар. плата:";
            // 
            // VacancyFormTextBoxSalary
            // 
            this.VacancyFormTextBoxSalary.Location = new System.Drawing.Point(140, 152);
            this.VacancyFormTextBoxSalary.Name = "VacancyFormTextBoxSalary";
            this.VacancyFormTextBoxSalary.Size = new System.Drawing.Size(275, 20);
            this.VacancyFormTextBoxSalary.TabIndex = 9;
            // 
            // VacancyForm
            // 
            this.AcceptButton = this.VacancyFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.VacancyFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.VacancyFormTextBoxSalary);
            this.Controls.Add(this.VacancyFormLabelSalary);
            this.Controls.Add(this.VacancyFormTextBoxPosition);
            this.Controls.Add(this.VacancyFormLabelPosition);
            this.Controls.Add(this.VacancyFormComboBoxWorkCategory);
            this.Controls.Add(this.VacancyFormLabelWorkCategory);
            this.Controls.Add(this.VacancyFormButtonCancel);
            this.Controls.Add(this.VacancyFormButtonOK);
            this.Controls.Add(this.VacancyFormTextBoxCode);
            this.Controls.Add(this.VacancyFormLabelCode);
            this.Name = "VacancyForm";
            this.Text = "VacancyForm";
            this.Load += new System.EventHandler(this.VacancyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VacancyFormLabelCode;
        private System.Windows.Forms.TextBox VacancyFormTextBoxCode;
        private System.Windows.Forms.Button VacancyFormButtonOK;
        private System.Windows.Forms.Button VacancyFormButtonCancel;
        private System.Windows.Forms.Label VacancyFormLabelWorkCategory;
        private System.Windows.Forms.ComboBox VacancyFormComboBoxWorkCategory;
        private CPDBDataSet cPDBDataSet;
        private System.Windows.Forms.BindingSource workCategoriesBindingSource;
        private CPDBDataSetTableAdapters.WorkCategoriesTableAdapter workCategoriesTableAdapter;
        private System.Windows.Forms.Label VacancyFormLabelPosition;
        private System.Windows.Forms.TextBox VacancyFormTextBoxPosition;
        private System.Windows.Forms.Label VacancyFormLabelSalary;
        private System.Windows.Forms.TextBox VacancyFormTextBoxSalary;
    }
}