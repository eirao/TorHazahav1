using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorHazahav
{
    static class Program
    {
        public static string custId = "33345452";
        public static int programNum = -1;
        public static string programName;
        public static DateTime pStartDate = new DateTime(1900,01,01);
        public static DateTime pEndDate = new DateTime(2100, 01, 01);
        public static int customerId = -1;
        public static string cFirstName;
        public static string cLastName;
        public static int cAreaCodePhone = -1;
        public static int cPhoneNum = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddCustomerPage2());
        }
    }
}
