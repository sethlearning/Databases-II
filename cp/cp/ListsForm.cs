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
        private int _userRole;
        private CPDBDataSet.UsersRow _usersRow;
        private CPDBDataSet.RolesRow _rolesRow;
        private CPDBDataSetTableAdapters.UsersTableAdapter _usersTableAdapter;
        private CPDBDataSetTableAdapters.RolesTableAdapter _rolesTableAdapter;
        private CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;

        public ListsForm(LoginForm loginForm, AccessRights accessRights, int userCode, int userRole)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _accessRights = accessRights;
            _userCode = userCode;
            _userRole = userRole;
            _usersTableAdapter = new CPDBDataSetTableAdapters.UsersTableAdapter();
            _rolesTableAdapter = new CPDBDataSetTableAdapters.RolesTableAdapter();
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
            _usersTableAdapter.ClearBeforeFill = true;
        }

        private void ConfigureInterfaceTabs()
        {
            ListsFormTabControl.TabPages.Clear();

            // Users
            if ((_accessRights & AccessRights.UsersView) == AccessRights.UsersView ||
                (_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit)
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

            // Roles
            if ((_accessRights & AccessRights.RolesView) == AccessRights.RolesView ||
                (_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageRoles);
                this.vRolesListTableAdapter.Fill(this.cPDBDataSet.vRolesList);
            }
            if ((_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit)
            {
                ListsFormRolesDataGridView.AllowUserToAddRows = true;
                this.ListsFormRolesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormRolesDataGridView_CellDoubleClick);
                this.ListsFormRolesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormRolesDataGridView_KeyDown);
                _rolesTableAdapter.Fill(this.cPDBDataSet.Roles);
            }

            // WorkCategories
            if ((_accessRights & AccessRights.WorkCategoriesView) == AccessRights.WorkCategoriesView)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageRoles);
            }
            //if ((_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit)

            // Employers
            if ((_accessRights & AccessRights.EmployersView) == AccessRights.EmployersView)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageWorkCategories);
            }
            //if ((_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit)
        }

        private void ConfigureInterfaceButtons()
        {
            if ( ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers" && (_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles" && (_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit ||
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
            // TODO: This line of code loads data into the 'cPDBDataSet.vRolesList' table. You can move, or remove it, as needed.
            //this.vRolesListTableAdapter.Fill(this.cPDBDataSet.vRolesList);
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

            UserForm userForm = new UserForm(_usersRow, _userCode);
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
                    MessageBox.Show($"Невозможно удалить собственную учетную запись: {ListsFormUsersDataGridView.CurrentRow.Cells[1].Value}", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    _usersRow = this.cPDBDataSet.Users.FindByCode((int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value);
                    DialogResult removeUserDialogResult = MessageBox.Show($"Удалить пользователя: {_usersRow.UserName}?", "Удаление пользователя", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (removeUserDialogResult == DialogResult.OK)
                    {
                        try
                        {
                            _queriesTableAdapter.pDeleteUser(Code: _usersRow.Code);
                            this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
                            _usersTableAdapter.Fill(this.cPDBDataSet.Users);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Удаление пользователя \"{_usersRow.UserName}\" невозможно.\n\n{ex.Message}", "Ошибка удаления пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void EditRole(bool newRoleControl)
        {
            if (newRoleControl || ListsFormRolesDataGridView.CurrentRow.Index >= ListsFormRolesDataGridView.RowCount - 1)
                _rolesRow = this.cPDBDataSet.Roles.NewRolesRow();
            else
                _rolesRow = this.cPDBDataSet.Roles.FindByCode((int)ListsFormRolesDataGridView.CurrentRow.Cells[0].Value);
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

        private void ListsFormRolesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListsFormRolesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
