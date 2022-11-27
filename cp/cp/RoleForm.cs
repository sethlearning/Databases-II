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
    public partial class RoleForm : Form
    {
        private CPDBDataSet.RolesRow _rolesRow;
        private int _userCode;
        private int _userRole;
        private bool _newRole = false;
        private bool _isValid;
        private AccessRights _accessRights;
        private int _accessRightsValue;
        CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;

        public RoleForm(CPDBDataSet.RolesRow rolesRow, int userCode, int userRole)
        {
            InitializeComponent();
            _rolesRow = rolesRow;
            _userCode = userCode;
            _userRole = userRole;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            if (_rolesRow.Code < 0)
            {
                _newRole = true;
                RoleFormTextBoxCode.Text = "New Role";
            }
            else
            {
                RoleFormTextBoxCode.Text = _rolesRow.Code.ToString();
                RoleFormTextBoxName.Text = _rolesRow.Name;
                _accessRights = (AccessRights)_rolesRow.AccessControl;

                if (_rolesRow.Code == 1 || _rolesRow.Code == _userCode)
                {
                    RoleFormCheckBoxUsersView.Enabled = false;
                    RoleFormCheckBoxUsersEdit.Enabled = false;
                    RoleFormCheckBoxRolesView.Enabled = false;
                    RoleFormCheckBoxRolesEdit.Enabled = false;
                }

                FillAccessRights();
            }

        }

        private void FillAccessRights()
        {
            // Users
            if ((_accessRights & AccessRights.UsersView) == AccessRights.UsersView)
                RoleFormCheckBoxUsersView.Checked = true;
            else
                RoleFormCheckBoxUsersView.Checked = false;

            if ((_accessRights & AccessRights.UsersEdit) == AccessRights.UsersEdit)
                RoleFormCheckBoxUsersEdit.Checked = true;
            else
                RoleFormCheckBoxUsersEdit.Checked = false;

            // Roles
            if ((_accessRights & AccessRights.RolesView) == AccessRights.RolesView)
                RoleFormCheckBoxRolesView.Checked = true;
            else
                RoleFormCheckBoxRolesView.Checked = false;

            if ((_accessRights & AccessRights.RolesEdit) == AccessRights.RolesEdit)
                RoleFormCheckBoxRolesEdit.Checked = true;
            else
                RoleFormCheckBoxRolesEdit.Checked = false;

            // WorkCategories
            if ((_accessRights & AccessRights.WorkCategoriesView) == AccessRights.WorkCategoriesView)
                RoleFormCheckBoxWorkCategoriesView.Checked = true;
            else
                RoleFormCheckBoxWorkCategoriesView.Checked = false;

            if ((_accessRights & AccessRights.WorkCategoriesEdit) == AccessRights.WorkCategoriesEdit)
                RoleFormCheckBoxWorkCategoriesEdit.Checked = true;
            else
                RoleFormCheckBoxWorkCategoriesEdit.Checked = false;

            if ((_accessRights & AccessRights.WorkCategoriesAudit) == AccessRights.WorkCategoriesAudit)
                RoleFormCheckBoxWorkCategoriesAudit.Checked = true;
            else
                RoleFormCheckBoxWorkCategoriesAudit.Checked = false;

            // Employers
            if ((_accessRights & AccessRights.EmployersView) == AccessRights.EmployersView)
                RoleFormCheckBoxEmployersView.Checked = true;
            else
                RoleFormCheckBoxEmployersView.Checked = false;

            if ((_accessRights & AccessRights.EmployersEdit) == AccessRights.EmployersEdit)
                RoleFormCheckBoxEmployersEdit.Checked = true;
            else
                RoleFormCheckBoxEmployersEdit.Checked = false;

            if ((_accessRights & AccessRights.EmployersAudit) == AccessRights.EmployersAudit)
                RoleFormCheckBoxEmployersAudit.Checked = true;
            else
                RoleFormCheckBoxEmployersAudit.Checked = false;

            // Vacancies
            if ((_accessRights & AccessRights.VacanciesView) == AccessRights.VacanciesView)
                RoleFormCheckBoxVacanciesView.Checked = true;
            else
                RoleFormCheckBoxVacanciesView.Checked = false;

            if ((_accessRights & AccessRights.VacanciesEdit) == AccessRights.VacanciesEdit)
                RoleFormCheckBoxVacanciesEdit.Checked = true;
            else
                RoleFormCheckBoxVacanciesEdit.Checked = false;

            if ((_accessRights & AccessRights.VacanciesAudit) == AccessRights.VacanciesAudit)
                RoleFormCheckBoxVacanciesAudit.Checked = true;
            else
                RoleFormCheckBoxVacanciesAudit.Checked = false;

            // JobSeekers
            if ((_accessRights & AccessRights.JobSeekersView) == AccessRights.JobSeekersView)
                RoleFormCheckBoxJobSeekersView.Checked = true;
            else
                RoleFormCheckBoxJobSeekersView.Checked = false;

            if ((_accessRights & AccessRights.JobSeekersEdit) == AccessRights.JobSeekersEdit)
                RoleFormCheckBoxJobSeekersEdit.Checked = true;
            else
                RoleFormCheckBoxJobSeekersEdit.Checked = false;

            if ((_accessRights & AccessRights.JobSeekersAudit) == AccessRights.JobSeekersAudit)
                RoleFormCheckBoxJobSeekersAudit.Checked = true;
            else
                RoleFormCheckBoxJobSeekersAudit.Checked = false;

            // Deals
            if ((_accessRights & AccessRights.DealsView) == AccessRights.DealsView)
                RoleFormCheckBoxDealsView.Checked = true;
            else
                RoleFormCheckBoxDealsView.Checked = false;

            if ((_accessRights & AccessRights.DealsEdit) == AccessRights.DealsEdit)
                RoleFormCheckBoxDealsEdit.Checked = true;
            else
                RoleFormCheckBoxDealsEdit.Checked = false;

            if ((_accessRights & AccessRights.DealsAudit) == AccessRights.DealsAudit)
                RoleFormCheckBoxDealsAudit.Checked = true;
            else
                RoleFormCheckBoxDealsAudit.Checked = false;
        }

        private int GetAccessRights()
        {
            AccessRights result = AccessRights.None;

            if (RoleFormCheckBoxUsersView.Checked) result |= AccessRights.UsersView;
            if (RoleFormCheckBoxUsersEdit.Checked) result |= AccessRights.UsersEdit;

            if (RoleFormCheckBoxRolesView.Checked) result |= AccessRights.RolesView;
            if (RoleFormCheckBoxRolesEdit.Checked) result |= AccessRights.RolesEdit;

            if (RoleFormCheckBoxWorkCategoriesView.Checked) result |= AccessRights.WorkCategoriesView;
            if (RoleFormCheckBoxWorkCategoriesEdit.Checked) result |= AccessRights.WorkCategoriesEdit;
            if (RoleFormCheckBoxWorkCategoriesAudit.Checked) result |= AccessRights.WorkCategoriesAudit;

            if (RoleFormCheckBoxEmployersView.Checked) result |= AccessRights.EmployersView;
            if (RoleFormCheckBoxEmployersEdit.Checked) result |= AccessRights.EmployersEdit;
            if (RoleFormCheckBoxEmployersAudit.Checked) result |= AccessRights.EmployersAudit;

            if (RoleFormCheckBoxVacanciesView.Checked) result |= AccessRights.VacanciesView;
            if (RoleFormCheckBoxVacanciesEdit.Checked) result |= AccessRights.VacanciesEdit;
            if (RoleFormCheckBoxVacanciesAudit.Checked) result |= AccessRights.VacanciesAudit;

            if (RoleFormCheckBoxJobSeekersView.Checked) result |= AccessRights.JobSeekersView;
            if (RoleFormCheckBoxJobSeekersEdit.Checked) result |= AccessRights.JobSeekersEdit;
            if (RoleFormCheckBoxJobSeekersAudit.Checked) result |= AccessRights.JobSeekersAudit;

            if (RoleFormCheckBoxDealsView.Checked) result |= AccessRights.DealsView;
            if (RoleFormCheckBoxDealsEdit.Checked) result |= AccessRights.DealsEdit;
            if (RoleFormCheckBoxDealsAudit.Checked) result |= AccessRights.DealsAudit;

            return (int)result;
        }

        private void RoleFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;

            // Name
            if (String.IsNullOrWhiteSpace(RoleFormTextBoxName.Text))
            {
                _isValid = false;
                RoleFormLabelName.ForeColor = Color.Brown;
            }
            else
                RoleFormLabelName.ForeColor = Color.FromKnownColor(KnownColor.ControlText);

            if (_isValid)
            {
                _accessRightsValue = GetAccessRights();
                if (_newRole)
                {
                    _queriesTableAdapter.pAddRole(Name: RoleFormTextBoxName.Text, AccessControl: _accessRightsValue);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (RoleFormTextBoxName.Text != _rolesRow.Name ||
                        _accessRightsValue != _rolesRow.AccessControl)
                    {
                        _queriesTableAdapter.pUpdateRole(Code: _rolesRow.Code, Name: RoleFormTextBoxName.Text, AccessControl: _accessRightsValue);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        this.DialogResult= DialogResult.Cancel;
                }
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckBox se = (CheckBox)sender;

            if (se.Name == "RoleFormCheckBoxUsersEdit" && se.Checked)
                RoleFormCheckBoxUsersView.Checked = true;
            else if (se.Name == "RoleFormCheckBoxRolesEdit" && se.Checked)
                RoleFormCheckBoxRolesView.Checked = true;
            else if ((se.Name == "RoleFormCheckBoxWorkCategoriesEdit" || se.Name == "RoleFormCheckBoxWorkCategoriesAudit") && se.Checked)
                RoleFormCheckBoxWorkCategoriesView.Checked = true;
            else if ((se.Name == "RoleFormCheckBoxEmployersEdit" || se.Name == "RoleFormCheckBoxEmployersAudit") && se.Checked)
                RoleFormCheckBoxEmployersView.Checked = true;
            else if ((se.Name == "RoleFormCheckBoxVacanciesEdit" || se.Name == "RoleFormCheckBoxVacanciesAudit") && se.Checked)
                RoleFormCheckBoxVacanciesView.Checked = true;
            else if ((se.Name == "RoleFormCheckBoxJobSeekersEdit" || se.Name == "RoleFormCheckBoxJobSeekersAudit") && se.Checked)
                RoleFormCheckBoxJobSeekersView.Checked = true;
            else if ((se.Name == "RoleFormCheckBoxDealsEdit" || se.Name == "RoleFormCheckBoxDealsAudit") && se.Checked)
                RoleFormCheckBoxDealsView.Checked = true;


            else if (se.Name == "RoleFormCheckBoxUsersView" && !se.Checked)
                RoleFormCheckBoxUsersEdit.Checked = false;
            else if (se.Name == "RoleFormCheckBoxRolesView" && !se.Checked)
                RoleFormCheckBoxRolesEdit.Checked = false;
            else if (se.Name == "RoleFormCheckBoxWorkCategoriesView" && !se.Checked)
            {
                RoleFormCheckBoxWorkCategoriesEdit.Checked = false;
                RoleFormCheckBoxWorkCategoriesAudit.Checked = false;
            }
            else if (se.Name == "RoleFormCheckBoxEmployersView" && !se.Checked)
            {
                RoleFormCheckBoxEmployersEdit.Checked = false;
                RoleFormCheckBoxEmployersAudit.Checked = false;
            }
            else if (se.Name == "RoleFormCheckBoxVacanciesView" && !se.Checked)
            {
                RoleFormCheckBoxVacanciesEdit.Checked = false;
                RoleFormCheckBoxVacanciesAudit.Checked = false;
            }
            else if (se.Name == "RoleFormCheckBoxJobSeekersView" && !se.Checked)
            {
                RoleFormCheckBoxJobSeekersEdit.Checked = false;
                RoleFormCheckBoxJobSeekersAudit.Checked = false;
            }
            else if (se.Name == "RoleFormCheckBoxDealsView" && !se.Checked)
            {
                RoleFormCheckBoxDealsEdit.Checked = false;
                RoleFormCheckBoxDealsAudit.Checked = false;
            }
        }
    }
}
