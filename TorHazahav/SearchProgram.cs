using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TorHazahav
{
    public partial class SearchProgram : Form
    {
        tzDataContext dc;
        public SearchProgram()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void SearchProgram_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //when cklicking on search gets the parameters from the forms fills all the global variables and sends it to store procedure
            if (programNumTxt.Text != "")
                Program.programNum = int.Parse(programNumTxt.Text);

            if (pStartDatedt.MaskCompleted)
            {
                Program.pStartDate = DateTime.Parse(pStartDatedt.Text);
            }
            if (pEndDatedt.MaskCompleted)
            {
                Program.pEndDate = DateTime.Parse(pEndDatedt.Text);
            }

            Program.programName = programNameTxt.Text;



            DataTable dt = new DataTable();
            // Open the connection  

            using (SqlConnection con = new SqlConnection(connection.connectionString))
            {
                con.Open();    // Define the command            
                using (SqlCommand cmd = new SqlCommand("FindProgramsList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (Program.programName != null)
                        cmd.Parameters.AddWithValue("@progName", Program.programName);
                    if (Program.programNum != -1)
                        cmd.Parameters.AddWithValue("@progCode", Program.programNum);
                    if (Program.pStartDate != DateTime.Parse("1900/01/01"))
                    cmd.Parameters.AddWithValue("@pStartDate", Program.pStartDate);
                    if (Program.pEndDate != DateTime.Parse("2100/01/01"))
                    cmd.Parameters.AddWithValue("@pEndDate", Program.pEndDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Visible = true;

                

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
