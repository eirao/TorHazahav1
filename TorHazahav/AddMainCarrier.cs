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
    public partial class AddMainCarrier : Form
    {
        tzDataContext dc;
        public AddMainCarrier()
        {
            InitializeComponent();
            dc = connection.getDataContextInstance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customerId = (from c in dc.Customers // get the record from the db 
                              where c.Id == Program.custId
                              select c).FirstOrDefault();

            if (customerId != null)
            {

                contact cont = new contact(); //create new customer contact record of family type
                cont.first_name = strFName.Text;
                cont.last_name = strLName.Text;
                dc.contacts.InsertOnSubmit(cont);
                dc.SubmitChanges();

                phone ph = new phone(); //create new phone record
                if (phoneNumM.Text != "" && areaCodeM.Text != "")
                {
                    ph.phone_type = "נייד";
                    ph.area_code = areaCodeM.Text;
                    ph.phone_num = phoneNumM.Text;
                    dc.phones.InsertOnSubmit(ph);
                    //   dc.SubmitChanges();
                }

                dc.SubmitChanges();

                if (ph != null)
                {
                    contact_phone cph = new contact_phone();
                    cph.contact_id = cont.ID;
                    cph.phone_id = ph.ID;
                    cph.status = "פעיל";
                    cph.type = ph.phone_type;
                    dc.contact_phones.InsertOnSubmit(cph);
                }


                dc.SubmitChanges();

                wh_address adr = new wh_address(); // new address record

                adr.city_name = cityName.Text;
                if (streetName.Text != "") adr.street_name = streetName.Text;
                if (houseNum.Text != "") adr.house_num = int.Parse(houseNum.Text);
                if (apartNum.Text != "") adr.appartment_num = int.Parse(apartNum.Text);
                if (postCode.Text != "") adr.zip_code = postCode.Text;
                dc.wh_addresses.InsertOnSubmit(adr);
                dc.SubmitChanges();

                contact_address contaddr = new contact_address();//new contact address record

                contaddr.contact_id = cont.ID;
                contaddr.address_id = adr.ID;
                contaddr.status = "פעיל";
                dc.contact_addresses.InsertOnSubmit(contaddr);

                dc.SubmitChanges();

                customer_contact custcont = new customer_contact(); //add new contact to customer
                custcont.customer_id = Program.custId;
                custcont.contact_id = cont.ID;
                custcont.type = "מטפל ראשי";
                custcont.status = "פעיל";
                dc.customer_contacts.InsertOnSubmit(custcont);
                dc.SubmitChanges();

            }
        }
    }

}
