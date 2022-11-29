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
        None                = 0b_0000_0000_0000_0000_0000,  // 0
        UsersView           = 0b_0000_0000_0000_0000_0001,  // 1
        UsersEdit           = 0b_0000_0000_0000_0000_0010,  // 2
        RolesView           = 0b_0000_0000_0000_0000_0100,  // 4
        RolesEdit           = 0b_0000_0000_0000_0000_1000,  // 8
        WorkCategoriesView  = 0b_0000_0000_0000_0001_0000,  // 16
        WorkCategoriesEdit  = 0b_0000_0000_0000_0010_0000,  // 32
        WorkCategoriesAudit = 0b_0000_0000_0000_0100_0000,  // 64
        EmployersView       = 0b_0000_0000_0000_1000_0000,  // 128
        EmployersEdit       = 0b_0000_0000_0001_0000_0000,  // 256
        EmployersAudit      = 0b_0000_0000_0010_0000_0000,  // 512
        VacanciesView       = 0b_0000_0000_0100_0000_0000,  // 1024
        VacanciesEdit       = 0b_0000_0000_1000_0000_0000,  // 2048
        VacanciesAudit      = 0b_0000_0001_0000_0000_0000,  // 4096
        JobSeekersView      = 0b_0000_0010_0000_0000_0000,  // 8192
        JobSeekersEdit      = 0b_0000_0100_0000_0000_0000,  // 16384
        JobSeekersAudit     = 0b_0000_1000_0000_0000_0000,  // 32768
        DealsView           = 0b_0001_0000_0000_0000_0000,  // 65536
        DealsEdit           = 0b_0010_0000_0000_0000_0000,  // 131072
        DealsAudit          = 0b_0100_0000_0000_0000_0000   // 262144
    }

    public enum StatusSelector
    {
        Free = 0,
        Occupied = 1,
        All = 2
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
