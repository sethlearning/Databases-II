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
    public partial class DealVacancySelectForm : Form
    {
        public int _code;
        private int _workCategory;
        public DealVacancySelectForm(int workCategory)
        {
            InitializeComponent();
            _workCategory = workCategory;
        }

        private void DealVacancySelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPDBDataSet.vVacanciesList' table. You can move, or remove it, as needed.
            //this.vVacanciesListTableAdapter.Fill(this.cPDBDataSet.vVacanciesList);
            if (_workCategory == -1)
                this.vVacanciesListTableAdapter.FillAvailableOrderByCode(this.cPDBDataSet.vVacanciesList);
            else
                this.vVacanciesListTableAdapter.FillAvailableWithWorkCategoryOrderByCode(this.cPDBDataSet.vVacanciesList, _workCategory);

        }

        private void DealVacancySelectFormButtonOK_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void DealVacancySelectFormDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Exit();
        }

        private void DealVacancySelectFormDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Exit();
            }
        }

        private void Exit()
        {
            _code = (int)DealVacancySelectFormDataGridView.CurrentRow.Cells[0].Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
