using MyLibrary;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinWebShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Validation customer = new Validation();

            var output = customer.PasswordValidation(txt_username.Text, txt_password.Text);

            if (output.Count == 1)
            {
                this.Hide();
                MenuForm x = new MenuForm();
                x.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect. Try again");
            }
        }
    }
}