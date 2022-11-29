using Microsoft.Win32;
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
        private CPDBDataSet.WorkCategoriesRow _workCategoriesRow;
        private CPDBDataSet.EmployersRow _employersRow;
        private CPDBDataSetTableAdapters.UsersTableAdapter _usersTableAdapter;
        private CPDBDataSetTableAdapters.RolesTableAdapter _rolesTableAdapter;
        private CPDBDataSetTableAdapters.WorkCategoriesTableAdapter _workCategoriesTableAdapter;
        private CPDBDataSetTableAdapters.EmployersTableAdapter _employersTableAdapter;
        private CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;

        public ListsForm(LoginForm loginForm, AccessRights accessRights, int userCode, int userRole)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _accessRights = accessRights;
            _userCode = userCode;
            _userRole = userRole;
            _usersTableAdapter = new CPDBDataSetTableAdapters.UsersTableAdapter();
            _usersTableAdapter.ClearBeforeFill = true;
            _rolesTableAdapter = new CPDBDataSetTableAdapters.RolesTableAdapter();
            _rolesTableAdapter.ClearBeforeFill = true;
            _workCategoriesTableAdapter = new CPDBDataSetTableAdapters.WorkCategoriesTableAdapter();
            _workCategoriesTableAdapter.ClearBeforeFill = true;
            _employersTableAdapter = new CPDBDataSetTableAdapters.EmployersTableAdapter();
            _employersTableAdapter.ClearBeforeFill = true;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        #region ListsForm events
        private void ListsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPDBDataSet.vEmployersList' table. You can move, or remove it, as needed.
            //this.vEmployersListTableAdapter.Fill(this.cPDBDataSet.vEmployersList);
            ConfigureInterfaceTabs();
            ConfigureInterfaceButtons();
        }

        private void ListsFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl se = (TabControl)sender;
            if (se.SelectedTab != null)
            {
                ConfigureInterfaceButtons();
                UpdateLists();
            }
        }
        #endregion ListsForm events

        #region Configuration methods
        private void ConfigureInterfaceTabs()
        {
            ListsFormTabControl.TabPages.Clear();

            #region Users
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
            #endregion Users

            #region Roles
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
            #endregion Roles

            #region WorkCategories
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
                this.ListsFormWorkCategoriesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormWorkCategoriesDataGridView_CellDoubleClick);
                this.ListsFormWorkCategoriesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormWorkCategoriesDataGridView_KeyDown);
                _workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);
            }
            if ((_accessRights & AccessRights.WorkCategoriesAudit) == AccessRights.WorkCategoriesAudit)
            {
                ListsFormWorkCategoriesDataGridView.Columns["датаИзмененияDataGridViewTextBoxColumn"].Visible = true;
                ListsFormWorkCategoriesDataGridView.Columns["пользовательDataGridViewTextBoxColumn"].Visible = true;
            }
            #endregion WorkCategories

            #region Employers
            if ((_accessRights & AccessRights.EmployersView) == AccessRights.EmployersView ||
                (_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit ||
                (_accessRights & AccessRights.EmployersAudit) == AccessRights.EmployersAudit)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageEmployers);
                this.vEmployersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vEmployersList);
            }
            #endregion Employers
        }

        private void ConfigureInterfaceButtons()
        {
            if ( ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers" && (_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles" && (_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories" && (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageEmployers" && (_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories" && (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit)
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

        private void UpdateLists()
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                this.vRolesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vRolesList);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories")
                this.vWorkCategoriesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vWorkCategoriesList);
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

            RoleForm roleForm = new RoleForm(_rolesRow, _userCode, _userRole);
            DialogResult roleFormDialogResult = roleForm.ShowDialog();
            if (roleFormDialogResult == DialogResult.OK)
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

        #region WorkCategory methods
        private void EditWorkCategory(bool newWorkCategoryControl)
        {
            if (newWorkCategoryControl || ListsFormWorkCategoriesDataGridView.CurrentRow.Index >= ListsFormWorkCategoriesDataGridView.RowCount - 1)
                _workCategoriesRow = this.cPDBDataSet.WorkCategories.NewWorkCategoriesRow();
            else
                _workCategoriesRow = this.cPDBDataSet.WorkCategories.FindByCode((int)ListsFormWorkCategoriesDataGridView.CurrentRow.Cells[0].Value);

            WorkCategoryForm workCategoryForm = new WorkCategoryForm(_workCategoriesRow, _userCode);
            DialogResult workCategoryFormDialogResult = workCategoryForm.ShowDialog();
            if (workCategoryFormDialogResult == DialogResult.OK)
            {
                this.vWorkCategoriesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vWorkCategoriesList);
                _workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);
            }
            workCategoryForm.Dispose();
        }

        private void DeleteWorkCategory()
        {
            if (ListsFormWorkCategoriesDataGridView.CurrentRow.Index < ListsFormWorkCategoriesDataGridView.RowCount - 1)
            {
                _workCategoriesRow = this.cPDBDataSet.WorkCategories.FindByCode((int)ListsFormWorkCategoriesDataGridView.CurrentRow.Cells[0].Value);
                DialogResult deleteWorkCategoryDialogResult = MessageBox.Show($"Удалить категорию: {_workCategoriesRow.Name}?", "Удаление вида деятельности", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteWorkCategoryDialogResult == DialogResult.OK)
                {
                    try
                    {
                        _queriesTableAdapter.pDeleteWorkCategory(Code: _workCategoriesRow.Code);
                        this.vWorkCategoriesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vWorkCategoriesList);
                        _workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Удаление категории \"{_workCategoriesRow.Name}\" невозможно.\n\n{ex.Message}", "Ошибка удаления вида деятельности", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion WorkCategory methods

        #region WorkCategory events
        private void ListsFormWorkCategoriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditWorkCategory(newWorkCategoryControl: false);
        }

        private void ListsFormWorkCategoriesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Insert)
                EditWorkCategory(newWorkCategoryControl: true);
            else if (e.KeyCode == Keys.Enter)
                EditWorkCategory(newWorkCategoryControl: false);
            else if (e.KeyCode == Keys.Delete)
                DeleteWorkCategory();
        }
        #endregion WorkCategory events

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
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories")
                EditWorkCategory(newWorkCategoryControl: true);
        }

        private void ListsFormToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                EditUser(newUserControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                EditRole(newRoleControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories")
                EditWorkCategory(newWorkCategoryControl: false);
        }

        private void ListsFormToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                DeleteUser();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                DeleteRole();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories")
                DeleteWorkCategory();
        }
        #endregion Buttons
    }
}
