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
            // TODO: This line of code loads data into the 'tOR_HAZAHAVDataSet5.program' table. You can move, or remove it, as needed.
            this.programTableAdapter1.Fill(this.tOR_HAZAHAVDataSet5.program);
            // TODO: This line of code loads data into the 'tOR_HAZAHAVDataSet2.program' table. You can move, or remove it, as needed.
            // this.programTableAdapter.Fill(this.tOR_HAZAHAVDataSet2.program);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int programNum = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            var ans = (from custprog in dc.customer_programs
                       where
custprog.customer_id == Program.custId && custprog.program_id == programNum
                       select custprog).FirstOrDefault();



            if (ans != null)
            {
                MessageBox.Show("מקבל השירות כבר שויך לתוכנית");
            }
            else
            {
                MessageBox.Show(programNum.ToString());


                customer_program cp = new customer_program(); //create new customer program record

                cp.customer_id = Program.custId;
                cp.program_id = programNum;
                cp.start_date = DateTime.Now;
                cp.end_date = DateTime.Parse(dataGridView1.Rows[index].Cells[5].Value.ToString());
                dc.customer_programs.InsertOnSubmit(cp);
                dc.SubmitChanges();


            }

        }

            private void button2_Click(object sender, EventArgs e)
            {
                SearchProgram f = new SearchProgram();
                f.Show();
                this.Hide();

            }
        }
    }


