﻿using System;
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
        private CPDBDataSetTableAdapters.WorkCategoriesTableAdapter _workCategoriesTableAdapter;
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
            _workCategoriesTableAdapter = new CPDBDataSetTableAdapters.WorkCategoriesTableAdapter();
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
            _usersTableAdapter.ClearBeforeFill = true;
        }

        private void ListsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPDBDataSet.vWorkCategoriesList' table. You can move, or remove it, as needed.
            //this.vWorkCategoriesListTableAdapter.Fill(this.cPDBDataSet.vWorkCategoriesList);
            // TODO: This line of code loads data into the 'cPDBDataSet.vRolesList' table. You can move, or remove it, as needed.
            //this.vRolesListTableAdapter.Fill(this.cPDBDataSet.vRolesList);
            ConfigureInterfaceTabs();
            ConfigureInterfaceButtons();
        }

        #region Configuration methods
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
                this.vRolesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vRolesList);
            }
            if ((_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit)
            {
                ListsFormRolesDataGridView.AllowUserToAddRows = true;
                this.ListsFormRolesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormRolesDataGridView_CellDoubleClick);
                this.ListsFormRolesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormRolesDataGridView_KeyDown);
                _rolesTableAdapter.Fill(this.cPDBDataSet.Roles);
            }

            // WorkCategories
            if ((_accessRights & AccessRights.WorkCategoriesView) == AccessRights.WorkCategoriesView ||
                (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit ||
                (_accessRights & AccessRights.WorkCategoriesAudit) == AccessRights.WorkCategoriesAudit)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageWorkCategories);
                this.vWorkCategoriesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vWorkCategoriesList);
            }
            if ((_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit)
            {
                ListsFormWorkCategoriesDataGridView.AllowUserToAddRows = true;
                _workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);
            }
            if ((_accessRights & AccessRights.WorkCategoriesAudit) == AccessRights.WorkCategoriesAudit)
            {
                ListsFormWorkCategoriesDataGridView.Columns["датаИзмененияDataGridViewTextBoxColumn"].Visible = true;
                ListsFormWorkCategoriesDataGridView.Columns["пользовательDataGridViewTextBoxColumn"].Visible = true;
            }

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
        #endregion Configuration methods

        #region User methods
        private void EditUser(bool newUserControl)
        {
            if (newUserControl || ListsFormUsersDataGridView.CurrentRow.Index >= ListsFormUsersDataGridView.Rows.Count - 1)
                _usersRow = this.cPDBDataSet.Users.NewUsersRow();
            else
                _usersRow = this.cPDBDataSet.Users.FindByCode((int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value);

            UserForm userForm = new UserForm(_usersRow, _userCode);
            DialogResult userFormDialogResult = userForm.ShowDialog();
            if (userFormDialogResult == DialogResult.OK)
            {
                this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
                _usersTableAdapter.Fill(this.cPDBDataSet.Users);
            }

            userForm.Dispose();
        }

        private void DeleteUser()
        {
            if (ListsFormUsersDataGridView.CurrentRow.Index < ListsFormUsersDataGridView.Rows.Count - 1)
            {
                if (_userCode == (int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value)
                    MessageBox.Show($"Невозможно удалить собственную учетную запись: {ListsFormUsersDataGridView.CurrentRow.Cells[1].Value}", "Удаление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    _usersRow = this.cPDBDataSet.Users.FindByCode((int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value);
                    DialogResult deleteUserDialogResult = MessageBox.Show($"Удалить пользователя: {_usersRow.UserName}?", "Удаление пользователя", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (deleteUserDialogResult == DialogResult.OK)
                    {
                        try
                        {
                            _queriesTableAdapter.pDeleteUser(Code: _usersRow.Code);
                            this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
                            _usersTableAdapter.Fill(this.cPDBDataSet.Users);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Удаление пользователя \"{_usersRow.UserName}\" невозможно.\n\n{ex.Message}", "Ошибка удаления пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion User methods

        #region User events
        private void ListsFormUsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditUser(newUserControl: false);
        }

        private void ListsFormUsersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                //e.Handled = true;
            }
            if (e.KeyCode == Keys.Insert)
                EditUser(newUserControl: true);
            else if (e.KeyCode == Keys.Enter)
                EditUser(newUserControl: false);
            else if (e.KeyCode == Keys.Delete)
                DeleteUser();
        }
        #endregion User events

        #region Role methods
        private void EditRole(bool newRoleControl)
        {
            if (newRoleControl || ListsFormRolesDataGridView.CurrentRow.Index >= ListsFormRolesDataGridView.RowCount - 1)
                _rolesRow = this.cPDBDataSet.Roles.NewRolesRow();
            else
                _rolesRow = this.cPDBDataSet.Roles.FindByCode((int)ListsFormRolesDataGridView.CurrentRow.Cells[0].Value);

            RoleForm roleForm= new RoleForm(_rolesRow, _userCode, _userRole);
            DialogResult roleFormDialogResult = roleForm.ShowDialog();
            if (roleFormDialogResult== DialogResult.OK)
            {
                this.vRolesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vRolesList);
                _rolesTableAdapter.Fill(this.cPDBDataSet.Roles);
            }
            roleForm.Dispose();
        }

        private void DeleteRole()
        {
            if (ListsFormRolesDataGridView.CurrentRow.Index < ListsFormRolesDataGridView.Rows.Count - 1)
            {
                if(_userRole == (int)ListsFormRolesDataGridView.CurrentRow.Cells[0].Value)
                    MessageBox.Show($"Невозможно удалить собственную роль: {ListsFormRolesDataGridView.CurrentRow.Cells[1].Value}", "Удаление роли", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    _rolesRow = this.cPDBDataSet.Roles.FindByCode((int)ListsFormRolesDataGridView.CurrentRow.Cells[0].Value);
                    DialogResult deleteRoleDialogResult = MessageBox.Show($"Удалить роль: {_rolesRow.Name}?", "Удаление роли", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (deleteRoleDialogResult == DialogResult.OK)
                    {
                        try
                        {
                            _queriesTableAdapter.pDeleteRole(Code: _rolesRow.Code);
                            this.vRolesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vRolesList);
                            _rolesTableAdapter.Fill(this.cPDBDataSet.Roles);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Удаление роли \"{_rolesRow.Name}\" невозможно.\n\n{ex.Message}", "Ошибка удаления роли", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion Role methods

        #region Role events
        private void ListsFormRolesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRole(newRoleControl: false);
        }

        private void ListsFormRolesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Insert)
                EditRole(newRoleControl: true);
            else if (e.KeyCode == Keys.Enter)
                EditRole(newRoleControl: false);
            else if (e.KeyCode == Keys.Delete)
                DeleteRole();

        }
        #endregion Role events

        #region Logout
        private void ListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Logout();
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
        #endregion Logout

        #region Exit
        private void Exit()
        {
            Application.Exit();
        }

        private void ListsFormToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Exit();
        }
        #endregion Exit

        #region Buttons
        private void ListsFormToolStripButtonNew_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                EditUser(newUserControl: true);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                EditRole(newRoleControl: true);
        }

        private void ListsFormToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                EditUser(newUserControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                EditRole(newRoleControl: false);
        }

        private void ListsFormToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                DeleteUser();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                DeleteRole();
        }
        #endregion Buttons
    }
}
