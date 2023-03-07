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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txt_customerid.Text = txt_accountname.Text = txt_firstname.Text = txt_lastname.Text = "";

        }

        private void btn_newaccount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_customerid.Text, out int customerID))
            {
                MessageBox.Show("CustomerID must be an integer.");
                return;
            }

            Account db = new Account();
            var input = db.New_Account(customerID,txt_accountname.Text, txt_firstname.Text, txt_lastname.Text);
         
            Clear();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accountlist_Click(object sender, EventArgs e)
        {
            Account db = new Account();

            var output = db.GetAccountList();
            dataGridView1.DataSource = output;

            Clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Account db = new Account();

            var output = db.GetAccountByLastname(txt_search.Text);
            dataGridView1.DataSource = output;
            Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_accountID.Text, out int AccountID))
            {
                MessageBox.Show("AccountID must be an integer.");
                return;
            }

            Account db = new Account();
            db.Update(AccountID, txt_accountname.Text, txt_firstname.Text, txt_lastname.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_accountID.Text, out int accountID))
            {
                MessageBox.Show("CustomerID must be an integer.");
                return;
            }

            Account db = new Account();

            var output = db.Delete(accountID);
            dataGridView1.DataSource = output;
            Clear();
        }
    }
}
