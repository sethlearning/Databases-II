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

            // WorkCategories
            if ((_accessRights & AccessRights.WorkCategoriesView) == AccessRights.WorkCategoriesView)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageWorkCategories);
            }

            // Employers
            if ((_accessRights & AccessRights.EmployersView) == AccessRights.EmployersView)
            {
                ListsFormTabControl.TabPages.Add(ListsFormTabControlPageEmployers);
            }
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

        private void EditUser(object sender, EventArgs e)
        {

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
    }
}
