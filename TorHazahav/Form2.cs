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
    public partial class AddCustomerPage2 : Form
    {
        tzDataContext dc;

        public AddCustomerPage2()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer customerId = (from c in dc.Customers // get the record from the db 
                                   where c.Id == Program.custId
                                   select c).FirstOrDefault();
            if (customerId != null)
            {
                customerId.independency = indepependency.Text;//get values no need to check if null
                customerId.mobility = mobility.Text;
                customerId.active_inclub = activeClub.Text;
                customerId.day_care = dayCenter.Text;
                if (entitledDisctrue.Checked)
                    customerId.entitled_todiscount = true;
                else if (entitledDiscfalse.Checked)
                    customerId.entitled_todiscount = false;
                if (holocSurvtrue.Checked)
                    customerId.holocaust_survaviour = true;
                else if (holocSurvfalse.Checked)
                    customerId.holocaust_survaviour = false;
                if (nursLawtrue.Checked)
                    customerId.nursing_law = true;
                else if (nursLawfalse.Checked)
                    customerId.nursing_law = false;
                dc.SubmitChanges();


                if (foreignWorkerYes.Checked)
                    customerId.foreign_worker = true;
                else if (foreignWorkerYes.Checked)
                    customerId.foreign_worker = false;


            }

        }



        private void needSpAct_btn_Click(object sender, EventArgs e)
        {
            NeedSpecialActivity f = new NeedSpecialActivity();
            f.Show();
            this.Enabled = false;
        }

        private void mainCarrier_btn_Click(object sender, EventArgs e)
        {
            AddMainCarrier f = new AddMainCarrier();
            f.Show();
            this.Enabled = false;
        }

        private void family_btn_Click(object sender, EventArgs e)
        {
            AddFamilyMember b = new AddFamilyMember();
            b.Show();
            this.Enabled = false;
        }

        private void foreignWorkerYes_CheckedChanged(object sender, EventArgs e)
        {
            if (foreignWorkerYes.Checked == true)
            {
                AddForeignWorker a = new AddForeignWorker();
                a.Show();
                this.Enabled = false;
            }
        }

        private void healthInfo_btn_Click(object sender, EventArgs e)
        {
            MedicalInfo a = new MedicalInfo();
            a.Show();
            this.Enabled = false;
        }

        private void AddProgramToCustomerbtn_Click(object sender, EventArgs e)
        {
            ProgramList a = new ProgramList();
            a.Show();
            this.Enabled = false;
        }
    }
}
