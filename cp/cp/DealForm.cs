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
            // TODO: This line of code loads data into the 'cPDBDataSet.vJobSeekersWithFIOList' table. You can move, or remove it, as needed.
            //this.vJobSeekersWithFIOListTableAdapter.Fill(this.cPDBDataSet.vJobSeekersWithFIOList);
            // TODO: This line of code loads data into the 'cPDBDataSet.vVacanciesList' table. You can move, or remove it, as needed.
            //this.vVacanciesListTableAdapter.Fill(this.cPDBDataSet.vVacanciesList);

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
            DealVacancySelectForm dealVacancySelectForm = new DealVacancySelectForm();
            DialogResult dealVacancySelectFormDialogResult = dealVacancySelectForm.ShowDialog();
            MessageBox.Show(dealVacancySelectFormDialogResult.ToString());
            this.vVacanciesListTableAdapter.FillByCode(this.cPDBDataSet.vVacanciesList, dealVacancySelectForm._code);
            dealVacancySelectForm.Dispose();
        }

        private void DealFormButtonVacancyClear_Click(object sender, EventArgs e)
        {
            this.cPDBDataSet.vVacanciesList.Clear();
        }

        private void DealFormButtonJobSeekerSelect_Click(object sender, EventArgs e)
        {
            DealJobSeekerSelectForm dealJobSeekerSelectForm = new DealJobSeekerSelectForm();
            DialogResult dealJobSeekerSelectFormDialogResult = dealJobSeekerSelectForm.ShowDialog();
            MessageBox.Show(dealJobSeekerSelectFormDialogResult.ToString());
            this.vJobSeekersWithFIOListTableAdapter.FillByCode(this.cPDBDataSet.vJobSeekersWithFIOList, dealJobSeekerSelectForm._code);
            dealJobSeekerSelectForm.Dispose();
        }

        private void DealFormButtonJobSeekerClear_Click(object sender, EventArgs e)
        {
            this.cPDBDataSet.vJobSeekersWithFIOList.Clear();
        }
    }
}
