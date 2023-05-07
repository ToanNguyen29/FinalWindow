using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Color panLoginColor;


        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label_createAccount_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            FindAccountForm findAccountForm = new FindAccountForm();
            findAccountForm.Show();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            CustomerMainForm customerMainForm = new CustomerMainForm();
            customerMainForm.Show();
        }
    }
}
