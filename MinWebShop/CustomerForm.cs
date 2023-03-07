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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webshop_DBDataSet2.Customer' table. You can move, or remove it, as needed.
                     
        }

        void Clear()
        {
            txt_firstname.Text = txt_lastname.Text = txt_username.Text = txt_password.Text = "";

        }

        private void btn_newcustomer_Click(object sender, EventArgs e)
        {
            Customer db = new Customer();

            var output = db.New_Customer(txt_firstname.Text, txt_lastname.Text, txt_username.Text, txt_password.Text);
            dataGridView1.DataSource = output;
            Clear();


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_customerlist_Click(object sender, EventArgs e)
        {
            Customer db = new Customer();

            var output = db.GetCustomerList();
            dataGridView1.DataSource = output;

            Clear();                      
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Customer db = new Customer();

            var output = db.GetCustomerByLastname(txt_search.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_customerID.Text, out int customerID))
            {
                MessageBox.Show("CustomerID must be an integer.");
                return;
            }

            Customer db = new Customer();
            db.Update(customerID,txt_firstname.Text, txt_lastname.Text, txt_username.Text , txt_password.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_customerID.Text, out int customerID))
            {
                MessageBox.Show("CustomerID must be an integer.");
                return;
            }

            Customer db = new Customer();

            var output = db.Delete(customerID);
            dataGridView1.DataSource = output;
            Clear();
        }
    }
}
