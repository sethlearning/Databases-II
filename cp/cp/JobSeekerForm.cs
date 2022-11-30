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
            if (_jobSeekersRow.Code < 0)
            {
                _newJobSeeker = true;
                JobSeekerFormTextBoxCode.Text = "New JobSeeker";
            }
            else
            {
                if (_jobSeekersRow.IsMiddleNameNull())
                    _jobSeekersRow.MiddleName = String.Empty;
                JobSeekerFormTextBoxCode.Text = _jobSeekersRow.Code.ToString();
                JobSeekerFormTextBoxLastName.Text = _jobSeekersRow.LastName;
                JobSeekerFormTextBoxFirstName.Text = _jobSeekersRow.FirstName;
                JobSeekerFormTextBoxMiddleName.Text = _jobSeekersRow.MiddleName;
            }
        }
    }
}
