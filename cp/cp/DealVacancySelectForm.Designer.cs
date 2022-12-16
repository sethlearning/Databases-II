namespace cp
{
    partial class DealVacancySelectForm
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
            this.DealVacancySelectFormDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.работодательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видДеятельностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заработнаяПлатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзмененияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользовательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vVacanciesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.vVacanciesListTableAdapter = new cp.CPDBDataSetTableAdapters.vVacanciesListTableAdapter();
            this.DealVacancySelectFormButtonOK = new System.Windows.Forms.Button();
            this.DealVacancySelectFormButtonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DealVacancySelectFormDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVacanciesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DealVacancySelectFormDataGridView
            // 
            this.DealVacancySelectFormDataGridView.AllowUserToAddRows = false;
            this.DealVacancySelectFormDataGridView.AllowUserToDeleteRows = false;
            this.DealVacancySelectFormDataGridView.AllowUserToResizeRows = false;
            this.DealVacancySelectFormDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DealVacancySelectFormDataGridView.AutoGenerateColumns = false;
            this.DealVacancySelectFormDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DealVacancySelectFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealVacancySelectFormDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.работодательDataGridViewTextBoxColumn,
            this.видДеятельностиDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.заработнаяПлатаDataGridViewTextBoxColumn,
            this.датаИзмененияDataGridViewTextBoxColumn,
            this.пользовательDataGridViewTextBoxColumn});
            this.DealVacancySelectFormDataGridView.DataSource = this.vVacanciesListBindingSource;
            this.DealVacancySelectFormDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DealVacancySelectFormDataGridView.Location = new System.Drawing.Point(5, 5);
            this.DealVacancySelectFormDataGridView.MultiSelect = false;
            this.DealVacancySelectFormDataGridView.Name = "DealVacancySelectFormDataGridView";
            this.DealVacancySelectFormDataGridView.ReadOnly = true;
            this.DealVacancySelectFormDataGridView.RowHeadersVisible = false;
            this.DealVacancySelectFormDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DealVacancySelectFormDataGridView.Size = new System.Drawing.Size(791, 411);
            this.DealVacancySelectFormDataGridView.StandardTab = true;
            this.DealVacancySelectFormDataGridView.TabIndex = 0;
            this.DealVacancySelectFormDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DealVacancySelectFormDataGridView_CellDoubleClick);
            this.DealVacancySelectFormDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DealVacancySelectFormDataGridView_KeyDown);
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
            // DealVacancySelectFormButtonOK
            // 
            this.DealVacancySelectFormButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DealVacancySelectFormButtonOK.Location = new System.Drawing.Point(615, 426);
            this.DealVacancySelectFormButtonOK.Name = "DealVacancySelectFormButtonOK";
            this.DealVacancySelectFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.DealVacancySelectFormButtonOK.TabIndex = 1;
            this.DealVacancySelectFormButtonOK.Text = "OK";
            this.DealVacancySelectFormButtonOK.UseVisualStyleBackColor = true;
            this.DealVacancySelectFormButtonOK.Click += new System.EventHandler(this.DealVacancySelectFormButtonOK_Click);
            // 
            // DealVacancySelectFormButtonCancel
            // 
            this.DealVacancySelectFormButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DealVacancySelectFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DealVacancySelectFormButtonCancel.Location = new System.Drawing.Point(720, 426);
            this.DealVacancySelectFormButtonCancel.Name = "DealVacancySelectFormButtonCancel";
            this.DealVacancySelectFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.DealVacancySelectFormButtonCancel.TabIndex = 2;
            this.DealVacancySelectFormButtonCancel.Text = "Cancel";
            this.DealVacancySelectFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // DealVacancySelectForm
            // 
            this.AcceptButton = this.DealVacancySelectFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DealVacancySelectFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.DealVacancySelectFormButtonCancel);
            this.Controls.Add(this.DealVacancySelectFormButtonOK);
            this.Controls.Add(this.DealVacancySelectFormDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DealVacancySelectForm";
            this.Text = "Выбор вакансии";
            this.Load += new System.EventHandler(this.DealVacancySelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DealVacancySelectFormDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVacanciesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DealVacancySelectFormDataGridView;
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
        private System.Windows.Forms.Button DealVacancySelectFormButtonOK;
        private System.Windows.Forms.Button DealVacancySelectFormButtonCancel;
    }
}