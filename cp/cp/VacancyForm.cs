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
    public partial class VacancyForm : Form
    {
        private CPDBDataSet.VacanciesRow _vacanciesRow;
        private int _userCode;
        private bool _newVacancy = false;
        private bool _isValid = false;
        CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;
        public VacancyForm(CPDBDataSet.VacanciesRow vacanciesRow, int userCode)
        {
            InitializeComponent();
            _vacanciesRow = vacanciesRow;
            _userCode = userCode;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void VacancyForm_Load(object sender, EventArgs e)
        {
            this.workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);

            if (_vacanciesRow.Code < 0)
            {
                _newVacancy = true;
                VacancyFormTextBoxCode.Text = "New Vacancy";
                VacancyFormComboBoxWorkCategory.SelectedIndex = -1;
            }
            else
            {
                VacancyFormTextBoxCode.Text = _vacanciesRow.Code.ToString();
                VacancyFormComboBoxWorkCategory.SelectedValue = _vacanciesRow.WorkCategory;
                VacancyFormTextBoxPosition.Text = _vacanciesRow.Position;
                VacancyFormTextBoxSalary.Text = _vacanciesRow.Salary.ToString("N2");
            }
        }
    }
}
