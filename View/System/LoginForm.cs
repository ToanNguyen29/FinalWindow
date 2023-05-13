using FinalWindow.Database;
using FinalWindow.Model;
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
        private static User user;

        internal static User User { get => user; set => user = value; }

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
            DatabaseContext databaseContext = new DatabaseContext();

            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            string role = comboBox_role.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select your role.");
                return;
            }

            var checkUser = databaseContext.Users.Where(t => t.username == username && t.password == password).Count();

            if (role == "Director")
            {
                if (checkUser > 0)
                {
                    user = databaseContext.Users.OfType<Director>().Where(f => f.username == username).FirstOrDefault();
                    // Login successful, show the main form
                    DirectorMainForm mainFormm = new DirectorMainForm();
                    mainFormm.Show();

                }
            }  
            
            else if(role == "Manager")
            {
                if (checkUser > 0)
                {
                    user = databaseContext.Users.OfType<Manager>().Where(f => f.username == username).FirstOrDefault();
                    // Login successful, show the main form
                    ManagerMainForm mainFormm = new ManagerMainForm();
                    mainFormm.Show();

                }
            }

            else if (role == "Customer")
            {
                if (checkUser > 0)
                {
                    user = databaseContext.Users.OfType<Customer>().Where(f => f.username == username).FirstOrDefault();
                    // Login successful, show the main form
                    ManagerMainForm mainFormm = new ManagerMainForm();
                    mainFormm.Show();

                }
            }

            else if (role == "FixWorker")
            {
                if (checkUser > 0)
                {
                    user = databaseContext.Users.OfType<FixWorker>().Where(f => f.username == username).FirstOrDefault();
                    // Login successful, show the main form
                    FixWorkerMainForm mainFormm = new FixWorkerMainForm();
                    mainFormm.Show();

                }
            }

            else 
            {
                if (checkUser > 0)
                {
                    user = databaseContext.Users.OfType<KeepWorker>().Where(f => f.username == username).FirstOrDefault();
                    // Login successful, show the main form
                    KeepWorkerMainForm mainFormm = new KeepWorkerMainForm();
                    mainFormm.Show();
                }
            }
            

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
