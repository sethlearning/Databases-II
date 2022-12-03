namespace cp
{
    partial class DealJobSeekerSelectForm
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
            this.DealJobSeekerSelectFormDataGridView = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видДеятельностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квалификацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.желаемаяЗарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иныеДанныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзмененияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользовательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vJobSeekersWithFIOListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.DealJobSeekerSelectFormButtonOK = new System.Windows.Forms.Button();
            this.DealJobSeekerSelectFormButtonCancel = new System.Windows.Forms.Button();
            this.vJobSeekersWithFIOListTableAdapter = new cp.CPDBDataSetTableAdapters.vJobSeekersWithFIOListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DealJobSeekerSelectFormDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vJobSeekersWithFIOListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DealJobSeekerSelectFormDataGridView
            // 
            this.DealJobSeekerSelectFormDataGridView.AllowUserToAddRows = false;
            this.DealJobSeekerSelectFormDataGridView.AllowUserToDeleteRows = false;
            this.DealJobSeekerSelectFormDataGridView.AllowUserToResizeRows = false;
            this.DealJobSeekerSelectFormDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DealJobSeekerSelectFormDataGridView.AutoGenerateColumns = false;
            this.DealJobSeekerSelectFormDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DealJobSeekerSelectFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealJobSeekerSelectFormDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.видДеятельностиDataGridViewTextBoxColumn,
            this.квалификацияDataGridViewTextBoxColumn,
            this.желаемаяЗарплатаDataGridViewTextBoxColumn,
            this.иныеДанныеDataGridViewTextBoxColumn,
            this.датаИзмененияDataGridViewTextBoxColumn,
            this.пользовательDataGridViewTextBoxColumn});
            this.DealJobSeekerSelectFormDataGridView.DataSource = this.vJobSeekersWithFIOListBindingSource;
            this.DealJobSeekerSelectFormDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DealJobSeekerSelectFormDataGridView.Location = new System.Drawing.Point(5, 5);
            this.DealJobSeekerSelectFormDataGridView.MultiSelect = false;
            this.DealJobSeekerSelectFormDataGridView.Name = "DealJobSeekerSelectFormDataGridView";
            this.DealJobSeekerSelectFormDataGridView.ReadOnly = true;
            this.DealJobSeekerSelectFormDataGridView.RowHeadersVisible = false;
            this.DealJobSeekerSelectFormDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DealJobSeekerSelectFormDataGridView.Size = new System.Drawing.Size(791, 411);
            this.DealJobSeekerSelectFormDataGridView.StandardTab = true;
            this.DealJobSeekerSelectFormDataGridView.TabIndex = 0;
            this.DealJobSeekerSelectFormDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DealJobSeekerSelectFormDataGridView_CellDoubleClick);
            this.DealJobSeekerSelectFormDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DealJobSeekerSelectFormDataGridView_KeyDown);
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
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.FillWeight = 20F;
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
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
            // квалификацияDataGridViewTextBoxColumn
            // 
            this.квалификацияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.квалификацияDataGridViewTextBoxColumn.DataPropertyName = "Квалификация";
            this.квалификацияDataGridViewTextBoxColumn.FillWeight = 20F;
            this.квалификацияDataGridViewTextBoxColumn.HeaderText = "Квалификация";
            this.квалификацияDataGridViewTextBoxColumn.Name = "квалификацияDataGridViewTextBoxColumn";
            this.квалификацияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // желаемаяЗарплатаDataGridViewTextBoxColumn
            // 
            this.желаемаяЗарплатаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.желаемаяЗарплатаDataGridViewTextBoxColumn.DataPropertyName = "Желаемая зарплата";
            this.желаемаяЗарплатаDataGridViewTextBoxColumn.FillWeight = 20F;
            this.желаемаяЗарплатаDataGridViewTextBoxColumn.HeaderText = "Желаемая зарплата";
            this.желаемаяЗарплатаDataGridViewTextBoxColumn.Name = "желаемаяЗарплатаDataGridViewTextBoxColumn";
            this.желаемаяЗарплатаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // иныеДанныеDataGridViewTextBoxColumn
            // 
            this.иныеДанныеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.иныеДанныеDataGridViewTextBoxColumn.DataPropertyName = "Иные данные";
            this.иныеДанныеDataGridViewTextBoxColumn.FillWeight = 15F;
            this.иныеДанныеDataGridViewTextBoxColumn.HeaderText = "Иные данные";
            this.иныеДанныеDataGridViewTextBoxColumn.Name = "иныеДанныеDataGridViewTextBoxColumn";
            this.иныеДанныеDataGridViewTextBoxColumn.ReadOnly = true;
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
            // vJobSeekersWithFIOListBindingSource
            // 
            this.vJobSeekersWithFIOListBindingSource.DataMember = "vJobSeekersWithFIOList";
            this.vJobSeekersWithFIOListBindingSource.DataSource = this.cPDBDataSet;
            // 
            // cPDBDataSet
            // 
            this.cPDBDataSet.DataSetName = "CPDBDataSet";
            this.cPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DealJobSeekerSelectFormButtonOK
            // 
            this.DealJobSeekerSelectFormButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DealJobSeekerSelectFormButtonOK.Location = new System.Drawing.Point(615, 426);
            this.DealJobSeekerSelectFormButtonOK.Name = "DealJobSeekerSelectFormButtonOK";
            this.DealJobSeekerSelectFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this.DealJobSeekerSelectFormButtonOK.TabIndex = 1;
            this.DealJobSeekerSelectFormButtonOK.Text = "OK";
            this.DealJobSeekerSelectFormButtonOK.UseVisualStyleBackColor = true;
            this.DealJobSeekerSelectFormButtonOK.Click += new System.EventHandler(this.DealJobSeekerSelectFormButtonOK_Click);
            // 
            // DealJobSeekerSelectFormButtonCancel
            // 
            this.DealJobSeekerSelectFormButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DealJobSeekerSelectFormButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DealJobSeekerSelectFormButtonCancel.Location = new System.Drawing.Point(720, 426);
            this.DealJobSeekerSelectFormButtonCancel.Name = "DealJobSeekerSelectFormButtonCancel";
            this.DealJobSeekerSelectFormButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.DealJobSeekerSelectFormButtonCancel.TabIndex = 2;
            this.DealJobSeekerSelectFormButtonCancel.Text = "Cancel";
            this.DealJobSeekerSelectFormButtonCancel.UseVisualStyleBackColor = true;
            // 
            // vJobSeekersWithFIOListTableAdapter
            // 
            this.vJobSeekersWithFIOListTableAdapter.ClearBeforeFill = true;
            // 
            // DealJobSeekerSelectForm
            // 
            this.AcceptButton = this.DealJobSeekerSelectFormButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DealJobSeekerSelectFormButtonCancel;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.DealJobSeekerSelectFormButtonCancel);
            this.Controls.Add(this.DealJobSeekerSelectFormButtonOK);
            this.Controls.Add(this.DealJobSeekerSelectFormDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DealJobSeekerSelectForm";
            this.Text = "DealJobSeekerSelectForm";
            this.Load += new System.EventHandler(this.DealJobSeekerSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DealJobSeekerSelectFormDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vJobSeekersWithFIOListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DealJobSeekerSelectFormDataGridView;
        private System.Windows.Forms.Button DealJobSeekerSelectFormButtonOK;
        private System.Windows.Forms.Button DealJobSeekerSelectFormButtonCancel;
        private CPDBDataSet cPDBDataSet;
        private System.Windows.Forms.BindingSource vJobSeekersWithFIOListBindingSource;
        private CPDBDataSetTableAdapters.vJobSeekersWithFIOListTableAdapter vJobSeekersWithFIOListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видДеятельностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn квалификацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn желаемаяЗарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иныеДанныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИзмененияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пользовательDataGridViewTextBoxColumn;
    }
}