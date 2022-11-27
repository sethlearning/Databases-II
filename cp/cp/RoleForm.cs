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
        CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;

        public RoleForm(CPDBDataSet.RolesRow rolesRow, int userCode, int userRole)
        {
            InitializeComponent();
            _rolesRow = rolesRow;
            _userCode = userCode;
            _userRole = userRole;
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
            }

        }

        private void RoleFormButtonOK_Click(object sender, EventArgs e)
        {

        }
    }
}
