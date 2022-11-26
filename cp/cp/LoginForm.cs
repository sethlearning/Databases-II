using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using cp.CPDBDataSetTableAdapters;

namespace cp
{
    public partial class LoginForm : Form
    {
        CPDBDataSetTableAdapters.RolesTableAdapter _rolesTableAdapter;
        public LoginForm()
        {
            InitializeComponent();
            _rolesTableAdapter = new CPDBDataSetTableAdapters.RolesTableAdapter();
            _rolesTableAdapter.ClearBeforeFill = true;
        }

        private void LoginFormButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginFormComboBoxUsername.SelectedValue = 0;
        }

        private void LoginFormButtonOK_Click(object sender, EventArgs e)
        {
            if (LoginFormComboBoxUsername.SelectedValue != null)
            {
                string textBoxPasswordHash;

                textBoxPasswordHash = cp.Utilities.GetSHA256(LoginFormTextBoxPassword.Text);
                CPDBDataSet.vActiveUsersRow vActiveUsersRow = this.cPDBDataSet.vActiveUsers.FindByCode((int)LoginFormComboBoxUsername.SelectedValue);

                if (vActiveUsersRow.PasswordHash.ToString() == textBoxPasswordHash)
                {
                    CPDBDataSet.RolesRow rolesRow = this.cPDBDataSet.Roles.FindByCode(vActiveUsersRow.Role);
                    this.Hide();
                    LoginFormTextBoxPassword.Text = "";
                    ListsForm lf = new ListsForm(this, (AccessRights)(rolesRow.AccessControl), vActiveUsersRow.Code);
                    lf.Show();
                }
                else
                    LoginFormLabelWrongPassword.Visible = true;
            }
        }

        private void LoginFormTextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            LoginFormLabelWrongPassword.Visible = false;
        }

        private void LoginFormComboBoxUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            LoginFormLabelWrongPassword.Visible = false;
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.vActiveUsersTableAdapter.FillOrderBy(this.cPDBDataSet.vActiveUsers, "Code");
                _rolesTableAdapter.Fill(this.cPDBDataSet.Roles);
            }
        }
    }
}
