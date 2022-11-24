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
    public partial class ListsForm : Form
    {
        LoginForm _loginForm;
        public ListsForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void ListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
