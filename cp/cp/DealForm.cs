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
        private CPDBDataSetTableAdapters.VacanciesTableAdapter _vacanciesTableAdapter;
        private CPDBDataSetTableAdapters.JobSeekersTableAdapter _jobSeekersTableAdapter;
        private CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;
        public DealForm(CPDBDataSet.DealsRow dealsRow, int userCode)
        {
            InitializeComponent();
            _dealsRow = dealsRow;
            _userCode = userCode;
            _vacanciesTableAdapter = new CPDBDataSetTableAdapters.VacanciesTableAdapter();
            _jobSeekersTableAdapter = new CPDBDataSetTableAdapters.JobSeekersTableAdapter();
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void DealForm_Load(object sender, EventArgs e)
        {
            _vacanciesTableAdapter.Fill(this.cPDBDataSet.Vacancies);
            _jobSeekersTableAdapter.Fill(this.cPDBDataSet.JobSeekers);

            if (_dealsRow.Code < 0)
            {
                _newDeal = true;
                DealFormTextBoxCode.Text = "New Deal";
            }
            else
            {
                this.vVacanciesListTableAdapter.FillByCode(this.cPDBDataSet.vVacanciesList, _dealsRow.Vacancy);
                this.vJobSeekersWithFIOListTableAdapter.FillByCode(this.cPDBDataSet.vJobSeekersWithFIOList, _dealsRow.JobSeeker);
                DealFormTextBoxCode.Text = _dealsRow.Code.ToString();
                DealFormNumericUpDownCommission.Value = _dealsRow.Commission;
            }
        }

        #region Vacancy
        private void SelectVacancy()
        {
            int jobSeekerWorkCategory;

            if (this.cPDBDataSet.vJobSeekersWithFIOList.Count == 0)
                jobSeekerWorkCategory = -1;
            else
                jobSeekerWorkCategory = this.cPDBDataSet.JobSeekers.FindByCode((int)this.cPDBDataSet.vJobSeekersWithFIOList[0].Код).WorkCategory;

            DealVacancySelectForm dealVacancySelectForm = new DealVacancySelectForm(workCategory: jobSeekerWorkCategory);
            DialogResult dealVacancySelectFormDialogResult = dealVacancySelectForm.ShowDialog();
            if (dealVacancySelectFormDialogResult == DialogResult.OK)
                this.vVacanciesListTableAdapter.FillByCode(this.cPDBDataSet.vVacanciesList, dealVacancySelectForm._code);
            dealVacancySelectForm.Dispose();
        }

        private void DealFormButtonVacancySelect_Click(object sender, EventArgs e)
        {
            SelectVacancy();
        }
        private void DealFormDataGridViewVacancy_DoubleClick(object sender, EventArgs e)
        {
            SelectVacancy();
        }
        private void DealFormButtonVacancyClear_Click(object sender, EventArgs e)
        {
            this.cPDBDataSet.vVacanciesList.Clear();
        }
        #endregion Vacancy

        #region JobSeeker
        private void SelectJobSeeker()
        {
            int vacancyWorkCategory;

            if (this.cPDBDataSet.vVacanciesList.Count == 0)
                vacancyWorkCategory = -1;
            else
                vacancyWorkCategory = this.cPDBDataSet.Vacancies.FindByCode((int)this.cPDBDataSet.vVacanciesList[0].Код).WorkCategory;

            DealJobSeekerSelectForm dealJobSeekerSelectForm = new DealJobSeekerSelectForm(workCategory: vacancyWorkCategory);
            DialogResult dealJobSeekerSelectFormDialogResult = dealJobSeekerSelectForm.ShowDialog();
            if (dealJobSeekerSelectFormDialogResult == DialogResult.OK)
                this.vJobSeekersWithFIOListTableAdapter.FillByCode(this.cPDBDataSet.vJobSeekersWithFIOList, dealJobSeekerSelectForm._code);
            dealJobSeekerSelectForm.Dispose();
        }
        private void DealFormButtonJobSeekerSelect_Click(object sender, EventArgs e)
        {
            SelectJobSeeker();
        }
        private void DealFormDataGridViewJobSeeker_DoubleClick(object sender, EventArgs e)
        {
            SelectJobSeeker();
        }

        private void DealFormButtonJobSeekerClear_Click(object sender, EventArgs e)
        {
            this.cPDBDataSet.vJobSeekersWithFIOList.Clear();
        }
        #endregion JobSeeker
        
        private void DealFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;

            if (this.cPDBDataSet.vVacanciesList.Count == 0)
            {
                _isValid = false;
                DealFormLabelVacancy.ForeColor = Utilities.WrongColor;
            }
            else
                DealFormLabelVacancy.ForeColor = Utilities.RightColor;

            if (this.cPDBDataSet.vJobSeekersWithFIOList.Count == 0)
            {
                _isValid = false;
                DealFormLabelJobSeeker.ForeColor = Utilities.WrongColor;
            }
            else
                DealFormLabelJobSeeker.ForeColor = Utilities.RightColor;

            if (_isValid)
            {
                if (_newDeal)
                {
                    _queriesTableAdapter.pAddDeal(JobSeeker: this.cPDBDataSet.vJobSeekersWithFIOList[0].Код,
                                                  Vacancy: this.cPDBDataSet.vVacanciesList[0].Код,
                                                  Commission: DealFormNumericUpDownCommission.Value,
                                                  UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else if (this.cPDBDataSet.vVacanciesList[0].Код != _dealsRow.Vacancy ||
                         this.cPDBDataSet.vJobSeekersWithFIOList[0].Код != _dealsRow.JobSeeker ||
                         DealFormNumericUpDownCommission.Value != _dealsRow.Commission)
                {
                    _queriesTableAdapter.pUpdateDeal(Code: _dealsRow.Code,
                                                     JobSeeker: this.cPDBDataSet.vJobSeekersWithFIOList[0].Код,
                                                     Vacancy: this.cPDBDataSet.vVacanciesList[0].Код,
                                                     Commission: DealFormNumericUpDownCommission.Value,
                                                     UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
