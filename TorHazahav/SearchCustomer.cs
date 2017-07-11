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
    public partial class SearchCustomer : Form
    {
        tzDataContext dc;
        public SearchCustomer()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (strId.Text != "")
                Program.customerId = int.Parse(strId.Text);

            if (strFName.Text != "")
                Program.cFirstName = strFName.Text;

            if (strLName.Text != "")
                Program.cLastName = strLName.Text;

            if (areaCodeM.Text != "")
                Program.cAreaCodePhone = int.Parse(areaCodeM.Text);

            if (phoneNumM.Text != "")
                Program.cPhoneNum = int.Parse(phoneNumM.Text);
           
           

            DataTable dt = new DataTable();
            // Open the connection  

            using (SqlConnection con = new SqlConnection(connection.connectionString))
            {
                con.Open();    // Define the command            
                using (SqlCommand cmd = new SqlCommand("FindCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (Program.customerId != -1)
                        cmd.Parameters.AddWithValue("@customerId", Program.customerId);
                    if (Program.cFirstName != null)
                        cmd.Parameters.AddWithValue("@customerFName", Program.cFirstName);
                    if (Program.cLastName != null)
                        cmd.Parameters.AddWithValue("@customerLName", Program.cLastName);
                    if (Program.cAreaCodePhone != -1)
                        cmd.Parameters.AddWithValue("@areacodeP", Program.cAreaCodePhone);
                    if (Program.cPhoneNum != -1)
                        cmd.Parameters.AddWithValue("@phonenumP", Program.cPhoneNum);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Visible = true;



                }

            }
        }
    }
}
