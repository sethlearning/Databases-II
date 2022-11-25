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
        LoginForm _loginForm;
        AccessRights _accessRights;

        public ListsForm(LoginForm loginForm, AccessRights accessRights)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _accessRights = accessRights;
        }

        private void ListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }

        private void ListsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPDBDataSet.vUsersList' table. You can move, or remove it, as needed.
            this.vUsersListTableAdapter.FillOrderByCode(this.cPDBDataSet.vUsersList);
            // TODO: This line of code loads data into the 'cPDBDataSet.UsersList' table. You can move, or remove it, as needed.
            //this.usersListTableAdapter.FillOrderBy(this.cPDBDataSet.UsersList);

            ListsFormTabControl.TabPages.Clear();

            if ((_accessRights & AccessRights.UsersView) == AccessRights.UsersView)
                ListsFormTabControl.TabPages.Add(ListsFormTabControlUsersPage);
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
