using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cp
{
    public enum AccessRights
    {
        None                = 0b_0000_0000_0000_0000,   // 0
        UsersView           = 0b_0000_0000_0000_0001,   // 1
        UsersEdit           = 0b_0000_0000_0000_0010,   // 2
        WorkCategoriesView  = 0b_0000_0000_0000_0100,   // 4
        WorkCategoriesEdit  = 0b_0000_0000_0000_1000,   // 8
        EmployersView       = 0b_0000_0000_0001_0000,   // 16
        EmployersEdit       = 0b_0000_0000_0010_0000,   // 32
        VacanciesView       = 0b_0000_0000_0100_0000,   // 64
        VacanciesEdit       = 0b_0000_0000_1000_0000,   // 128
        JobSeekersView      = 0b_0000_0001_0000_0000,   // 256
        JobSeekersEdit      = 0b_0000_0010_0000_0000,   // 512
        DealsView           = 0b_0000_0100_0000_0000,   // 1024
        DealsEdit           = 0b_0000_1000_0000_0000    // 2048

        // Administrator = 3
        // Director = 1364
        // Manager = 4092
        // Operator = 3412
    }

    internal static class Utilities
    {
        internal static string GetSHA256(string input)
        {
            byte[] hashBytes;
            StringBuilder sb = new StringBuilder();
            HashAlgorithm SHA256 = new SHA256Managed();
            hashBytes = SHA256.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte b in hashBytes)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
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
