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
    public partial class Form2 : Form
    {
        tzDataContext dc;

        public Form2()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer customerId = (from c in dc.Customers // get the record from the db 
                                   where c.Id == Program.custId
                                   select c).FirstOrDefault();
            if (customerId != null)
            {
                customerId.independency = indepependency.Text;//get values no need to check if null
                customerId.mobility = mobility.Text;
                customerId.active_inclub = activeClub.Text;
                customerId.day_care = dayCenter.Text;
                customerId.entitled_todiscount = entitledDiscount.Text;


                dc.SubmitChanges();

                {
                }
    }
}
