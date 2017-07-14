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
    public partial class NeedSpecialActivity : Form
    {
        tzDataContext dc;
        public NeedSpecialActivity()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void NeedSpecialActivity_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customerId = (from c in dc.Customers // get the record from the db 
                              where c.Id == Program.custId
                              select c).FirstOrDefault();

            if (customerId != null)
            {


                if (specialPName_str.Text == "" || specialPDetails_str.Text == "" || specialPType_str.Text == "")
                {
                    MessageBox.Show("לא מולאו כל שדות חובה");
                }
                else

                {

                    customer_sp_act spactivity = new customer_sp_act(); //create new customer special activity record

                    spactivity.activity_name = specialPName_str.Text;
                    spactivity.activity_details = specialPDetails_str.Text;
                    spactivity.activity_type = specialPType_str.Text;
                    spactivity.activity_status = "פעיל";
                    spactivity.customer_id = Program.custId;
                    if (qualificationTrue.Checked)
                        spactivity.qualification = true;

                    else if (qualificationfalse.Checked)

                        spactivity.qualification = false;

                    dc.customer_sp_acts.InsertOnSubmit(spactivity);
                    dc.SubmitChanges();

                }
            }
        }
    }

