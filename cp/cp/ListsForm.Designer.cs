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
            this.ListsFormTabControl = new System.Windows.Forms.TabControl();
            this.ListsFormTabControlUsersPage = new System.Windows.Forms.TabPage();
            this.ListsFormTabControlEmployersPage = new System.Windows.Forms.TabPage();
            this.ListsFormTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListsFormTabControl
            // 
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
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListsFormTabControl);
            this.Name = "ListsForm";
            this.Text = "ListsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListsForm_FormClosed);
            this.Load += new System.EventHandler(this.ListsForm_Load);
            this.ListsFormTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ListsFormTabControl;
        private System.Windows.Forms.TabPage ListsFormTabControlUsersPage;
        private System.Windows.Forms.TabPage ListsFormTabControlEmployersPage;
    }
}