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
    public partial class MedicalInfo : Form
    {
        tzDataContext dc;
        public MedicalInfo()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void MedicalInfo_Load(object sender, EventArgs e)
        {

        }

        private void Severity_cbBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertMedicalHistory_Click(object sender, EventArgs e)
        {
            var customerId = (from c in dc.Customers // get the record from the db 
                              where c.Id == Program.custId
                              select c).FirstOrDefault();

            if (customerId != null)
            {
                

                if (Hearing_chkbox.Checked)
                {
                    customer_medical_history custmed = new customer_medical_history(); //create new customer medical history record
                    custmed.desease = "שמיעה";
                    custmed.severity = Severity_cbBox1.Text;
                    custmed.comments = comments1.Text;
                    custmed.customer_id = Program.custId;
                    dc.customer_medical_histories.InsertOnSubmit(custmed);
                    dc.SubmitChanges();
                }
               
                if (Chronic__chkbox.Checked)
                {
                    customer_medical_history custmed = new customer_medical_history(); //create new customer medical history record
                    custmed.desease = "מחלה כרונית";
                    custmed.severity = Severity_cbBox2.Text;
                    custmed.comments = comments2.Text;
                    custmed.customer_id = Program.custId;
                    dc.customer_medical_histories.InsertOnSubmit(custmed);
                    dc.SubmitChanges();
                }

                if (Vision__chkbox.Checked)
                {
                    customer_medical_history custmed = new customer_medical_history();
                    custmed.desease = "ראיה";
                    custmed.severity = Severity_cbBox3.Text;
                    custmed.comments = comments3.Text;
                    custmed.customer_id = Program.custId;
                    dc.customer_medical_histories.InsertOnSubmit(custmed);
                    dc.SubmitChanges();
                }
                if (Demensia__chkbox.Checked)
                {
                    customer_medical_history custmed = new customer_medical_history();
                    custmed.desease = "דמנציה";
                    custmed.severity = Severity_cbBox4.Text;
                    custmed.comments = comments4.Text;
                    custmed.customer_id = Program.custId;
                    dc.customer_medical_histories.InsertOnSubmit(custmed);
                    dc.SubmitChanges();

                }
                if (Parkinson__chkbox.Checked)
                {
                    customer_medical_history custmed = new customer_medical_history();
                    custmed.desease = "פרקינסון";
                    custmed.severity = Severity_cbBox5.Text;
                    custmed.comments = comments5.Text;
                    custmed.customer_id = Program.custId;
                    dc.customer_medical_histories.InsertOnSubmit(custmed);
                    dc.SubmitChanges();

                }
                if (Other__chkbox.Checked)
                 { 
                    if (diffDeseaseNamestr.Text == "")
                    {
                        diffDeseaseNamestr.BackColor = Color.Red;
                        MessageBox.Show("נא למלא את שם המחלה");
                    }

                else
                    {
                        customer_medical_history custmed = new customer_medical_history();
                        custmed.desease = diffDeseaseNamestr.Text;
                        custmed.severity = Severity_cbBox6.Text;
                        custmed.comments = comments6.Text;
                        custmed.customer_id = Program.custId;
                        dc.customer_medical_histories.InsertOnSubmit(custmed);
                        dc.SubmitChanges();
                    }

                 }
              
                AddCustomerPage2 f = new AddCustomerPage2();
                f.Show();
                this.Hide();
                }
            }
       
    }

}
