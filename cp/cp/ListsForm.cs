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
    public partial class ListsForm : Form
    {
        LoginForm _loginForm;
        AccessRights _accessRights;

        public ListsForm(LoginForm loginForm, AccessRights accessRights)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _accessRights = accessRights;
        }

        private void ListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
            this.Dispose();
        }

        private void ListsForm_Load(object sender, EventArgs e)
        {
            ListsFormTabControl.TabPages.Clear();

            if ((_accessRights & AccessRights.Users) == AccessRights.Users)
                ListsFormTabControl.TabPages.Add(ListsFormTabControlUsersPage);


        }
    }
}
