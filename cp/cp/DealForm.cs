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
            // TODO: This line of code loads data into the 'cPDBDataSet.vJobSeekersWithFIOList' table. You can move, or remove it, as needed.
            //this.vJobSeekersWithFIOListTableAdapter.Fill(this.cPDBDataSet.vJobSeekersWithFIOList);
            // TODO: This line of code loads data into the 'cPDBDataSet.vVacanciesList' table. You can move, or remove it, as needed.
            //this.vVacanciesListTableAdapter.Fill(this.cPDBDataSet.vVacanciesList);
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

        private void DealFormButtonVacancySelect_Click(object sender, EventArgs e)
        {
            int jobSeekerWorkCategory;

            if (this.cPDBDataSet.vJobSeekersWithFIOList.Count == 0)
                jobSeekerWorkCategory = -1;
            else
                jobSeekerWorkCategory = this.cPDBDataSet.JobSeekers.FindByCode((int)this.cPDBDataSet.vJobSeekersWithFIOList[0].Код).WorkCategory;

            DealVacancySelectForm dealVacancySelectForm = new DealVacancySelectForm(workCategory: jobSeekerWorkCategory);
            DialogResult dealVacancySelectFormDialogResult = dealVacancySelectForm.ShowDialog();
            MessageBox.Show(dealVacancySelectFormDialogResult.ToString());
            if (dealVacancySelectFormDialogResult == DialogResult.OK)
                this.vVacanciesListTableAdapter.FillByCode(this.cPDBDataSet.vVacanciesList, dealVacancySelectForm._code);
            dealVacancySelectForm.Dispose();
        }

        private void DealFormButtonVacancyClear_Click(object sender, EventArgs e)
        {
            this.cPDBDataSet.vVacanciesList.Clear();
        }

        private void DealFormButtonJobSeekerSelect_Click(object sender, EventArgs e)
        {
            int vacancyWorkCategory;

            if (this.cPDBDataSet.vVacanciesList.Count == 0)
                vacancyWorkCategory = -1;
            else
                vacancyWorkCategory = this.cPDBDataSet.Vacancies.FindByCode((int)this.cPDBDataSet.vVacanciesList[0].Код).WorkCategory;

            DealJobSeekerSelectForm dealJobSeekerSelectForm = new DealJobSeekerSelectForm(workCategory: vacancyWorkCategory);
            DialogResult dealJobSeekerSelectFormDialogResult = dealJobSeekerSelectForm.ShowDialog();
            MessageBox.Show(dealJobSeekerSelectFormDialogResult.ToString());
            if (dealJobSeekerSelectFormDialogResult == DialogResult.OK)
                this.vJobSeekersWithFIOListTableAdapter.FillByCode(this.cPDBDataSet.vJobSeekersWithFIOList, dealJobSeekerSelectForm._code);
            dealJobSeekerSelectForm.Dispose();
        }

        private void DealFormButtonJobSeekerClear_Click(object sender, EventArgs e)
        {
            this.cPDBDataSet.vJobSeekersWithFIOList.Clear();
        }
    }
}
