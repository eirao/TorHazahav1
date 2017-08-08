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
    public partial class AddVolunteer : Form
    {
        tzDataContext dc;
        public AddVolunteer()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void AddVolunteer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ans = (from volunlist in dc.volunteers where volunlist.first_name == strFName.Text && volunlist.last_name == strLName.Text select volunlist).FirstOrDefault();

            
            if (ans != null)
            {
                MessageBox.Show("המתנדב כבר רשום במערכת");
            }
            else
            {
                volunteer vol = new volunteer(); //create new volunteer record
                vol.first_name = strFName.Text;
                vol.last_name = strLName.Text;
                vol.email_address = emailAdd.Text;
                vol.comments = strComments.Text;
                vol.start_date = startDate.Value;
                vol.end_date = endDate.Value;
                dc.volunteers.InsertOnSubmit(vol);
                dc.SubmitChanges();

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddVolunteer f = new AddVolunteer();
            f.Show();
            this.Hide();
        }
    }
   
}
