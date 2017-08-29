using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorHazahav
{
    public partial class LoginScreen : Form
    {
        tzDataContext dc;
        public LoginScreen()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void enter_bttn_Click(object sender, EventArgs e)
        {
            var ans = (from emp in dc.employees
                       where emp.username == strUser.Text &&
                        emp.u_password == strPassword.Text
                       select emp).FirstOrDefault();

            if (ans != null)
            {
                MainScreen f = new MainScreen();
                f.Show();
                this.Hide();
            }

            else MessageBox.Show("פרטי משתמש שגויים. נא להזין מחדש");
        }
    }
}
