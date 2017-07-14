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
    public partial class AddProgram : Form
    {
        tzDataContext dc;
        public AddProgram()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void AddProgram_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ans = (from prog in dc.programs where prog.name == progNameTxt.Text select prog).FirstOrDefault();



            if (ans != null)
            {
                MessageBox.Show("התוכנית כבר קיימת במערכת");
            }
            else
            {
                program pr = new program(); //create new program record
                pr.name = progNameTxt.Text;
                pr.start_date = startDatedt.Value;
                pr.end_date = endDatedt.Value;
                pr.frequency = frequencyStr.Text;
                pr.comments = commentsStr.Text;
                pr.program_details = detailsStr.Text;
                pr.program_type = programTypeStr.Text;

                dc.programs.InsertOnSubmit(pr);
                dc.SubmitChanges();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddProgram f = new AddProgram();
            f.Show();
            this.Hide();
        }

        private void programTypeStr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}