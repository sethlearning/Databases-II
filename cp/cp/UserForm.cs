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
        int _userCode;
        private bool _newUser = false;
        private bool _isChanged = false;
        private bool _isValid = false;
        CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;
        public UserForm(CPDBDataSet.UsersRow usersRow, int userCode)
        {
            InitializeComponent();
            _userCode = userCode;
            _usersRow = usersRow;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
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

                if (_userCode == _usersRow.Code)
                {
                    UserFormComboBoxRole.Enabled = false;
                    UserFormCheckBoxActive.Enabled = false;
                }
            }
        }

        private void UserFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;
            _isChanged = false;

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
                    //MessageBox.Show($"{_newUser}", "NewUser", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int returnCode = _queriesTableAdapter.pAddUser(UserName: UserFormTextBoxUsername.Text, PasswordHash: Utilities.GetSHA256(UserFormTextBoxPassword.Text), Role: (int)UserFormComboBoxRole.SelectedValue, Enabled: UserFormCheckBoxActive.Enabled);
                    //MessageBox.Show($"{returnCode}", "ReturnCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        //MessageBox.Show($"{_isChanged}", "isChanged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string passwordHash;
                        if (String.IsNullOrEmpty(UserFormTextBoxPassword.Text))
                            passwordHash = _usersRow.PasswordHash;
                        else
                            passwordHash = Utilities.GetSHA256(UserFormTextBoxPassword.Text);

                        int returnCode = _queriesTableAdapter.pUpdateUser(Code: _usersRow.Code, UserName: UserFormTextBoxUsername.Text, PasswordHash: passwordHash, Role: (int)UserFormComboBoxRole.SelectedValue, Enabled: UserFormCheckBoxActive.Checked);
                        //MessageBox.Show($"{returnCode}", "ReturnCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
