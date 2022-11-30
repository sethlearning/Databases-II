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

        }
    }
}
