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
            this.components = new System.ComponentModel.Container();
            this.JobSeekerFormLabelCode = new System.Windows.Forms.Label();
            this.JobSeekerFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.JobSeekerFormButtonOK = new System.Windows.Forms.Button();
            this.JobSeekerFormButtonCancel = new System.Windows.Forms.Button();
            this.JobSeekerFormLabelLastName = new System.Windows.Forms.Label();
            this.JobSeekerFormTextBoxLastName = new System.Windows.Forms.TextBox();
            this.JobSeekerFormLabelFirstName = new System.Windows.Forms.Label();
            this.JobSeekerFormTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.JobSeekerFormLabelMiddleName = new System.Windows.Forms.Label();
            this.JobSeekerFormTextBoxMiddleName = new System.Windows.Forms.TextBox();
            this.JobSeekerLabelWorkCategory = new System.Windows.Forms.Label();
            this.JobSeekerFormComboBoxWorkCategory = new System.Windows.Forms.ComboBox();
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.workCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workCategoriesTableAdapter = new cp.CPDBDataSetTableAdapters.WorkCategoriesTableAdapter();
            this.JobSeekerFormLabelQualification = new System.Windows.Forms.Label();
            this.JobSeekerFormTextBoxQualification = new System.Windows.Forms.TextBox();
            this.JobSeekerFormLabelDesiredSalary = new System.Windows.Forms.Label();
            this.JobSeekerFormNumericUpDownDesiredSalary = new System.Windows.Forms.NumericUpDown();
            this.JobSeekerFormLabelNotes = new System.Windows.Forms.Label();
            this.JobSeekerFormTextBoxNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobSeekerFormNumericUpDownDesiredSalary)).BeginInit();
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
            this.JobSeekerFormButtonOK.Location = new System.Drawing.Point(240, 383);
            this.JobSeekerFormButtonOK.Name = "JobSeekerFormButtonOK";
            this.JobSeekerFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.JobSeekerFormButtonOK.TabIndex = 2;
            this.JobSeekerFormButtonOK.Text = "OK";
            this.JobSeekerFormButtonOK.UseVisualStyleBackColor = true;
            // 
            // JobSeekerFormButtonCancel
            // 
            this.JobSeekerFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.JobSeekerFormButtonCancel.Location = new System.Drawing.Point(340, 383);
            this.JobSeekerFormButtonCancel.Name = "JobSeekerFormButtonCancel";
            this.JobSeekerFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.JobSeekerFormButtonCancel.TabIndex = 3;
            this.JobSeekerFormButtonCancel.Text = "Cancel";
            this.JobSeekerFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // JobSeekerFormLabelLastName
            // 
            this.JobSeekerFormLabelLastName.AutoSize = true;
            this.JobSeekerFormLabelLastName.Location = new System.Drawing.Point(20, 65);
            this.JobSeekerFormLabelLastName.Name = "JobSeekerFormLabelLastName";
            this.JobSeekerFormLabelLastName.Size = new System.Drawing.Size(59, 13);
            this.JobSeekerFormLabelLastName.TabIndex = 4;
            this.JobSeekerFormLabelLastName.Text = "Фамилия:";
            // 
            // JobSeekerFormTextBoxLastName
            // 
            this.JobSeekerFormTextBoxLastName.Location = new System.Drawing.Point(140, 62);
            this.JobSeekerFormTextBoxLastName.Name = "JobSeekerFormTextBoxLastName";
            this.JobSeekerFormTextBoxLastName.Size = new System.Drawing.Size(275, 20);
            this.JobSeekerFormTextBoxLastName.TabIndex = 5;
            // 
            // JobSeekerFormLabelFirstName
            // 
            this.JobSeekerFormLabelFirstName.AutoSize = true;
            this.JobSeekerFormLabelFirstName.Location = new System.Drawing.Point(20, 110);
            this.JobSeekerFormLabelFirstName.Name = "JobSeekerFormLabelFirstName";
            this.JobSeekerFormLabelFirstName.Size = new System.Drawing.Size(32, 13);
            this.JobSeekerFormLabelFirstName.TabIndex = 6;
            this.JobSeekerFormLabelFirstName.Text = "Имя:";
            // 
            // JobSeekerFormTextBoxFirstName
            // 
            this.JobSeekerFormTextBoxFirstName.Location = new System.Drawing.Point(140, 107);
            this.JobSeekerFormTextBoxFirstName.Name = "JobSeekerFormTextBoxFirstName";
            this.JobSeekerFormTextBoxFirstName.Size = new System.Drawing.Size(275, 20);
            this.JobSeekerFormTextBoxFirstName.TabIndex = 7;
            // 
            // JobSeekerFormLabelMiddleName
            // 
            this.JobSeekerFormLabelMiddleName.AutoSize = true;
            this.JobSeekerFormLabelMiddleName.Location = new System.Drawing.Point(20, 155);
            this.JobSeekerFormLabelMiddleName.Name = "JobSeekerFormLabelMiddleName";
            this.JobSeekerFormLabelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.JobSeekerFormLabelMiddleName.TabIndex = 8;
            this.JobSeekerFormLabelMiddleName.Text = "Отчество:";
            // 
            // JobSeekerFormTextBoxMiddleName
            // 
            this.JobSeekerFormTextBoxMiddleName.Location = new System.Drawing.Point(140, 152);
            this.JobSeekerFormTextBoxMiddleName.Name = "JobSeekerFormTextBoxMiddleName";
            this.JobSeekerFormTextBoxMiddleName.Size = new System.Drawing.Size(275, 20);
            this.JobSeekerFormTextBoxMiddleName.TabIndex = 9;
            // 
            // JobSeekerLabelWorkCategory
            // 
            this.JobSeekerLabelWorkCategory.AutoSize = true;
            this.JobSeekerLabelWorkCategory.Location = new System.Drawing.Point(20, 200);
            this.JobSeekerLabelWorkCategory.Name = "JobSeekerLabelWorkCategory";
            this.JobSeekerLabelWorkCategory.Size = new System.Drawing.Size(102, 13);
            this.JobSeekerLabelWorkCategory.TabIndex = 10;
            this.JobSeekerLabelWorkCategory.Text = "Вид деятельности:";
            // 
            // JobSeekerFormComboBoxWorkCategory
            // 
            this.JobSeekerFormComboBoxWorkCategory.DataSource = this.workCategoriesBindingSource;
            this.JobSeekerFormComboBoxWorkCategory.DisplayMember = "Name";
            this.JobSeekerFormComboBoxWorkCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobSeekerFormComboBoxWorkCategory.FormattingEnabled = true;
            this.JobSeekerFormComboBoxWorkCategory.Location = new System.Drawing.Point(140, 197);
            this.JobSeekerFormComboBoxWorkCategory.Name = "JobSeekerFormComboBoxWorkCategory";
            this.JobSeekerFormComboBoxWorkCategory.Size = new System.Drawing.Size(275, 21);
            this.JobSeekerFormComboBoxWorkCategory.TabIndex = 11;
            this.JobSeekerFormComboBoxWorkCategory.ValueMember = "Code";
            // 
            // cPDBDataSet
            // 
            this.cPDBDataSet.DataSetName = "CPDBDataSet";
            this.cPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workCategoriesBindingSource
            // 
            this.workCategoriesBindingSource.DataMember = "WorkCategories";
            this.workCategoriesBindingSource.DataSource = this.cPDBDataSet;
            // 
            // workCategoriesTableAdapter
            // 
            this.workCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // JobSeekerFormLabelQualification
            // 
            this.JobSeekerFormLabelQualification.AutoSize = true;
            this.JobSeekerFormLabelQualification.Location = new System.Drawing.Point(20, 245);
            this.JobSeekerFormLabelQualification.Name = "JobSeekerFormLabelQualification";
            this.JobSeekerFormLabelQualification.Size = new System.Drawing.Size(85, 13);
            this.JobSeekerFormLabelQualification.TabIndex = 12;
            this.JobSeekerFormLabelQualification.Text = "Квалификация:";
            // 
            // JobSeekerFormTextBoxQualification
            // 
            this.JobSeekerFormTextBoxQualification.Location = new System.Drawing.Point(140, 242);
            this.JobSeekerFormTextBoxQualification.Name = "JobSeekerFormTextBoxQualification";
            this.JobSeekerFormTextBoxQualification.Size = new System.Drawing.Size(275, 20);
            this.JobSeekerFormTextBoxQualification.TabIndex = 13;
            // 
            // JobSeekerFormLabelDesiredSalary
            // 
            this.JobSeekerFormLabelDesiredSalary.AutoSize = true;
            this.JobSeekerFormLabelDesiredSalary.Location = new System.Drawing.Point(20, 290);
            this.JobSeekerFormLabelDesiredSalary.Name = "JobSeekerFormLabelDesiredSalary";
            this.JobSeekerFormLabelDesiredSalary.Size = new System.Drawing.Size(64, 13);
            this.JobSeekerFormLabelDesiredSalary.TabIndex = 14;
            this.JobSeekerFormLabelDesiredSalary.Text = "Зар. плата:";
            // 
            // JobSeekerFormNumericUpDownDesiredSalary
            // 
            this.JobSeekerFormNumericUpDownDesiredSalary.DecimalPlaces = 2;
            this.JobSeekerFormNumericUpDownDesiredSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.JobSeekerFormNumericUpDownDesiredSalary.Location = new System.Drawing.Point(140, 287);
            this.JobSeekerFormNumericUpDownDesiredSalary.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.JobSeekerFormNumericUpDownDesiredSalary.Name = "JobSeekerFormNumericUpDownDesiredSalary";
            this.JobSeekerFormNumericUpDownDesiredSalary.Size = new System.Drawing.Size(275, 20);
            this.JobSeekerFormNumericUpDownDesiredSalary.TabIndex = 15;
            this.JobSeekerFormNumericUpDownDesiredSalary.ThousandsSeparator = true;
            // 
            // JobSeekerFormLabelNotes
            // 
            this.JobSeekerFormLabelNotes.AutoSize = true;
            this.JobSeekerFormLabelNotes.Location = new System.Drawing.Point(20, 335);
            this.JobSeekerFormLabelNotes.Name = "JobSeekerFormLabelNotes";
            this.JobSeekerFormLabelNotes.Size = new System.Drawing.Size(79, 13);
            this.JobSeekerFormLabelNotes.TabIndex = 16;
            this.JobSeekerFormLabelNotes.Text = "Иные данные:";
            // 
            // JobSeekerFormTextBoxNotes
            // 
            this.JobSeekerFormTextBoxNotes.Location = new System.Drawing.Point(140, 332);
            this.JobSeekerFormTextBoxNotes.Name = "JobSeekerFormTextBoxNotes";
            this.JobSeekerFormTextBoxNotes.Size = new System.Drawing.Size(275, 20);
            this.JobSeekerFormTextBoxNotes.TabIndex = 17;
            // 
            // JobSeekerForm
            // 
            this.AcceptButton = this.JobSeekerFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.JobSeekerFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(444, 427);
            this.Controls.Add(this.JobSeekerFormTextBoxNotes);
            this.Controls.Add(this.JobSeekerFormLabelNotes);
            this.Controls.Add(this.JobSeekerFormNumericUpDownDesiredSalary);
            this.Controls.Add(this.JobSeekerFormLabelDesiredSalary);
            this.Controls.Add(this.JobSeekerFormTextBoxQualification);
            this.Controls.Add(this.JobSeekerFormLabelQualification);
            this.Controls.Add(this.JobSeekerFormComboBoxWorkCategory);
            this.Controls.Add(this.JobSeekerLabelWorkCategory);
            this.Controls.Add(this.JobSeekerFormTextBoxMiddleName);
            this.Controls.Add(this.JobSeekerFormLabelMiddleName);
            this.Controls.Add(this.JobSeekerFormTextBoxFirstName);
            this.Controls.Add(this.JobSeekerFormLabelFirstName);
            this.Controls.Add(this.JobSeekerFormTextBoxLastName);
            this.Controls.Add(this.JobSeekerFormLabelLastName);
            this.Controls.Add(this.JobSeekerFormButtonCancel);
            this.Controls.Add(this.JobSeekerFormButtonOK);
            this.Controls.Add(this.JobSeekerFormTextBoxCode);
            this.Controls.Add(this.JobSeekerFormLabelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JobSeekerForm";
            this.Text = "Соискатель";
            this.Load += new System.EventHandler(this.JobSeekerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobSeekerFormNumericUpDownDesiredSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JobSeekerFormLabelCode;
        private System.Windows.Forms.TextBox JobSeekerFormTextBoxCode;
        private System.Windows.Forms.Button JobSeekerFormButtonOK;
        private System.Windows.Forms.Button JobSeekerFormButtonCancel;
        private System.Windows.Forms.Label JobSeekerFormLabelLastName;
        private System.Windows.Forms.TextBox JobSeekerFormTextBoxLastName;
        private System.Windows.Forms.Label JobSeekerFormLabelFirstName;
        private System.Windows.Forms.TextBox JobSeekerFormTextBoxFirstName;
        private System.Windows.Forms.Label JobSeekerFormLabelMiddleName;
        private System.Windows.Forms.TextBox JobSeekerFormTextBoxMiddleName;
        private System.Windows.Forms.Label JobSeekerLabelWorkCategory;
        private System.Windows.Forms.ComboBox JobSeekerFormComboBoxWorkCategory;
        private CPDBDataSet cPDBDataSet;
        private System.Windows.Forms.BindingSource workCategoriesBindingSource;
        private CPDBDataSetTableAdapters.WorkCategoriesTableAdapter workCategoriesTableAdapter;
        private System.Windows.Forms.Label JobSeekerFormLabelQualification;
        private System.Windows.Forms.TextBox JobSeekerFormTextBoxQualification;
        private System.Windows.Forms.Label JobSeekerFormLabelDesiredSalary;
        private System.Windows.Forms.NumericUpDown JobSeekerFormNumericUpDownDesiredSalary;
        private System.Windows.Forms.Label JobSeekerFormLabelNotes;
        private System.Windows.Forms.TextBox JobSeekerFormTextBoxNotes;
    }
}