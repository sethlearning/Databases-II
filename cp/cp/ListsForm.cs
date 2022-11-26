using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cp
{
    public partial class ListsForm : Form
    {
        private LoginForm _loginForm;
        private AccessRights _accessRights;
        private int _userCode;

        public ListsForm(LoginForm loginForm, AccessRights accessRights, int userCode)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _accessRights = accessRights;
            _userCode = userCode;
            //MessageBox.Show($"{_userCode}", "UserCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConfigureInterfaceTabs()
        {
            ListsFormTabControl.TabPages.Clear();

            // Users
            if ((_accessRights & AccessRights.UsersView) == AccessRights.UsersView)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageUsers);
                this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
            }
            if ((_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit)
            {
                ListsFormUsersDataGridView.AllowUserToAddRows = true;
                this.ListsFormUsersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormUsersDataGridView_CellDoubleClick);
                CPDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new CPDBDataSetTableAdapters.UsersTableAdapter();
                usersTableAdapter.ClearBeforeFill = true;
                usersTableAdapter.Fill(this.cPDBDataSet.Users);
            }

            // WorkCategories
            if ((_accessRights & AccessRights.WorkCategoriesView) == AccessRights.WorkCategoriesView)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageWorkCategories);
            }
            //if ((_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit)

            // Employers
            if ((_accessRights & AccessRights.EmployersView) == AccessRights.EmployersView)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageEmployers);
            }
            //if ((_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit)
        }

        private void ConfigureInterfaceButtons()
        {
            if ( ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers" && (_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories" && (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageEmployers" && (_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit )
            {
                ListsFormToolStripButtonNew.Visible = true;
                ListsFormToolStripButtonEdit.Visible = true;
                ListsFormToolStripButtonDelete.Visible = true;
            }

            else
            {
                ListsFormToolStripButtonNew.Visible = false;
                ListsFormToolStripButtonEdit.Visible = false;
                ListsFormToolStripButtonDelete.Visible = false;
            }
        }

        private void ListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }

        private void ListsForm_Load(object sender, EventArgs e)
        {
            ConfigureInterfaceTabs();
            ConfigureInterfaceButtons();
        }

        private void EditUser()
        {
            //CPDBDataSet.UsersRow usersRow = new CPDBDataSet.UsersRow(new DataRowBuilder());
            CPDBDataSet.UsersRow usersRow =  this.cPDBDataSet.Users.NewUsersRow();
            //MessageBox.Show($"RowIndex: {ListsFormUsersDataGridView.CurrentRow.Index} UserCode: {ListsFormUsersDataGridView.CurrentRow.Cells[0].Value}", "CellContentDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ListsFormUsersDataGridView.CurrentRow.Index < ListsFormUsersDataGridView.Rows.Count - 1)
                usersRow = this.cPDBDataSet.Users.FindByCode((int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value);

                UserForm userForm = new UserForm(usersRow);
                userForm.ShowDialog();
                //MessageBox.Show($"DialogResult: {userForm.DialogResult}", "UserForm DialogResult", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ListsFormToolStripButtonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            _loginForm.Show();
            this.Dispose();
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void ListsFormToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ListsFormUsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditUser();
            //MessageBox.Show($"RowIndex: {e.RowIndex} UserCode: {ListsFormUsersDataGridView.Rows[e.RowIndex].Cells[0].Value}", "CellContentDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListsFormToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                EditUser();
        }
    }
}
