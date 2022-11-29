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
    public partial class WorkCategoryForm : Form
    {
        private CPDBDataSet.WorkCategoriesRow _workCategoriesRow;
        private int _userCode;
        private bool _newWorkCategory = false;
        private bool _isValid;
        private CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;
        public WorkCategoryForm(CPDBDataSet.WorkCategoriesRow workCategoriesRow, int userCode)
        {
            InitializeComponent();
            _workCategoriesRow = workCategoriesRow;
            _userCode = userCode;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void WorkCategoryForm_Load(object sender, EventArgs e)
        {
            if (_workCategoriesRow.Code < 0)
            {
                _newWorkCategory = true;
                WorkCategoryFormTextBoxCode.Text = "New Work Category";
            }
            else
            {
                WorkCategoryFormTextBoxCode.Text = _workCategoriesRow.Code.ToString();
                WorkCategoryFormTextBoxName.Text = _workCategoriesRow.Name;
            }
        }

        private void WorkCategoryFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;
            if (String.IsNullOrWhiteSpace(WorkCategoryFormTextBoxName.Text))
            {
                _isValid = false;
                WorkCategoryLabelName.ForeColor = Color.Brown;
            }
            else
                WorkCategoryLabelName.ForeColor = Color.FromKnownColor(KnownColor.ControlText);

            if (_isValid)
            {
                if (_newWorkCategory)
                {
                    _queriesTableAdapter.pAddWorkCategory(Name: WorkCategoryFormTextBoxName.Text, UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else if (WorkCategoryFormTextBoxName.Text != _workCategoriesRow.Name)
                {
                    _queriesTableAdapter.pUpdateWorkCategory(Code: _workCategoriesRow.Code, Name: WorkCategoryFormTextBoxName.Text, UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
