namespace cp
{
    partial class ListsForm
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
            this.ListsFormTabControl = new System.Windows.Forms.TabControl();
            this.ListsFormTabControlUsersPage = new System.Windows.Forms.TabPage();
            this.ListsFormTabControlEmployersPage = new System.Windows.Forms.TabPage();
            this.ListsFormUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.cPDBDataSet = new cp.CPDBDataSet();
            this.usersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersListTableAdapter = new cp.CPDBDataSetTableAdapters.UsersListTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.активенDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ListsFormTabControl.SuspendLayout();
            this.ListsFormTabControlUsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListsFormUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListsFormTabControl
            // 
            this.ListsFormTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListsFormTabControl.Controls.Add(this.ListsFormTabControlUsersPage);
            this.ListsFormTabControl.Controls.Add(this.ListsFormTabControlEmployersPage);
            this.ListsFormTabControl.Location = new System.Drawing.Point(13, 56);
            this.ListsFormTabControl.Name = "ListsFormTabControl";
            this.ListsFormTabControl.SelectedIndex = 0;
            this.ListsFormTabControl.Size = new System.Drawing.Size(775, 364);
            this.ListsFormTabControl.TabIndex = 0;
            // 
            // ListsFormTabControlUsersPage
            // 
            this.ListsFormTabControlUsersPage.Controls.Add(this.ListsFormUsersDataGridView);
            this.ListsFormTabControlUsersPage.Location = new System.Drawing.Point(4, 22);
            this.ListsFormTabControlUsersPage.Name = "ListsFormTabControlUsersPage";
            this.ListsFormTabControlUsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListsFormTabControlUsersPage.Size = new System.Drawing.Size(767, 338);
            this.ListsFormTabControlUsersPage.TabIndex = 0;
            this.ListsFormTabControlUsersPage.Text = "Пользователи";
            this.ListsFormTabControlUsersPage.UseVisualStyleBackColor = true;
            // 
            // ListsFormTabControlEmployersPage
            // 
            this.ListsFormTabControlEmployersPage.Location = new System.Drawing.Point(4, 22);
            this.ListsFormTabControlEmployersPage.Name = "ListsFormTabControlEmployersPage";
            this.ListsFormTabControlEmployersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListsFormTabControlEmployersPage.Size = new System.Drawing.Size(767, 338);
            this.ListsFormTabControlEmployersPage.TabIndex = 1;
            this.ListsFormTabControlEmployersPage.Text = "Работодатели";
            this.ListsFormTabControlEmployersPage.UseVisualStyleBackColor = true;
            // 
            // ListsFormUsersDataGridView
            // 
            this.ListsFormUsersDataGridView.AllowUserToAddRows = false;
            this.ListsFormUsersDataGridView.AllowUserToDeleteRows = false;
            this.ListsFormUsersDataGridView.AllowUserToResizeColumns = false;
            this.ListsFormUsersDataGridView.AllowUserToResizeRows = false;
            this.ListsFormUsersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListsFormUsersDataGridView.AutoGenerateColumns = false;
            this.ListsFormUsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListsFormUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListsFormUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяПользователяDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn,
            this.активенDataGridViewCheckBoxColumn});
            this.ListsFormUsersDataGridView.DataSource = this.usersListBindingSource;
            this.ListsFormUsersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ListsFormUsersDataGridView.MultiSelect = false;
            this.ListsFormUsersDataGridView.Name = "ListsFormUsersDataGridView";
            this.ListsFormUsersDataGridView.ReadOnly = true;
            this.ListsFormUsersDataGridView.RowHeadersVisible = false;
            this.ListsFormUsersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ListsFormUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListsFormUsersDataGridView.Size = new System.Drawing.Size(755, 326);
            this.ListsFormUsersDataGridView.TabIndex = 0;
            this.ListsFormUsersDataGridView.DoubleClick += new System.EventHandler(this.EditUser);
            // 
            // cPDBDataSet
            // 
            this.cPDBDataSet.DataSetName = "CPDBDataSet";
            this.cPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersListBindingSource
            // 
            this.usersListBindingSource.DataMember = "UsersList";
            this.usersListBindingSource.DataSource = this.cPDBDataSet;
            // 
            // usersListTableAdapter
            // 
            this.usersListTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.FillWeight = 10F;
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // имяПользователяDataGridViewTextBoxColumn
            // 
            this.имяПользователяDataGridViewTextBoxColumn.DataPropertyName = "Имя пользователя";
            this.имяПользователяDataGridViewTextBoxColumn.FillWeight = 50F;
            this.имяПользователяDataGridViewTextBoxColumn.HeaderText = "Имя пользователя";
            this.имяПользователяDataGridViewTextBoxColumn.Name = "имяПользователяDataGridViewTextBoxColumn";
            this.имяПользователяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяПользователяDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.FillWeight = 30F;
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            this.рольDataGridViewTextBoxColumn.ReadOnly = true;
            this.рольDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // активенDataGridViewCheckBoxColumn
            // 
            this.активенDataGridViewCheckBoxColumn.DataPropertyName = "Активен";
            this.активенDataGridViewCheckBoxColumn.FillWeight = 10F;
            this.активенDataGridViewCheckBoxColumn.HeaderText = "Активен";
            this.активенDataGridViewCheckBoxColumn.Name = "активенDataGridViewCheckBoxColumn";
            this.активенDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListsFormTabControl);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "ListsForm";
            this.Text = "ListsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListsForm_FormClosed);
            this.Load += new System.EventHandler(this.ListsForm_Load);
            this.ListsFormTabControl.ResumeLayout(false);
            this.ListsFormTabControlUsersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListsFormUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ListsFormTabControl;
        private System.Windows.Forms.TabPage ListsFormTabControlUsersPage;
        private System.Windows.Forms.TabPage ListsFormTabControlEmployersPage;
        private System.Windows.Forms.DataGridView ListsFormUsersDataGridView;
        private CPDBDataSet cPDBDataSet;
        private System.Windows.Forms.BindingSource usersListBindingSource;
        private CPDBDataSetTableAdapters.UsersListTableAdapter usersListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяПользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn активенDataGridViewCheckBoxColumn;
    }
}