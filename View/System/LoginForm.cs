using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (string.IsNullOrEmpty(textBox_Username.Text))
            {
                FindAccountForm findAccountForm = new FindAccountForm();
                findAccountForm.Show();
            }
            else
            {
                DatabaseContext context = new DatabaseContext();
                FindAccountForm findAccountForm = new FindAccountForm();
                findAccountForm.textBox_Username.Text = textBox_Username.Text;
                var user = context.Users.Where(t => t.username == textBox_Username.Text).FirstOrDefault();
                findAccountForm.textBox_email.Text = user.email;
                findAccountForm.Show();
                
            }    
            
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext databaseContext = new DatabaseContext();

                string username = textBox_Username.Text;
                string password = textBox_Password.Text;
                string role = comboBox_role.SelectedIndex.ToString();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter your username and password.");
                    return;
                }

                if (comboBox_role.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select your role.");
                    return;
                }

                var checkUser = databaseContext.Users.Where(t => t.username == username && t.password == password).Count();

                if (role == "4")
                {
                    if (checkUser > 0)
                    {
                        Director director = databaseContext.Users.OfType<Director>().Where(f => f.username == username).FirstOrDefault();
                        // Login successful, show the main form
                        DirectorMainForm mainFormm = new DirectorMainForm();
                        DirectorMainForm.DirID = director.ID;

                        mainFormm.Show();


                    }
                }

                else if (role == "3")
                {
                    if (checkUser > 0)
                    {
                        Manager manager = databaseContext.Users.OfType<Manager>().Where(f => f.username == username).FirstOrDefault();
                        // Login successful, show the main form
                        ManagerMainForm mainFormm = new ManagerMainForm();
                        ManagerMainForm.ManID = manager.ID;
                        mainFormm.Show();

                    }
                }

                else if (role == "0")
                {
                    if (checkUser > 0)
                    {
                        Customer customer = databaseContext.Users.OfType<Customer>().Where(f => f.username == username).FirstOrDefault();
                        // Login successful, show the main form
                        CustomerMainForm customerMainFormm = new CustomerMainForm();
                        CustomerMainForm.CusID = customer.ID;
                        customerMainFormm.Show();

                    }
                }

                else if (role == "1")
                {
                    if (checkUser > 0)
                    {
                        FixWorker fixer = databaseContext.Users.OfType<FixWorker>().Where(f => f.username == username).FirstOrDefault();
                        // Login successful, show the main form
                        FixWorkerMainForm mainFormm = new FixWorkerMainForm();
                        FixWorkerMainForm.FixID = fixer.ID;
                        mainFormm.Show();

                    }
                }

                else if (role == "2")
                {
                    if (checkUser > 0)
                    {
                        KeepWorker keeper = databaseContext.Users.OfType<KeepWorker>().Where(f => f.username == username).FirstOrDefault();
                        // Login successful, show the main form
                        KeepWorkerMainForm mainFormm = new KeepWorkerMainForm();
                        KeepWorkerMainForm.KeepID = keeper.ID;
                        mainFormm.Show();
                    }
                }
                //else if(comboBox_role.SelectedItem ==  null)
                //{
                //    { MessageBox.Show("Please choose role to login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                //}
            }
            catch(Exception ex)
            {
                { MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            
            

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
