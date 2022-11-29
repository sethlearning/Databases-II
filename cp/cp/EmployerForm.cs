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
    public partial class EmployerForm : Form
    {
        private CPDBDataSet.EmployersRow _employersRow;
        private int _userCode;
        private bool _newEmployer = false;
        private bool _isValid = false;
        CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;
        public EmployerForm(CPDBDataSet.EmployersRow employersRow, int userCode)
        {
            InitializeComponent();
            _employersRow = employersRow;
            _userCode = userCode;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void EmployerForm_Load(object sender, EventArgs e)
        {
            if (_employersRow.Code < 0)
            {
                _newEmployer = true;
                EmployerFormTextBoxCode.Text = "New Employer";
            }
            else
            {
                EmployerFormTextBoxCode.Text = _employersRow.Code.ToString();
                EmployerFormTextBoxName.Text = _employersRow.Name;
                if (!_employersRow.IsAddressNull())
                    EmployerFormTextBoxAddress.Text = _employersRow.Address;
                if (!_employersRow.IsPhoneNull())
                    EmployerFormTextBoxPhone.Text = _employersRow.Phone;
            }
        }
    }
}
