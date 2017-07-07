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
    public partial class ProgramList : Form
    {
        tzDataContext dc;
        public ProgramList()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void ProgramList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tOR_HAZAHAVDataSet2.program' table. You can move, or remove it, as needed.
            // this.programTableAdapter.Fill(this.tOR_HAZAHAVDataSet2.program);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
