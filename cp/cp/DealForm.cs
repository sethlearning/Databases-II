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
    public partial class DealForm : Form
    {
        private CPDBDataSet.DealsRow _dealsRow;
        private int _userCode;
        private bool _newDeal = false;
        private bool _isValid = false;
        private CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;
        public DealForm(CPDBDataSet.DealsRow dealsRow, int userCode)
        {
            InitializeComponent();
            _dealsRow = dealsRow;
            _userCode = userCode;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void DealForm_Load(object sender, EventArgs e)
        {
            if (_dealsRow.Code < 0)
            {
                _newDeal = true;
                DealFormTextBoxCode.Text = "New Deal";
            }
            else
            {
                DealFormTextBoxCode.Text = _dealsRow.Code.ToString();
            }
        }
    }
}
