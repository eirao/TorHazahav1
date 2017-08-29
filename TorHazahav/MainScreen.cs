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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tOR_HAZAHAVDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.tOR_HAZAHAVDataSet1.Customer);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchResultsCustomer a = new SearchResultsCustomer();
            a.Show();
            this.Hide();
        }

        private void מקבלישירותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen a = new MainScreen();
            a.Show();
            this.Hide();
        }

        private void תוכניותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramList b = new ProgramList();
            b.Show();
            this.Hide();
        }

        private void מתנדביםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolunteersList c = new VolunteersList();
            c.Show();
            this.Hide();
        }

        private void הוספתמקבלשירותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerPage1 d = new AddCustomerPage1();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchCustomer f = new SearchCustomer();
            f.Show();
            this.Hide();
        }
    }
}
