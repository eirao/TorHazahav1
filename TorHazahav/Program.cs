using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorHazahav
{
    static class Program
    {
        public static string custId;
        public static int programNum = -1;
        public static string programName;
        public static DateTime pStartDate = new DateTime(1900,01,01);
        public static DateTime pEndDate = new DateTime(2100, 01, 01);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VolunteersList());
        }
    }
}
