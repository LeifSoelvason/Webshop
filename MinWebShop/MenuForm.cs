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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm x = new AccountForm();
            x.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm x = new CustomerForm();
            x.Show();
        }

        private void btn_address_Click(object sender, EventArgs e)
        {

        }
    }
}
