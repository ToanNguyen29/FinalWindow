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
    public partial class FindAccountForm : Form
    {
        public FindAccountForm()
        {
            InitializeComponent();
        }

        private void FindAccountForm_Load(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "")
            {
                textBox_Username.PlaceholderText = "Type your Username";
                textBox_Username.PlaceholderForeColor = System.Drawing.Color.Black;
            }
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.PlaceholderText = "Type your OTP code";
                guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
            }

        }

        private void button_verify_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
        }
    }
}
