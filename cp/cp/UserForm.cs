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
    public partial class UserForm : Form
    {
        private CPDBDataSet.UsersRow _usersRow;
        public UserForm(CPDBDataSet.UsersRow usersRow)
        {
            InitializeComponent();
            _usersRow = usersRow;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPDBDataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.cPDBDataSet.Roles);

            if (_usersRow.Code < 0)
            {
                UserFormTextBoxCode.Text = "New User";
            }
            else
            {
                UserFormTextBoxCode.Text = _usersRow.Code.ToString();
                UserFormTextBoxUsername.Text = _usersRow.UserName;
                UserFormComboBoxRole.SelectedValue = _usersRow.Code;
                UserFormCheckBoxActive.Checked = _usersRow.Enabled;
            }
        }

        private void UserFormButtonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{UserFormComboBoxRole.Text}", "UserFormComboBoxRole", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"{UserFormComboBoxRole.SelectedValue}", "UserFormComboBoxRole", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
