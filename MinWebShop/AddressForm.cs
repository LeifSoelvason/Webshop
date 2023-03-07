using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinWebShop
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txt_addressID.Text = txt_city.Text = txt_country.Text = txt_customerid.Text = txt_postalcode.Text = txt_search.Text = txt_streetname.Text = txt_streetnumber.Text = "";

        }

        private void btn_newaddress_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_streetnumber.Text, out int streetnumber))
            {
                MessageBox.Show("Streetnumber must be an integer.");
                return;
            }

            if (!int.TryParse(txt_postalcode.Text, out int postalcode))
            {
                MessageBox.Show("Postalcode must be an integer.");
                return;
            }

            if (!int.TryParse(txt_customerid.Text, out int customerid))
            {
                MessageBox.Show("Postalcode must be an integer.");
                return;
            }

            Address db = new Address();
            var input = db.New_Address(txt_streetname.Text, streetnumber, postalcode, txt_city.Text,txt_country.Text, customerid);

            Clear();
        }
    }
}
