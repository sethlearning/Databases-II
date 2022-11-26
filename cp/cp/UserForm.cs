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

            if (_usersRow.Code == -1)
            {
                UserFormTextBoxCode.Text = "New User";
            }
            else
            {
                UserFormTextBoxCode.Text = _usersRow.Code.ToString();
                UserFormTextBoxUsername.Text = _usersRow.UserName;
                UserFormCheckBoxActive.Checked = _usersRow.Enabled;
            }
        }
    }
}
