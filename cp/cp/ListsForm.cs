using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private CPDBDataSet.UsersRow _usersRow;
        private CPDBDataSetTableAdapters.UsersTableAdapter _usersTableAdapter;
        private CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;

        public ListsForm(LoginForm loginForm, AccessRights accessRights, int userCode)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _accessRights = accessRights;
            _userCode = userCode;
            _usersTableAdapter = new CPDBDataSetTableAdapters.UsersTableAdapter();
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
            _usersTableAdapter.ClearBeforeFill = true;
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
                this.ListsFormUsersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormUsersDataGridView_KeyDown);
                _usersTableAdapter.Fill(this.cPDBDataSet.Users);
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
            if (e.CloseReason == CloseReason.UserClosing)
                Logout();
        }

        private void ListsForm_Load(object sender, EventArgs e)
        {
            ConfigureInterfaceTabs();
            ConfigureInterfaceButtons();
        }

        private void EditUser() => EditUser(newUserControl: false);

        private void EditUser(bool newUserControl)
        {
            if (newUserControl || ListsFormUsersDataGridView.CurrentRow.Index >= ListsFormUsersDataGridView.Rows.Count - 1)
                _usersRow = this.cPDBDataSet.Users.NewUsersRow();
            else
                _usersRow = this.cPDBDataSet.Users.FindByCode((int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value);

            UserForm userForm = new UserForm(_usersRow);
            DialogResult dialogResult = userForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
                _usersTableAdapter.Fill(this.cPDBDataSet.Users);
            }

            userForm.Dispose();
        }

        private void RemoveUser()
        {
            if (ListsFormUsersDataGridView.CurrentRow.Index < ListsFormUsersDataGridView.Rows.Count - 1)
            {
                if (_userCode == (int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value)
                    MessageBox.Show($"Невозможно удалить свою учетную запись: {ListsFormUsersDataGridView.CurrentRow.Cells[1].Value}", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    _usersRow = this.cPDBDataSet.Users.FindByCode((int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value);
                    DialogResult removeUserDialogResult = MessageBox.Show($"Удалить пользователя: {_usersRow.UserName}?", "Удаление пользователя", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    //MessageBox.Show($"{removeUserDialogResult}", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (removeUserDialogResult == DialogResult.OK)
                    {
                        int returnCode = _queriesTableAdapter.pDeleteUser(Code: _usersRow.Code);
                        //MessageBox.Show($"{returnCode}", "ReturnCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
                        _usersTableAdapter.Fill(this.cPDBDataSet.Users);
                    }
                }
            }

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
        }

        private void ListsFormUsersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditUser();
                e.SuppressKeyPress = true;
                //e.Handled= true;
            }
        }

        private void ListsFormToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                EditUser();
        }

        private void ListsFormToolStripButtonNew_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                EditUser(newUserControl: true);
        }

        private void ListsFormToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                RemoveUser();
        }
    }
}
