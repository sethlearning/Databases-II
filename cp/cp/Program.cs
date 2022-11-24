using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cp
{
    public enum AccessRights
    {
        None                = 0b_0000_0000_0000_0000,   // 0
        Users               = 0b_0000_0000_0000_0001,   // 1
        Employers           = 0b_0000_0000_0000_0010,   // 2
        EmployersReadOnly   = 0b_0000_0000_0000_0100,   // 4
        Vacancies           = 0b_0000_0000_0000_1000,   // 8
        VacanciesReadOnly   = 0b_0000_0000_0001_0000,   // 16
        JobSeekers          = 0b_0000_0000_0010_0000,   // 32
        JobSeekersReadOnly  = 0b_0000_0000_0100_0000,   // 64
        Deals               = 0b_0000_0000_1000_0000,   // 128
        DealsReadOnly       = 0b_0000_0001_0000_0000    // 256
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
