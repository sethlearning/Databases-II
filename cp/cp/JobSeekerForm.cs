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
    public partial class JobSeekerForm : Form
    {
        private CPDBDataSet.JobSeekersRow _jobSeekersRow;
        private int _userCode;
        private bool _newJobSeeker = false;
        private bool _isValid = false;
        private CPDBDataSetTableAdapters.QueriesTableAdapter _queriesTableAdapter;
        public JobSeekerForm(CPDBDataSet.JobSeekersRow jobSeekersRow, int userCode)
        {
            InitializeComponent();
            _jobSeekersRow = jobSeekersRow;
            _userCode = userCode;
            _queriesTableAdapter = new CPDBDataSetTableAdapters.QueriesTableAdapter();
        }

        private void JobSeekerForm_Load(object sender, EventArgs e)
        {
            this.workCategoriesTableAdapter.Fill(this.cPDBDataSet.WorkCategories);
            if (_jobSeekersRow.Code < 0)
            {
                _newJobSeeker = true;
                JobSeekerFormTextBoxCode.Text = "New JobSeeker";
                JobSeekerFormComboBoxWorkCategory.SelectedIndex = -1;
            }
            else
            {
                if (_jobSeekersRow.IsMiddleNameNull())
                    _jobSeekersRow.MiddleName = String.Empty;
                if (_jobSeekersRow.IsQualificationNull())
                    _jobSeekersRow.Qualification = String.Empty;
                if (_jobSeekersRow.IsDesiredSalaryNull())
                    _jobSeekersRow.DesiredSalary = 0;
                if (_jobSeekersRow.IsNotesNull())
                    _jobSeekersRow.Notes= String.Empty;
                JobSeekerFormTextBoxCode.Text = _jobSeekersRow.Code.ToString();
                JobSeekerFormTextBoxLastName.Text = _jobSeekersRow.LastName;
                JobSeekerFormTextBoxFirstName.Text = _jobSeekersRow.FirstName;
                JobSeekerFormTextBoxMiddleName.Text = _jobSeekersRow.MiddleName;
                JobSeekerFormComboBoxWorkCategory.SelectedValue = _jobSeekersRow.WorkCategory;
                JobSeekerFormTextBoxQualification.Text = _jobSeekersRow.Qualification;
                JobSeekerFormNumericUpDownDesiredSalary.Value = _jobSeekersRow.DesiredSalary;
                JobSeekerFormTextBoxNotes.Text = _jobSeekersRow.Notes;
            }
        }

        private void JobSeekerFormButtonOK_Click(object sender, EventArgs e)
        {
            _isValid = true;

            if (String.IsNullOrWhiteSpace(JobSeekerFormTextBoxLastName.Text))
            {
                _isValid = false;
                JobSeekerFormLabelLastName.ForeColor = Utilities.WrongColor;
            }
            else
                JobSeekerFormLabelLastName.ForeColor = Utilities.RightColor;

            if (String.IsNullOrWhiteSpace(JobSeekerFormTextBoxFirstName.Text))
            {
                _isValid = false;
                JobSeekerFormLabelFirstName.ForeColor = Utilities.WrongColor;
            }
            else
                JobSeekerFormLabelFirstName.ForeColor = Utilities.RightColor;

            if (JobSeekerFormComboBoxWorkCategory.SelectedValue == null)
            {
                _isValid = false;
                JobSeekerFormLabelWorkCategory.ForeColor = Utilities.WrongColor;
            }
            else
                JobSeekerFormLabelWorkCategory.ForeColor = Utilities.RightColor;

            if (_isValid)
            {
                decimal? desiredSalary;
                if (JobSeekerFormNumericUpDownDesiredSalary.Value == 0)
                    desiredSalary = null;
                else
                    desiredSalary = JobSeekerFormNumericUpDownDesiredSalary.Value;

                if (_newJobSeeker)
                {
                    _queriesTableAdapter.pAddJobSeeker(LastName: JobSeekerFormTextBoxLastName.Text,
                                                       FirstName: JobSeekerFormTextBoxFirstName.Text,
                                                       MiddleName: String.IsNullOrEmpty(JobSeekerFormTextBoxMiddleName.Text) ? null : JobSeekerFormTextBoxMiddleName.Text,
                                                       WorkCategory: (int)JobSeekerFormComboBoxWorkCategory.SelectedValue,
                                                       Qualification: String.IsNullOrEmpty(JobSeekerFormTextBoxQualification.Text) ? null : JobSeekerFormTextBoxQualification.Text,
                                                       DesiredSalary: desiredSalary,
                                                       Notes: String.IsNullOrEmpty(JobSeekerFormTextBoxNotes.Text) ? null : JobSeekerFormTextBoxNotes.Text,
                                                       UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else if (JobSeekerFormTextBoxLastName.Text != _jobSeekersRow.LastName ||
                         JobSeekerFormTextBoxFirstName.Text != _jobSeekersRow.FirstName ||
                         JobSeekerFormTextBoxMiddleName.Text != _jobSeekersRow.MiddleName ||
                         (int)JobSeekerFormComboBoxWorkCategory.SelectedValue != _jobSeekersRow.WorkCategory ||
                         JobSeekerFormTextBoxQualification.Text != _jobSeekersRow.Qualification ||
                         JobSeekerFormNumericUpDownDesiredSalary.Value != _jobSeekersRow.DesiredSalary ||
                         JobSeekerFormTextBoxNotes.Text != _jobSeekersRow.Notes)
                {
                    _queriesTableAdapter.pUpdateJobSeeker(Code: _jobSeekersRow.Code,
                                                          LastName: JobSeekerFormTextBoxLastName.Text,
                                                          FirstName: JobSeekerFormTextBoxFirstName.Text,
                                                          MiddleName: String.IsNullOrEmpty(JobSeekerFormTextBoxMiddleName.Text) ? null : JobSeekerFormTextBoxMiddleName.Text,
                                                          WorkCategory: (int)JobSeekerFormComboBoxWorkCategory.SelectedValue,
                                                          Qualification: String.IsNullOrEmpty(JobSeekerFormTextBoxQualification.Text) ? null : JobSeekerFormTextBoxQualification.Text,
                                                          DesiredSalary: desiredSalary,
                                                          Notes: String.IsNullOrEmpty(JobSeekerFormTextBoxNotes.Text) ? null : JobSeekerFormTextBoxNotes.Text,
                                                          UserCode: _userCode);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
