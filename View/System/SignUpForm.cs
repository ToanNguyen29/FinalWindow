using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.Tool;
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
    public partial class SignUpForm : Form
    {
        private bool checkAccount = true;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            if (string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text) || string.IsNullOrEmpty(textBox_Password.Text) || string.IsNullOrEmpty(textBox_Username.Text))
            {
                MessageBox.Show("Please enter all information");
                return;
            }

            if (CheckInput.checkAlphabeticCharacters(textBox_firstName.Text) == false || CheckInput.checkAlphabeticCharacters(textBox_lastName.Text) == false)
            {

                MessageBox.Show("Your first name and last name have invalid characters");
                return;
            }

            if (textBox_Password.Text.Length < 8)
            {
                textBox_Password.Text = "";
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            if (String.Compare(textBox_Password.Text, textbox_retypePass.Text, false) != 0)
            {
                textBox_Password.Text = "";
                textbox_retypePass.Text = "";
                MessageBox.Show("Don't verify retype password");
                return;

            }


            if (checkAccount == false)
            {
                MessageBox.Show("Please satisfy the warnings");
                return;

            }

            User newCus = new Customer
            {
                username = textBox_Username.Text,
                password = textBox_Password.Text,
                firstName = textBox_firstName.Text,
                lastName = textBox_lastName.Text,
                email = textBox_email.Text,
                phone = textbox_phone.Text,
                active = true
            
            };
            try
            {
                context.Users.Add(newCus);
                context.SaveChanges();
                MessageBox.Show("Sign up successfully");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sign up failed");
            }


        }

        private void textBox_Username_Leave(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(textBox_Username.Text) == false)
            {
                DatabaseContext context = new DatabaseContext();
                var checkUser = context.Users.Where(t => t.username == textBox_Username.Text).Count();
                if (checkUser > 0)
                {
                    errorProvider_username.SetError(this.textBox_Username, "Username has been used");
                    checkAccount = false;
                }    
                
            }
        }

        private void textBox_email_Leave(object sender, EventArgs e)
        {
            if (CheckInput.checkEmailIsValid(textBox_email.Text) == false)
            {
                errorProvider_email.SetError(this.textBox_email, "Email is invalid");
                checkAccount = false;
            }
            else
            {
                DatabaseContext context = new DatabaseContext();
                var checkEmail = context.Users.Where(t => t.email == textBox_email.Text).Count();
                if (checkEmail > 0)
                {
                    errorProvider_email.SetError(this.textBox_email, "Email has been used");
                    checkAccount = false;
                }
            }
        }

        private void textbox_phone_Leave(object sender, EventArgs e)
        {
            if (CheckInput.IsPhoneNbr(textbox_phone.Text) == false)
            {
                errorProvider_phone.SetError(this.textbox_phone, "Phone is invalid");
                checkAccount = false;
            }
            else
            {
                DatabaseContext context = new DatabaseContext();
                var checkPhone = context.Users.Where(t => t.phone == textbox_phone.Text).Count();
                if (checkPhone > 0)
                {
                    errorProvider_phone.SetError(this.textbox_phone, "Phone has been used");
                    checkAccount = false;
                }
            }
        }
    }
}
