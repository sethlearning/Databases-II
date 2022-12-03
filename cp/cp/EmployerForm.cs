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
                if (_employersRow.IsAddressNull())
                    _employersRow.Address = String.Empty;
                if (_employersRow.IsPhoneNull())
                    _employersRow.Phone = String.Empty;
                EmployerFormTextBoxCode.Text = _employersRow.Code.ToString();
                EmployerFormTextBoxName.Text = _employersRow.Name;
                EmployerFormTextBoxAddress.Text = _employersRow.Address;
                EmployerFormTextBoxPhone.Text = _employersRow.Phone;
            }
        }

        private void EmployerFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;
            if (String.IsNullOrWhiteSpace(EmployerFormTextBoxName.Text))
            {
                _isValid = false;
                EmployerFormLabelName.ForeColor = Utilities.WrongColor;
            }
            else
                EmployerFormLabelName.ForeColor = Utilities.RightColor;

            if (_isValid)
            {
                if (_newEmployer)
                {
                    _queriesTableAdapter.pAddEmployer(Name: EmployerFormTextBoxName.Text,
                                                      Address: String.IsNullOrEmpty(EmployerFormTextBoxAddress.Text) ? null : EmployerFormTextBoxAddress.Text,
                                                      Phone: String.IsNullOrEmpty(EmployerFormTextBoxPhone.Text) ? null : EmployerFormTextBoxPhone.Text,
                                                      UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else if (EmployerFormTextBoxName.Text != _employersRow.Name ||
                         EmployerFormTextBoxAddress.Text != _employersRow.Address ||
                         EmployerFormTextBoxPhone.Text != _employersRow.Phone)
                {
                    _queriesTableAdapter.pUpdateEmployer(Code: _employersRow.Code,
                                                         Name: EmployerFormTextBoxName.Text,
                                                         Address: String.IsNullOrEmpty(EmployerFormTextBoxAddress.Text) ? null : EmployerFormTextBoxAddress.Text,
                                                         Phone: String.IsNullOrEmpty(EmployerFormTextBoxPhone.Text) ? null : EmployerFormTextBoxPhone.Text,
                                                         UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
