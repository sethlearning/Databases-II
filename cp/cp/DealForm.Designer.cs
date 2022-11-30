﻿namespace cp
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
            this.components = new System.ComponentModel.Container();
            this.DealFormLabelCode = new System.Windows.Forms.Label();
            this.DealFormTextBoxCode = new System.Windows.Forms.TextBox();
            this.DealFormButtonOK = new System.Windows.Forms.Button();
            this.DealFormButtonCancel = new System.Windows.Forms.Button();
            this.DealFormLabelVacancy = new System.Windows.Forms.Label();
            this.DealFormDataGridViewVacancy = new System.Windows.Forms.DataGridView();
            this.vVacanciesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.vVacanciesListTableAdapter = new cp.CPDBDataSetTableAdapters.vVacanciesListTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.работодательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видДеятельностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заработнаяПлатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзмененияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользовательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealFormButtonVacancyClear = new System.Windows.Forms.Button();
            this.DealFormButtonVacancySelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DealFormDataGridViewVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVacanciesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
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
            this.DealFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DealFormButtonCancel.Location = new System.Drawing.Point(340, 388);
            this.DealFormButtonCancel.Name = "DealFormButtonCancel";
            this.DealFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.DealFormButtonCancel.TabIndex = 3;
            this.DealFormButtonCancel.Text = "Cancel";
            this.DealFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // DealFormLabelVacancy
            // 
            this.DealFormLabelVacancy.AutoSize = true;
            this.DealFormLabelVacancy.Location = new System.Drawing.Point(20, 65);
            this.DealFormLabelVacancy.Name = "DealFormLabelVacancy";
            this.DealFormLabelVacancy.Size = new System.Drawing.Size(59, 13);
            this.DealFormLabelVacancy.TabIndex = 4;
            this.DealFormLabelVacancy.Text = "Вакансия:";
            // 
            // DealFormDataGridViewVacancy
            // 
            this.DealFormDataGridViewVacancy.AllowUserToAddRows = false;
            this.DealFormDataGridViewVacancy.AllowUserToDeleteRows = false;
            this.DealFormDataGridViewVacancy.AllowUserToResizeColumns = false;
            this.DealFormDataGridViewVacancy.AllowUserToResizeRows = false;
            this.DealFormDataGridViewVacancy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DealFormDataGridViewVacancy.AutoGenerateColumns = false;
            this.DealFormDataGridViewVacancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DealFormDataGridViewVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealFormDataGridViewVacancy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.работодательDataGridViewTextBoxColumn,
            this.видДеятельностиDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.заработнаяПлатаDataGridViewTextBoxColumn,
            this.датаИзмененияDataGridViewTextBoxColumn,
            this.пользовательDataGridViewTextBoxColumn});
            this.DealFormDataGridViewVacancy.DataSource = this.vVacanciesListBindingSource;
            this.DealFormDataGridViewVacancy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DealFormDataGridViewVacancy.Location = new System.Drawing.Point(140, 63);
            this.DealFormDataGridViewVacancy.MultiSelect = false;
            this.DealFormDataGridViewVacancy.Name = "DealFormDataGridViewVacancy";
            this.DealFormDataGridViewVacancy.ReadOnly = true;
            this.DealFormDataGridViewVacancy.RowHeadersVisible = false;
            this.DealFormDataGridViewVacancy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DealFormDataGridViewVacancy.Size = new System.Drawing.Size(730, 42);
            this.DealFormDataGridViewVacancy.StandardTab = true;
            this.DealFormDataGridViewVacancy.TabIndex = 5;
            // 
            // vVacanciesListBindingSource
            // 
            this.vVacanciesListBindingSource.DataMember = "vVacanciesList";
            this.vVacanciesListBindingSource.DataSource = this.cPDBDataSet;
            // 
            // cPDBDataSet
            // 
            this.cPDBDataSet.DataSetName = "CPDBDataSet";
            this.cPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVacanciesListTableAdapter
            // 
            this.vVacanciesListTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.FillWeight = 7F;
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // работодательDataGridViewTextBoxColumn
            // 
            this.работодательDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.работодательDataGridViewTextBoxColumn.DataPropertyName = "Работодатель";
            this.работодательDataGridViewTextBoxColumn.FillWeight = 20F;
            this.работодательDataGridViewTextBoxColumn.HeaderText = "Работодатель";
            this.работодательDataGridViewTextBoxColumn.Name = "работодательDataGridViewTextBoxColumn";
            this.работодательDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видДеятельностиDataGridViewTextBoxColumn
            // 
            this.видДеятельностиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.видДеятельностиDataGridViewTextBoxColumn.DataPropertyName = "Вид деятельности";
            this.видДеятельностиDataGridViewTextBoxColumn.FillWeight = 20F;
            this.видДеятельностиDataGridViewTextBoxColumn.HeaderText = "Вид деятельности";
            this.видДеятельностиDataGridViewTextBoxColumn.Name = "видДеятельностиDataGridViewTextBoxColumn";
            this.видДеятельностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.FillWeight = 20F;
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заработнаяПлатаDataGridViewTextBoxColumn
            // 
            this.заработнаяПлатаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.заработнаяПлатаDataGridViewTextBoxColumn.DataPropertyName = "Заработная плата";
            this.заработнаяПлатаDataGridViewTextBoxColumn.FillWeight = 20F;
            this.заработнаяПлатаDataGridViewTextBoxColumn.HeaderText = "Заработная плата";
            this.заработнаяПлатаDataGridViewTextBoxColumn.Name = "заработнаяПлатаDataGridViewTextBoxColumn";
            this.заработнаяПлатаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаИзмененияDataGridViewTextBoxColumn
            // 
            this.датаИзмененияDataGridViewTextBoxColumn.DataPropertyName = "Дата изменения";
            this.датаИзмененияDataGridViewTextBoxColumn.HeaderText = "Дата изменения";
            this.датаИзмененияDataGridViewTextBoxColumn.Name = "датаИзмененияDataGridViewTextBoxColumn";
            this.датаИзмененияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаИзмененияDataGridViewTextBoxColumn.Visible = false;
            // 
            // пользовательDataGridViewTextBoxColumn
            // 
            this.пользовательDataGridViewTextBoxColumn.DataPropertyName = "Пользователь";
            this.пользовательDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.пользовательDataGridViewTextBoxColumn.Name = "пользовательDataGridViewTextBoxColumn";
            this.пользовательDataGridViewTextBoxColumn.ReadOnly = true;
            this.пользовательDataGridViewTextBoxColumn.Visible = false;
            // 
            // DealFormButtonVacancyClear
            // 
            this.DealFormButtonVacancyClear.Location = new System.Drawing.Point(794, 112);
            this.DealFormButtonVacancyClear.Name = "DealFormButtonVacancyClear";
            this.DealFormButtonVacancyClear.Size = new System.Drawing.Size(75, 23);
            this.DealFormButtonVacancyClear.TabIndex = 6;
            this.DealFormButtonVacancyClear.Text = "Clear";
            this.DealFormButtonVacancyClear.UseVisualStyleBackColor = true;
            this.DealFormButtonVacancyClear.Click += new System.EventHandler(this.DealFormButtonVacancyClear_Click);
            // 
            // DealFormButtonVacancySelect
            // 
            this.DealFormButtonVacancySelect.Location = new System.Drawing.Point(699, 112);
            this.DealFormButtonVacancySelect.Name = "DealFormButtonVacancySelect";
            this.DealFormButtonVacancySelect.Size = new System.Drawing.Size(75, 23);
            this.DealFormButtonVacancySelect.TabIndex = 7;
            this.DealFormButtonVacancySelect.Text = "Select";
            this.DealFormButtonVacancySelect.UseVisualStyleBackColor = true;
            this.DealFormButtonVacancySelect.Click += new System.EventHandler(this.DealFormButtonVacancySelect_Click);
            // 
            // DealForm
            // 
            this.AcceptButton = this.DealFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DealFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.DealFormButtonVacancySelect);
            this.Controls.Add(this.DealFormButtonVacancyClear);
            this.Controls.Add(this.DealFormDataGridViewVacancy);
            this.Controls.Add(this.DealFormLabelVacancy);
            this.Controls.Add(this.DealFormButtonCancel);
            this.Controls.Add(this.DealFormButtonOK);
            this.Controls.Add(this.DealFormTextBoxCode);
            this.Controls.Add(this.DealFormLabelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DealForm";
            this.Text = "Сделка";
            this.Load += new System.EventHandler(this.DealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DealFormDataGridViewVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVacanciesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DealFormLabelCode;
        private System.Windows.Forms.TextBox DealFormTextBoxCode;
        private System.Windows.Forms.Button DealFormButtonOK;
        private System.Windows.Forms.Button DealFormButtonCancel;
        private System.Windows.Forms.Label DealFormLabelVacancy;
        private System.Windows.Forms.DataGridView DealFormDataGridViewVacancy;
        private CPDBDataSet cPDBDataSet;
        private System.Windows.Forms.BindingSource vVacanciesListBindingSource;
        private CPDBDataSetTableAdapters.vVacanciesListTableAdapter vVacanciesListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn работодательDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видДеятельностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заработнаяПлатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИзмененияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пользовательDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DealFormButtonVacancyClear;
        private System.Windows.Forms.Button DealFormButtonVacancySelect;
    }
}