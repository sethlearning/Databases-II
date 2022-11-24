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

namespace cp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginFormButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPDBDataSet.ActiveUsers' table. You can move, or remove it, as needed.
            this.activeUsersTableAdapter.Fill(this.cPDBDataSet.ActiveUsers);

            CPDBDataSetTableAdapters.RolesTableAdapter rolesTableAdapter = new CPDBDataSetTableAdapters.RolesTableAdapter();
            rolesTableAdapter.ClearBeforeFill = true;
            rolesTableAdapter.Fill(this.cPDBDataSet.Roles);

            LoginFormComboBoxUsername.SelectedValue = 0;
        }

        private void LoginFormButtonOK_Click(object sender, EventArgs e)
        {
            if (LoginFormComboBoxUsername.SelectedValue != null)
            {
                byte[] hashBytes;
                StringBuilder sb = new StringBuilder();
                HashAlgorithm SHA256 = new SHA256Managed();
                hashBytes = SHA256.ComputeHash(Encoding.UTF8.GetBytes(LoginFormTextBoxPassword.Text));
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("X2"));

                CPDBDataSet.ActiveUsersRow activeUsersRow = this.cPDBDataSet.ActiveUsers.FindByCode((int)LoginFormComboBoxUsername.SelectedValue);

                if (activeUsersRow.PasswordHash.ToString() == sb.ToString())
                {
                    CPDBDataSet.RolesRow rolesRow = this.cPDBDataSet.Roles.FindByCode(activeUsersRow.Role);
                    // MessageBox.Show($"{rolesRow.AccessControl}", "LoginFormComboBoxUsername", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginFormTextBoxPassword.Text = "";
                    ListsForm lf = new ListsForm(this, (AccessRights)(rolesRow.AccessControl));
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
    }
}
