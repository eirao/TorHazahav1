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
    public partial class Form1 : Form
    {

        tzDataContext dc;
        public Form1()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (strId.Text == "" || strFName.Text == "" || strLName.Text == "" || dateofBirth.Value == DateTime.Now
                  || (!checkMale.Checked && !checkFemale.Checked) ||
                  ((phoneNumH.Text == "" || areaCodeH.Text == "") && (phoneNumM.Text == "" || areaCodeM.Text == "")))
            {
                MessageBox.Show("לא מולאו כל שדות החובה");
                if (strId.Text == "")
                    strId.BackColor = Color.Red; // color red if id is null
                else
                    strId.BackColor = Color.White;

                if (strFName.Text == "")
                    strFName.BackColor = Color.Red;// color red if first name is null
                else
                    strFName.BackColor = Color.White;

                if (strLName.Text == "")
                    strLName.BackColor = Color.Red;// color red if last name is null
                else
                    strLName.BackColor = Color.White;

                if (dateofBirth.Value == DateTime.Now)
                    dateofBirth.BackColor = Color.Red;
                else
                    dateofBirth.BackColor = Color.White;

                if (!checkMale.Checked && !checkFemale.Checked)
                {
                    checkMale.BackColor = Color.Red;
                    checkFemale.BackColor = Color.Red;
                }
                else
                {
                    checkMale.BackColor = Color.White;
                    checkFemale.BackColor = Color.White;
                }

            }
            else
            {


                var ans = (from cust in dc.Customers where cust.Id == strId.Text select cust).FirstOrDefault();



                if (ans != null)
                {
                    MessageBox.Show("מקבל שירות כבר קיים במערכת");
                }
                else
                {
                    Customer cust = new Customer(); //create new customer record
                    cust.Id = strId.Text;
                    cust.first_name = strFName.Text;
                    cust.last_name = strLName.Text;
                    cust.birthdate = dateofBirth.Value;
                    if (checkMale.Checked)
                        cust.gender = "זכר";
                    else
                        cust.gender = "נקבה";
                    cust.marital_status = maritalStatus.Text;
                    cust.comments = strComments.Text;
                    cust.email_address = emailAdd.Text;
                    cust.status_cd = "פעיל";
                    dc.Customers.InsertOnSubmit(cust);
                    // dc.SubmitChanges();


                    phone ph = new phone(); //create new phone record
                    if (phoneNumH.Text != "" && areaCodeH.Text != "")
                    {
                        ph.phone_type = "בית";
                        ph.area_code = areaCodeH.Text;
                        ph.phone_num = phoneNumH.Text;
                        dc.phones.InsertOnSubmit(ph);
                        //  dc.SubmitChanges();
                    }
                    phone ph1 = new phone(); //create new phone record
                    if (phoneNumM.Text != "" && areaCodeM.Text != "")
                    {
                        ph1.phone_type = "נייד";
                        ph1.area_code = areaCodeM.Text;
                        ph1.phone_num = phoneNumM.Text;
                        dc.phones.InsertOnSubmit(ph1);
                        //   dc.SubmitChanges();
                    }

                    dc.SubmitChanges();

                    if (ph != null)
                    {
                        customer_phone cph = new customer_phone();
                        cph.customer_id = strId.Text;
                        cph.phone_id = ph.ID;
                        cph.status = "פעיל";
                        cph.type = ph.phone_type;
                        dc.customer_phones.InsertOnSubmit(cph);
                    }

                    if (ph1 != null)
                    {
                        customer_phone cph1 = new customer_phone();
                        cph1.customer_id = strId.Text;
                        cph1.phone_id = ph1.ID;
                        cph1.status = "פעיל";
                        cph1.type = ph1.phone_type;
                        dc.customer_phones.InsertOnSubmit(cph1);
                    }

                    dc.SubmitChanges();

                    wh_address adr = new wh_address(); // new address record

                    adr.city_name = areaCodeH.Text;
                    if (streetName.Text != "") adr.street_name = streetName.Text;
                    if (houseNum.Text != "") adr.house_num = int.Parse(houseNum.Text);
                    if (apartNum.Text != "") adr.appartment_num = int.Parse(apartNum.Text);
                    if (neighbName.Text != "") adr.neighborhood = neighbName.Text;
                    if (neighbName.Text != "") adr.zip_code = postCode.Text;
                    dc.wh_addresses.InsertOnSubmit(adr);
                    dc.SubmitChanges();

                    customer_address custaddr = new customer_address();//new customer address record

                    custaddr.customer_id = strId.Text;
                    custaddr.address_id = adr.ID;
                    custaddr.status = "פעיל";
                    dc.customer_addresses.InsertOnSubmit(custaddr);

                    dc.SubmitChanges();


                    nextButton.Enabled = true;


                }
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.custId = strId.Text;
              Form2 f = new Form2 ();
                f.Show();
               this.Hide();
        }


    }
}