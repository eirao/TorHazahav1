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
    }
}
