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
    public partial class DealJobSeekerSelectForm : Form
    {
        public int _code;
        private int _workCategory;
        public DealJobSeekerSelectForm(int workCategory)
        {
            InitializeComponent();
            _workCategory = workCategory;
        }

        private void DealJobSeekerSelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPDBDataSet.vJobSeekersWithFIOList' table. You can move, or remove it, as needed.
            //this.vJobSeekersWithFIOListTableAdapter.Fill(this.cPDBDataSet.vJobSeekersWithFIOList);
            if (_workCategory == -1)
                this.vJobSeekersWithFIOListTableAdapter.FillAvailableOrderByCode(this.cPDBDataSet.vJobSeekersWithFIOList);
            else
                this.vJobSeekersWithFIOListTableAdapter.FillAvailableWithWorkCategoryOrderByCode(this.cPDBDataSet.vJobSeekersWithFIOList, _workCategory);
        }


        private void DealJobSeekerSelectFormButtonOK_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void DealJobSeekerSelectFormDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Exit();
        }

        private void DealJobSeekerSelectFormDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Exit();
            }
        }

        private void Exit()
        {
            _code = (int)DealJobSeekerSelectFormDataGridView.CurrentRow.Cells[0].Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
