﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
        private CPDBDataSet.VacanciesRow _vacanciesRow;
        private CPDBDataSet.JobSeekersRow _jobSeekersRow;
        private CPDBDataSet.DealsRow _dealsRow;
        private CPDBDataSetTableAdapters.UsersTableAdapter _usersTableAdapter;
        private CPDBDataSetTableAdapters.RolesTableAdapter _rolesTableAdapter;
        private CPDBDataSetTableAdapters.WorkCategoriesTableAdapter _workCategoriesTableAdapter;
        private CPDBDataSetTableAdapters.EmployersTableAdapter _employersTableAdapter;
        private CPDBDataSetTableAdapters.VacanciesTableAdapter _vacanciesTableAdapter;
        private CPDBDataSetTableAdapters.JobSeekersTableAdapter _jobSeekerTableAdapter;
        private CPDBDataSetTableAdapters.DealsTableAdapter _dealsTableAdapter;
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
            _vacanciesTableAdapter = new CPDBDataSetTableAdapters.VacanciesTableAdapter();
            _vacanciesTableAdapter.ClearBeforeFill = true;
            _jobSeekerTableAdapter = new CPDBDataSetTableAdapters.JobSeekersTableAdapter();
            _jobSeekerTableAdapter.ClearBeforeFill = true;
            _dealsTableAdapter = new CPDBDataSetTableAdapters.DealsTableAdapter();
            _dealsTableAdapter.ClearBeforeFill = true;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
            ListsFormToolStripComboBoxStatus.SelectedIndex = 0;
        }

        #region ListsForm events
        private void ListsForm_Load(object sender, EventArgs e)
        {
            ConfigureInterfaceTabs();
            ConfigureInterfaceButtons();
            ConfigureMenuItems();
        }

        private void ListsFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl se = (TabControl)sender;
            if (se.SelectedTab != null)
            {
                ConfigureInterfaceButtons();
                UpdateStatusSelector();
                UpdateLists();
            }
        }

        private void ListsFormToolStripComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageVacancies")
                this.vVacanciesListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vVacanciesList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageJobSeekers")
                this.vJobSeekersListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vJobSeekersList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
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
            if ((_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit)
            {
                ListsFormEmployersDataGridView.AllowUserToAddRows = true;
                this.ListsFormEmployersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormEmployersDataGridView_CellDoubleClick);
                this.ListsFormEmployersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormEmployersDataGridView_KeyDown);
                _employersTableAdapter.Fill(this.cPDBDataSet.Employers);
            }
            if ((_accessRights & AccessRights.EmployersAudit) == AccessRights.EmployersAudit)
            {
                ListsFormEmployersDataGridView.Columns["датаИзмененияDataGridViewTextBoxColumn1"].Visible = true;
                ListsFormEmployersDataGridView.Columns["пользовательDataGridViewTextBoxColumn1"].Visible = true;
            }
            #endregion Employers

            #region Vacancies
            if ((_accessRights & AccessRights.VacanciesView) == AccessRights.VacanciesView ||
                (_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit ||
                (_accessRights & AccessRights.VacanciesAudit) == AccessRights.VacanciesAudit)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageVacancies);
                this.vVacanciesListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vVacanciesList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
            }
            if ((_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit)
            {
                ListsFormVacanciesDataGridView.AllowUserToAddRows = true;
                this.ListsFormVacanciesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormVacanciesDataGridView_CellDoubleClick);
                this.ListsFormVacanciesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormVacanciesDataGridView_KeyDown);
                _vacanciesTableAdapter.Fill(this.cPDBDataSet.Vacancies);
            }
            if ((_accessRights & AccessRights.VacanciesAudit) == AccessRights.VacanciesAudit)
            {
                ListsFormVacanciesDataGridView.Columns["датаИзмененияDataGridViewTextBoxColumn2"].Visible = true;
                ListsFormVacanciesDataGridView.Columns["пользовательDataGridViewTextBoxColumn2"].Visible = true;
            }
            #endregion Vacancies

            #region JobSeekers
            if ((_accessRights & AccessRights.JobSeekersView) == AccessRights.JobSeekersView ||
                (_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit ||
                (_accessRights & AccessRights.JobSeekersAudit) == AccessRights.JobSeekersAudit)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageJobSeekers);
                this.vJobSeekersListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vJobSeekersList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
            }
            if((_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit)
            {
                ListsFormJobSeekersDataGridView.AllowUserToAddRows = true;
                this.ListsFormJobSeekersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormJobSeekersDataGridView_CellDoubleClick);
                this.ListsFormJobSeekersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormJobSeekersDataGridView_KeyDown);
                _jobSeekerTableAdapter.Fill(this.cPDBDataSet.JobSeekers);
            }
            if ((_accessRights & AccessRights.JobSeekersAudit) == AccessRights.JobSeekersAudit)
            {
                ListsFormJobSeekersDataGridView.Columns["датаИзмененияDataGridViewTextBoxColumn3"].Visible = true;
                ListsFormJobSeekersDataGridView.Columns["пользовательDataGridViewTextBoxColumn3"].Visible = true;
            }
            #endregion JobSeekers

            #region Deals
            if ((_accessRights & AccessRights.DealsView) == AccessRights.DealsView ||
                (_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit ||
                (_accessRights & AccessRights.DealsAudit) == AccessRights.DealsAudit)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageDeals);
                this.vDealsListTableAdapter.FillOrderByCode(this.cPDBDataSet.vDealsList);
            }
            if ((_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit)
            {
                ListsFormDealsDataGridView.AllowUserToAddRows = true;
                this.ListsFormDealsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListsFormDealsDataGridView_CellDoubleClick);
                this.ListsFormDealsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListsFormDealsDataGridView_KeyDown);
                _dealsTableAdapter.Fill(this.cPDBDataSet.Deals);
            }
            if ((_accessRights & AccessRights.DealsAudit) == AccessRights.DealsAudit)
            {
                ListsFormDealsDataGridView.Columns["датаИзмененияDataGridViewTextBoxColumn4"].Visible = true;
                ListsFormDealsDataGridView.Columns["пользовательDataGridViewTextBoxColumn4"].Visible = true;
            }
            #endregion Deals
        }

        private void ConfigureInterfaceButtons()
        {
            if ( ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers" && (_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles" && (_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories" && (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageEmployers" && (_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageVacancies" && (_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageJobSeekers" && (_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit ||
                 ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageDeals" && (_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit)
            {
                ListsFormToolStripButtonNew.Visible = true;
                ListsFormToolStripButtonEdit.Visible = true;
                ListsFormToolStripButtonDelete.Visible = true;
                ListsFormToolStripSeparator1.Visible = true;
            }
            else
            {
                ListsFormToolStripButtonNew.Visible = false;
                ListsFormToolStripButtonEdit.Visible = false;
                ListsFormToolStripButtonDelete.Visible = false;
                ListsFormToolStripSeparator1.Visible = false;
            }
        }

        private void ConfigureMenuItems()
        {
            if ((_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit ||
                (_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit ||
                (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit ||
                (_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit ||
                (_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit ||
                (_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit ||
                (_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit)
                ListsFormToolStripMenuItemCreate.Visible = true;

            if ((_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit)
                ListsFormToolStripMenuItemCreateUser.Visible = true;
            if ((_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit)
                ListsFormToolStripMenuItemCreateRole.Visible = true;
            if ((_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit)
                ListsFormToolStripMenuItemCreateWorkCategory.Visible = true;
            if ((_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit)
                ListsFormToolStripMenuItemCreateEmployer.Visible = true;
            if ((_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit)
                ListsFormToolStripMenuItemCreateVacancy.Visible = true;
            if ((_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit)
                ListsFormToolStripMenuItemCreateJobSeeker.Visible = true;
            if ((_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit)
                ListsFormToolStripMenuItemCreateDeal.Visible = true;

            if ((_accessRights & AccessRights.UsersView) == AccessRights.UsersView ||
                (_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit ||
                (_accessRights & AccessRights.RolesView) == AccessRights.RolesView ||
                (_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit ||
                (_accessRights & AccessRights.WorkCategoriesView) == AccessRights.WorkCategoriesView ||
                (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit ||
                (_accessRights & AccessRights.WorkCategoriesAudit) == AccessRights.WorkCategoriesAudit ||
                (_accessRights & AccessRights.EmployersView) == AccessRights.EmployersView ||
                (_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit ||
                (_accessRights & AccessRights.EmployersAudit) == AccessRights.EmployersAudit ||
                (_accessRights & AccessRights.VacanciesView) == AccessRights.VacanciesView ||
                (_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit ||
                (_accessRights & AccessRights.VacanciesAudit) == AccessRights.VacanciesAudit ||
                (_accessRights & AccessRights.JobSeekersView) == AccessRights.JobSeekersView ||
                (_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit ||
                (_accessRights & AccessRights.JobSeekersAudit) == AccessRights.JobSeekersAudit ||
                (_accessRights & AccessRights.DealsView) == AccessRights.DealsView ||
                (_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit ||
                (_accessRights & AccessRights.DealsAudit) == AccessRights.DealsAudit)
                ListsFormToolStripMenuItemMove.Visible = true;

            if ((_accessRights & AccessRights.UsersView) == AccessRights.UsersView ||
                (_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit)
                ListsFormToolStripMenuItemMoveToUsers.Visible = true;

            if ((_accessRights & AccessRights.RolesView) == AccessRights.RolesView ||
                (_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit)
                ListsFormToolStripMenuItemMoveToRoles.Visible = true;

            if ((_accessRights & AccessRights.WorkCategoriesView) == AccessRights.WorkCategoriesView ||
                (_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit ||
                (_accessRights & AccessRights.WorkCategoriesAudit) == AccessRights.WorkCategoriesAudit)
                ListsFormToolStripMenuItemMoveToWorkCategories.Visible = true;

            if ((_accessRights & AccessRights.EmployersView) == AccessRights.EmployersView ||
                (_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit ||
                (_accessRights & AccessRights.EmployersAudit) == AccessRights.EmployersAudit)
                ListsFormToolStripMenuItemMoveToEmployers.Visible = true;

            if ((_accessRights & AccessRights.VacanciesView) == AccessRights.VacanciesView ||
                (_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit ||
                (_accessRights & AccessRights.VacanciesAudit) == AccessRights.VacanciesAudit)
                ListsFormToolStripMenuItemMoveToVacancies.Visible = true;

            if ((_accessRights & AccessRights.JobSeekersView) == AccessRights.JobSeekersView ||
                (_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit ||
                (_accessRights & AccessRights.JobSeekersAudit) == AccessRights.JobSeekersAudit)
                ListsFormToolStripMenuItemMoveToJobSeekers.Visible = true;

            if ((_accessRights & AccessRights.DealsView) == AccessRights.DealsView ||
                (_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit ||
                (_accessRights & AccessRights.DealsAudit) == AccessRights.DealsAudit)
                ListsFormToolStripMenuItemMoveToDeals.Visible = true;
        }

        private void UpdateLists()
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                this.vRolesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vRolesList);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories")
                this.vWorkCategoriesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vWorkCategoriesList);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageEmployers")
                this.vEmployersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vEmployersList);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageVacancies")
                this.vVacanciesListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vVacanciesList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageJobSeekers")
                this.vJobSeekersListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vJobSeekersList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
            else if (ListsFormTabControl.SelectedTab.Name == "LIstsFormTabControlPageDeals")
                this.vDealsListTableAdapter.FillOrderByCode(this.cPDBDataSet.vDealsList);
        }

        private void UpdateStatusSelector()
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageVacancies" ||
                ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageJobSeekers")
            {
                ListsFormToolStripComboBoxStatus.SelectedIndex = 0;
                ListsFormToolStripComboBoxStatus.Visible = true;
            }
            else
                ListsFormToolStripComboBoxStatus.Visible = false;
        }
        
        private void UpdateFocus(DataGridView dataGridView, int code)
        {
            if (code == 0)
                foreach (DataGridViewRow row in dataGridView.Rows)
                    if (row.Cells[0].Value != null && (int)row.Cells[0].Value > code)
                        code = (int)row.Cells[0].Value;

            foreach (DataGridViewRow row in dataGridView.Rows)
                if (row.Cells[0].Value != null && (int)row.Cells[0].Value == code)
                {
                    dataGridView.CurrentCell = row.Cells[0];
                    break;
                }
        }
        #endregion Configuration methods

        #region User methods
        private void EditUser(bool newUserControl)
        {
            int rowCode = 0;

            if (newUserControl || ListsFormUsersDataGridView.CurrentRow.Index >= ListsFormUsersDataGridView.Rows.Count - 1)
                _usersRow = this.cPDBDataSet.Users.NewUsersRow();
            else
            {
                rowCode = (int)ListsFormUsersDataGridView.CurrentRow.Cells[0].Value;
                _usersRow = this.cPDBDataSet.Users.FindByCode(rowCode);
            }

            UserForm userForm = new UserForm(_usersRow, _userCode);
            DialogResult userFormDialogResult = userForm.ShowDialog();
            if (userFormDialogResult == DialogResult.OK)
            {
                this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
                _usersTableAdapter.Fill(this.cPDBDataSet.Users);
                UpdateFocus(ListsFormUsersDataGridView, rowCode);
            }

            userForm.Dispose();
        }

        private void DeleteUser()
        {
            int rowIndex = ListsFormUsersDataGridView.CurrentRow.Index;
            if (rowIndex < ListsFormUsersDataGridView.Rows.Count - 1)
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
                            ListsFormUsersDataGridView.CurrentCell = ListsFormUsersDataGridView.Rows[rowIndex].Cells[0];
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
            int rowCode = 0;

            if (newRoleControl || ListsFormRolesDataGridView.CurrentRow.Index >= ListsFormRolesDataGridView.RowCount - 1)
                _rolesRow = this.cPDBDataSet.Roles.NewRolesRow();
            else
            {
                rowCode = (int)ListsFormRolesDataGridView.CurrentRow.Cells[0].Value;
                _rolesRow = this.cPDBDataSet.Roles.FindByCode(rowCode);
            }

            RoleForm roleForm = new RoleForm(_rolesRow, _userCode, _userRole);
            DialogResult roleFormDialogResult = roleForm.ShowDialog();
            if (roleFormDialogResult == DialogResult.OK)
            {
                this.vRolesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vRolesList);
                _rolesTableAdapter.Fill(this.cPDBDataSet.Roles);
                UpdateFocus(ListsFormRolesDataGridView, rowCode);
            }
            roleForm.Dispose();
        }

        private void DeleteRole()
        {
            int rowIndex = ListsFormRolesDataGridView.CurrentRow.Index;
            if (rowIndex < ListsFormRolesDataGridView.Rows.Count - 1)
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
                            ListsFormRolesDataGridView.CurrentCell = ListsFormRolesDataGridView.Rows[rowIndex].Cells[0];
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
            int rowCode = 0;

            if (newWorkCategoryControl || ListsFormWorkCategoriesDataGridView.CurrentRow.Index >= ListsFormWorkCategoriesDataGridView.RowCount - 1)
                _workCategoriesRow = this.cPDBDataSet.WorkCategories.NewWorkCategoriesRow();
            else
            {
                rowCode = (int)ListsFormWorkCategoriesDataGridView.CurrentRow.Cells[0].Value;
                _workCategoriesRow = this.cPDBDataSet.WorkCategories.FindByCode(rowCode);
            }


            WorkCategoryForm workCategoryForm = new WorkCategoryForm(_workCategoriesRow, _userCode);
            DialogResult workCategoryFormDialogResult = workCategoryForm.ShowDialog();
            if (workCategoryFormDialogResult == DialogResult.OK)
            {
                this.vWorkCategoriesListTableAdapter.FillOrderByCode(this.cPDBDataSet.vWorkCategoriesList);
                _workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);
                UpdateFocus(ListsFormWorkCategoriesDataGridView, rowCode);
            }
            workCategoryForm.Dispose();
        }

        private void DeleteWorkCategory()
        {
            int rowIndex = ListsFormWorkCategoriesDataGridView.CurrentRow.Index;
            if (rowIndex < ListsFormWorkCategoriesDataGridView.RowCount - 1)
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
                        //ListsFormWorkCategoriesDataGridView.Rows[rowIndex].Selected = true;
                        ListsFormWorkCategoriesDataGridView.CurrentCell = ListsFormWorkCategoriesDataGridView.Rows[rowIndex].Cells[0];
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

        #region Employers methods
        private void EditEmployer(bool newEmployerControl)
        {
            int rowCode = 0;

            if (newEmployerControl || ListsFormEmployersDataGridView.CurrentRow.Index >= ListsFormEmployersDataGridView.RowCount - 1)
                _employersRow = this.cPDBDataSet.Employers.NewEmployersRow();
            else
            {
                rowCode = (int)ListsFormEmployersDataGridView.CurrentRow.Cells[0].Value;
                _employersRow = this.cPDBDataSet.Employers.FindByCode(rowCode);
            }

            EmployerForm employerForm = new EmployerForm(_employersRow, _userCode);
            DialogResult employerFormDialogResult = employerForm.ShowDialog();
            if (employerFormDialogResult == DialogResult.OK)
            {
                this.vEmployersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vEmployersList);
                _employersTableAdapter.Fill(this.cPDBDataSet.Employers);
                UpdateFocus(ListsFormEmployersDataGridView, rowCode);
            }
            employerForm.Dispose();
        }

        private void DeleteEmployer()
        {
            int rowIndex = ListsFormEmployersDataGridView.CurrentRow.Index;
            if (rowIndex < ListsFormEmployersDataGridView.RowCount - 1)
            {
                _employersRow = this.cPDBDataSet.Employers.FindByCode((int)ListsFormEmployersDataGridView.CurrentRow.Cells[0].Value);
                DialogResult deleteEmployerDialogResult = MessageBox.Show($"Удалить работодателя: {_employersRow.Name}?", "Удаление работодателя", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteEmployerDialogResult == DialogResult.OK)
                {
                    try
                    {
                        _queriesTableAdapter.pDeleteEmployer(Code: _employersRow.Code);
                        this.vEmployersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vEmployersList);
                        _employersTableAdapter.Fill(this.cPDBDataSet.Employers);
                        ListsFormEmployersDataGridView.CurrentCell = ListsFormEmployersDataGridView.Rows[rowIndex].Cells[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Удаление работодателя \"{_employersRow.Name}\" невозможно.\n\n{ex.Message}", "Ошибка удаления работодателя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion Employers methods

        #region Employers events
        private void ListsFormEmployersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditEmployer(newEmployerControl: false);
        }

        private void ListsFormEmployersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;
            
            if (e.KeyCode == Keys.Insert)
                EditEmployer(newEmployerControl: true);
            else if (e.KeyCode == Keys.Enter)
                EditEmployer(newEmployerControl: false);
            else if (e.KeyCode == Keys.Delete)
                DeleteEmployer();
        }
        #endregion Employers events

        #region Vacancies methods
        private void EditVacancy(bool newVacancyControl)
        {
            int rowCode = 0;

            if (newVacancyControl || ListsFormVacanciesDataGridView.CurrentRow.Index >= ListsFormVacanciesDataGridView.RowCount - 1)
                _vacanciesRow = this.cPDBDataSet.Vacancies.NewVacanciesRow();
            else
            {
                rowCode = (int)ListsFormVacanciesDataGridView.CurrentRow.Cells[0].Value;
                _vacanciesRow = this.cPDBDataSet.Vacancies.FindByCode(rowCode);
            }

            VacancyForm vacancyForm = new VacancyForm(_vacanciesRow, _userCode);
            DialogResult vacancyFormDialogResult = vacancyForm.ShowDialog();
            if (vacancyFormDialogResult == DialogResult.OK)
            {
                if (rowCode == 0 && ListsFormToolStripComboBoxStatus.SelectedIndex == 1)
                    ListsFormToolStripComboBoxStatus.SelectedIndex = 0;

                this.vVacanciesListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vVacanciesList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
                _vacanciesTableAdapter.Fill(this.cPDBDataSet.Vacancies);
                UpdateFocus(ListsFormVacanciesDataGridView, rowCode);
            }
            vacancyForm.Dispose();
        }

        private void DeleteVacancy()
        {
            int rowIndex = ListsFormVacanciesDataGridView.CurrentRow.Index;
            if (rowIndex < ListsFormVacanciesDataGridView.RowCount - 1)
            {
                _vacanciesRow = this.cPDBDataSet.Vacancies.FindByCode((int)ListsFormVacanciesDataGridView.CurrentRow.Cells[0].Value);
                DialogResult deleteVacancyDialogResult = MessageBox.Show($"Удалить вакансию: {_vacanciesRow.Position}?", "Удаление вакансии", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteVacancyDialogResult == DialogResult.OK)
                {
                    try
                    {
                        _queriesTableAdapter.pDeleteVacancy(Code: _vacanciesRow.Code);
                        this.vVacanciesListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vVacanciesList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
                        _vacanciesTableAdapter.Fill(this.cPDBDataSet.Vacancies);
                        ListsFormVacanciesDataGridView.CurrentCell = ListsFormVacanciesDataGridView.Rows[rowIndex].Cells[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Удаление вакансии \"{_vacanciesRow.Position}\" невозможно.\n\n{ex.Message}", "Ошибка удаления вакансии", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion Vacancies methods

        #region Vacancies events
        private void ListsFormVacanciesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditVacancy(newVacancyControl: false);
        }

        private void ListsFormVacanciesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Insert)
                EditVacancy(newVacancyControl: true);
            else if (e.KeyCode == Keys.Enter)
                EditVacancy(newVacancyControl: false);
            else if (e.KeyCode == Keys.Delete)
                DeleteVacancy();
        }
        #endregion Vacancies events

        #region JobSeekers methods
        private void EditJobSeeker(bool newJobSeekerControl)
        {
            int rowCode = 0;

            if (newJobSeekerControl || ListsFormJobSeekersDataGridView.CurrentRow.Index >= ListsFormJobSeekersDataGridView.RowCount - 1)
                _jobSeekersRow = this.cPDBDataSet.JobSeekers.NewJobSeekersRow();
            else
            {
                rowCode = (int)ListsFormJobSeekersDataGridView.CurrentRow.Cells[0].Value;
                _jobSeekersRow = this.cPDBDataSet.JobSeekers.FindByCode(rowCode);
            }

            JobSeekerForm jobSeekerForm = new JobSeekerForm(_jobSeekersRow, _userCode);
            DialogResult jobSeekerFormDialogResult = jobSeekerForm.ShowDialog();
            if (jobSeekerFormDialogResult == DialogResult.OK)
            {
                if (rowCode == 0 && ListsFormToolStripComboBoxStatus.SelectedIndex == 1)
                    ListsFormToolStripComboBoxStatus.SelectedIndex = 0;

                this.vJobSeekersListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vJobSeekersList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
                _jobSeekerTableAdapter.Fill(this.cPDBDataSet.JobSeekers);
                UpdateFocus(ListsFormJobSeekersDataGridView, rowCode);
            }
            jobSeekerForm.Dispose();
        }

        private void DeleteJobSeeker()
        {
            int rowIndex = ListsFormJobSeekersDataGridView.CurrentRow.Index;
            if (rowIndex < ListsFormJobSeekersDataGridView.RowCount - 1)
            {
                string jobSeekerName;
                _jobSeekersRow = this.cPDBDataSet.JobSeekers.FindByCode((int)ListsFormJobSeekersDataGridView.CurrentRow.Cells[0].Value);
                jobSeekerName = $"{_jobSeekersRow.LastName} {_jobSeekersRow.FirstName[0]}.";
                if (!_jobSeekersRow.IsMiddleNameNull())
                    jobSeekerName += $" {_jobSeekersRow.MiddleName[0]}.";

                DialogResult deleteJobSeekerDialogResult = MessageBox.Show($"Удалить соискателя: {jobSeekerName} ?", "Удаление соискателя", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteJobSeekerDialogResult == DialogResult.OK)
                {
                    try
                    {
                        _queriesTableAdapter.pDeleteJobSeeker(Code: _jobSeekersRow.Code);
                        this.vJobSeekersListTableAdapter.FillWithStatusOrderByCode(this.cPDBDataSet.vJobSeekersList, ((StatusSelector)ListsFormToolStripComboBoxStatus.SelectedIndex).ToString());
                        _jobSeekerTableAdapter.Fill(this.cPDBDataSet.JobSeekers);
                        ListsFormJobSeekersDataGridView.CurrentCell = ListsFormJobSeekersDataGridView.Rows[rowIndex].Cells[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Удаление соискателя {jobSeekerName} невозможно.\n\n{ex.Message}", "Ошибка удаления соискателя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion JobSeekers methods

        #region JobSeekers events
        private void ListsFormJobSeekersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditJobSeeker(newJobSeekerControl: false);
        }

        private void ListsFormJobSeekersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Insert)
                EditJobSeeker(newJobSeekerControl: true);
            else if (e.KeyCode == Keys.Enter)
                EditJobSeeker(newJobSeekerControl: false);
            else if (e.KeyCode == Keys.Delete)
                DeleteJobSeeker();
        }
        #endregion JobSeekers events

        #region Deals methods
        private void EditDeal(bool newDealControl)
        {
            int rowCode = 0;

            if (newDealControl || ListsFormDealsDataGridView.CurrentRow.Index >= ListsFormDealsDataGridView.RowCount - 1)
                _dealsRow = this.cPDBDataSet.Deals.NewDealsRow();
            else
            {
                rowCode = (int)ListsFormDealsDataGridView.CurrentRow.Cells[0].Value;
                _dealsRow = this.cPDBDataSet.Deals.FindByCode(rowCode);
            }

            DealForm dealForm = new DealForm(_dealsRow, _userCode);
            DialogResult dealFormDialogResult = dealForm.ShowDialog();
            if (dealFormDialogResult == DialogResult.OK)
            {
                this.vDealsListTableAdapter.FillOrderByCode(this.cPDBDataSet.vDealsList);
                _dealsTableAdapter.Fill(this.cPDBDataSet.Deals);
                UpdateFocus(ListsFormDealsDataGridView, rowCode);
            }
            dealForm.Dispose();
        }

        private void DeleteDeal()
        {
            int rowIndex = ListsFormDealsDataGridView.CurrentRow.Index;
            if (rowIndex < ListsFormDealsDataGridView.RowCount - 1)
            {
                _dealsRow = this.cPDBDataSet.Deals.FindByCode((int)ListsFormDealsDataGridView.CurrentRow.Cells[0].Value);
                DialogResult deleteDealDialogResult = MessageBox.Show($"Удалить сделку №{_dealsRow.Code}?", "Удаление сделки", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteDealDialogResult == DialogResult.OK)
                {
                    try
                    {
                        _queriesTableAdapter.pDeleteDeal(Code: _dealsRow.Code);
                        this.vDealsListTableAdapter.FillOrderByCode(this.cPDBDataSet.vDealsList);
                        _dealsTableAdapter.Fill(this.cPDBDataSet.Deals);
                        ListsFormDealsDataGridView.CurrentCell = ListsFormDealsDataGridView.Rows[rowIndex].Cells[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Удаление сделки №{_dealsRow.Code} невозможно.\n\n{ex.Message}", "Ошибка удаления сделки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion Deals methods

        #region Deals events
        private void ListsFormDealsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDeal(newDealControl: false);
        }

        private void ListsFormDealsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Insert)
                EditDeal(newDealControl: true);
            else if (e.KeyCode == Keys.Enter)
                EditDeal(newDealControl: false);
            else if (e.KeyCode == Keys.Delete)
                DeleteDeal();
        }
        #endregion Deals events

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
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageEmployers")
                EditEmployer(newEmployerControl: true);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageVacancies")
                EditVacancy(newVacancyControl: true);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageJobSeekers")
                EditJobSeeker(newJobSeekerControl: true);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageDeals")
                EditDeal(newDealControl: true);
        }

        private void ListsFormToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                EditUser(newUserControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                EditRole(newRoleControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories")
                EditWorkCategory(newWorkCategoryControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageEmployers")
                EditEmployer(newEmployerControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageVacancies")
                EditVacancy(newVacancyControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageJobSeekers")
                EditJobSeeker(newJobSeekerControl: false);
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageDeals")
                EditDeal(newDealControl: false);
        }

        private void ListsFormToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageUsers")
                DeleteUser();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageRoles")
                DeleteRole();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageWorkCategories")
                DeleteWorkCategory();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageEmployers")
                DeleteEmployer();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageVacancies")
                DeleteVacancy();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageJobSeekers")
                DeleteJobSeeker();
            else if (ListsFormTabControl.SelectedTab.Name == "ListsFormTabControlPageDeals")
                DeleteDeal();
        }
        #endregion Buttons

        #region Menu
        private void ListsFormToolStripMenuItemCreateUser_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageUsers");
            EditUser(newUserControl: true);
        }

        private void ListsFormToolStripMenuItemCreateRole_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageRoles");
            EditRole(newRoleControl: true);
        }

        private void ListsFormToolStripMenuItemCreateWorkCategory_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageWorkCategories");
            EditWorkCategory(newWorkCategoryControl: true);
        }

        private void ListsFormToolStripMenuItemCreateEmployer_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageEmployers");
            EditEmployer(newEmployerControl: true);
        }

        private void ListsFormToolStripMenuItemCreateVacancy_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageVacancies");
            EditVacancy(newVacancyControl: true);
        }

        private void ListsFormToolStripMenuItemCreateJobSeeker_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageJobSeekers");
            EditJobSeeker(newJobSeekerControl: true);
        }

        private void ListsFormToolStripMenuItemCreateDeal_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageDeals");
            EditDeal(newDealControl: true);
        }

        private void ListsFormToolStripMenuItemMoveToUsers_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageUsers");
        }

        private void ListsFormToolStripMenuItemMoveToRoles_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageRoles");
        }

        private void ListsFormToolStripMenuItemMoveToWorkCategories_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageWorkCategories");
        }

        private void ListsFormToolStripMenuItemMoveToEmployers_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageEmployers");
        }

        private void ListsFormToolStripMenuItemMoveToVacancies_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageVacancies");
        }

        private void ListsFormToolStripMenuItemMoveToJobSeekers_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageJobSeekers");
        }

        private void ListsFormToolStripMenuItemMoveToDeals_Click(object sender, EventArgs e)
        {
            MoveToTab("ListsFormTabControlPageDeals");
        }

        private void ListsFormToolStripMenuItemEndSessionLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void ListsFormToolStripMenuItemEndSessionExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        
        private void MoveToTab(string tabName)
        {
            if (ListsFormTabControl.SelectedTab.Name != tabName)
                ListsFormTabControl.SelectTab(tabName);
        }
        #endregion Menu
    }
}
