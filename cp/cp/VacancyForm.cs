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
            this.employersTableAdapter.Fill(this.cPDBDataSet.Employers);
            this.workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);

            if (_vacanciesRow.Code < 0)
            {
                _newVacancy = true;
                VacancyFormTextBoxCode.Text = "New Vacancy";
                VacancyFormComboBoxWorkCategory.SelectedIndex = -1;
                VacancyFormComboBoxEmployer.SelectedIndex = -1;
            }
            else
            {
                if (_vacanciesRow.IsSalaryNull())
                    _vacanciesRow.Salary = 0;
                VacancyFormTextBoxCode.Text = _vacanciesRow.Code.ToString();
                VacancyFormComboBoxWorkCategory.SelectedValue = _vacanciesRow.WorkCategory;
                VacancyFormTextBoxPosition.Text = _vacanciesRow.Position;
                VacancyFormNumericUpDownSalary.Value = _vacanciesRow.Salary;
                VacancyFormComboBoxEmployer.SelectedValue = _vacanciesRow.Employer;
            }
        }

        private void VacancyFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;

            if (VacancyFormComboBoxWorkCategory.SelectedValue == null)
            {
                _isValid = false;
                VacancyFormLabelWorkCategory.ForeColor = Utilities.WrongColor;
            }
            else
                VacancyFormLabelWorkCategory.ForeColor = Utilities.RightColor;

            if (String.IsNullOrWhiteSpace(VacancyFormTextBoxPosition.Text))
            {
                _isValid = false;
                VacancyFormLabelPosition.ForeColor = Utilities.WrongColor;
            }
            else
                VacancyFormLabelPosition.ForeColor = Utilities.RightColor;

            if (VacancyFormComboBoxEmployer.SelectedValue == null)
            {
                _isValid = false;
                VacancyFormLabelEmployer.ForeColor = Utilities.WrongColor;
            }
            else
                VacancyFormLabelEmployer.ForeColor = Utilities.RightColor;

            if (_isValid)
            {
                decimal? salary;
                if (VacancyFormNumericUpDownSalary.Value == 0)
                    salary = null;
                else
                    salary = VacancyFormNumericUpDownSalary.Value;

                if (_newVacancy)
                {
                    _queriesTableAdapter.pAddVacancy(WorkCategory: (int)VacancyFormComboBoxWorkCategory.SelectedValue,
                                                     Position: VacancyFormTextBoxPosition.Text,
                                                     Salary: salary,
                                                     Employer: (int)VacancyFormComboBoxEmployer.SelectedValue,
                                                     UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else if ((int)VacancyFormComboBoxWorkCategory.SelectedValue != _vacanciesRow.WorkCategory ||
                         VacancyFormTextBoxPosition.Text != _vacanciesRow.Position ||
                         VacancyFormNumericUpDownSalary.Value != _vacanciesRow.Salary ||
                         (int)VacancyFormComboBoxEmployer.SelectedValue != _vacanciesRow.Employer)
                {
                    _queriesTableAdapter.pUpdateVacancy(Code: _vacanciesRow.Code,
                                                        WorkCategory: (int)VacancyFormComboBoxWorkCategory.SelectedValue,
                                                        Position: VacancyFormTextBoxPosition.Text,
                                                        Salary: salary,
                                                        Employer: (int)VacancyFormComboBoxEmployer.SelectedValue,
                                                        UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
