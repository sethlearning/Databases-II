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
        private bool _newUser = false;
        private bool _isChanged = false;
        private bool _isValid = false;
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
                _newUser = true;
                UserFormTextBoxCode.Text = "New User";
                UserFormLabelPasswordDescription.Visible = false;
                UserFormComboBoxRole.SelectedValue = -1;
            }
            else
            {
                UserFormTextBoxCode.Text = _usersRow.Code.ToString();
                UserFormTextBoxUsername.Text = _usersRow.UserName;
                UserFormComboBoxRole.SelectedValue = _usersRow.Role;
                UserFormCheckBoxActive.Checked = _usersRow.Enabled;
            }
        }

        private void UserFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;
            _isChanged = false;

            //if (UserFormTextBoxUsername.Text == "")
            if ( String.IsNullOrWhiteSpace(UserFormTextBoxUsername.Text) )
            {
                //UserFormLabelUsername.Font = new Font(UserFormLabelCode.Font, FontStyle.Bold);
                UserFormLabelUsername.ForeColor = Color.Brown;
                _isValid = false;
            }
            else
            {
                //UserFormLabelUsername.Font = new Font(UserFormLabelCode.Font, FontStyle.Regular);
                UserFormLabelUsername.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }

            if (UserFormComboBoxRole.SelectedValue == null)
            {
                UserFormLabelRole.ForeColor = Color.Brown;
                _isValid = false;
            }
            else
                UserFormLabelRole.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            
            if ( _newUser && String.IsNullOrEmpty(UserFormTextBoxPassword.Text) )
            {
                UserFormLabelPassword.ForeColor = Color.Brown;
                _isValid = false;
            }
            else
                UserFormLabelPassword.ForeColor = Color.FromKnownColor(KnownColor.ControlText);

            if (_isValid)
            {
                if (_newUser)
                {
                    MessageBox.Show($"{_newUser}", "NewUser", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CPDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
                    int returnCode = queriesTableAdapter.pAddUser(UserName: UserFormTextBoxUsername.Text, PasswordHash: Utilities.GetSHA256(UserFormTextBoxPassword.Text), Role: (int)UserFormComboBoxRole.SelectedValue, Enabled: UserFormCheckBoxActive.Enabled);
                    MessageBox.Show($"{returnCode}", "ReturnCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }

                else
                {
                    if ( UserFormTextBoxUsername.Text != _usersRow.UserName ||
                         (int)UserFormComboBoxRole.SelectedValue != _usersRow.Role ||
                         UserFormCheckBoxActive.Checked != _usersRow.Enabled ||
                         (!String.IsNullOrEmpty(UserFormTextBoxPassword.Text) && Utilities.GetSHA256(UserFormTextBoxPassword.Text) != _usersRow.PasswordHash) )
                    {
                        _isChanged = true;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        this.DialogResult = DialogResult.Cancel;
                    //MessageBox.Show($"{_isChanged}", "isChanged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
