﻿using System;
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
    }
}
