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
        private int _userCode;
        private bool _newUser = false;
        private bool _isValid = false;
        private string _passwordHash;
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

            // Username
            if ( String.IsNullOrWhiteSpace(UserFormTextBoxUsername.Text) )
            {
                //UserFormLabelUsername.Font = new Font(UserFormLabelCode.Font, FontStyle.Bold);
                UserFormLabelUsername.ForeColor = Utilities.WrongColor;
                _isValid = false;
            }
            else
            {
                //UserFormLabelUsername.Font = new Font(UserFormLabelCode.Font, FontStyle.Regular);
                UserFormLabelUsername.ForeColor = Utilities.RightColor;
            }

            // Role
            if (UserFormComboBoxRole.SelectedValue == null)
            {
                UserFormLabelRole.ForeColor = Utilities.WrongColor;
                _isValid = false;
            }
            else
                UserFormLabelRole.ForeColor = Utilities.RightColor;
            
            // New User Password
            if ( _newUser && String.IsNullOrEmpty(UserFormTextBoxPassword.Text) )
            {
                UserFormLabelPassword.ForeColor = Utilities.WrongColor;
                _isValid = false;
            }
            else
                UserFormLabelPassword.ForeColor = Utilities.RightColor;

            if (_isValid)
            {
                _passwordHash = Utilities.GetSHA256(UserFormTextBoxPassword.Text);
                if (_newUser)
                {
                    _queriesTableAdapter.pAddUser(UserName: UserFormTextBoxUsername.Text, PasswordHash: _passwordHash, Role: (int)UserFormComboBoxRole.SelectedValue, Enabled: UserFormCheckBoxActive.Checked);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if ( UserFormTextBoxUsername.Text != _usersRow.UserName ||
                         (int)UserFormComboBoxRole.SelectedValue != _usersRow.Role ||
                         UserFormCheckBoxActive.Checked != _usersRow.Enabled ||
                         (!String.IsNullOrEmpty(UserFormTextBoxPassword.Text) && _passwordHash != _usersRow.PasswordHash) )
                    {
                        if (String.IsNullOrEmpty(UserFormTextBoxPassword.Text))
                            _passwordHash = _usersRow.PasswordHash;

                        _queriesTableAdapter.pUpdateUser(Code: _usersRow.Code, UserName: UserFormTextBoxUsername.Text, PasswordHash: _passwordHash, Role: (int)UserFormComboBoxRole.SelectedValue, Enabled: UserFormCheckBoxActive.Checked);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
