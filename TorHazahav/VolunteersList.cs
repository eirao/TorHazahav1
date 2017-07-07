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
    public partial class VolunteersList : Form
    {
        tzDataContext dc;

        public VolunteersList()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void VolunteersList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tOR_HAZAHAVDataSet4.volunteer' table. You can move, or remove it, as needed.
            //this.volunteerTableAdapter.Fill(this.tOR_HAZAHAVDataSet4.volunteer);
            var ans = from vol in dc.volunteers
                      where vol.end_date == null
                      select vol;
            dataGridView1.DataSource = ans;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.volunteerTableAdapter.FillBy(this.tOR_HAZAHAVDataSet4.volunteer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
