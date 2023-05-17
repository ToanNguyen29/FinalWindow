using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Customer;
using FinalWindow.View.Director;
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
    public partial class CustomerMainForm : Form
    {
        private static int cusID;
        public static int CusID { get => cusID; set => cusID = value; }
        public CustomerMainForm()
        {
            InitializeComponent();
        }

        

        private void button_editInformation_Click(object sender, EventArgs e)
        {
            CustomerEditInformationForm editInformationForm = new CustomerEditInformationForm();
            editInformationForm.Show();
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            loadProfile();
            //DatabaseContext context = new DatabaseContext();
            //var cus = context.Users.OfType<Customer>().Where(t=>t.ID==cusID).FirstOrDefault();
            //if(cus.picture != null)
            //{
            //    byte[] imageData = (byte[])cus.picture;
            //    using (MemoryStream ms = new MemoryStream(imageData))
            //    {
            //        pictureBox_profile.Image = Image.FromStream(ms);
            //    }
            //}
            

            //label_username.Text = cus.username;
            //label_firstName.Text = cus.firstName;
            //label_lastName.Text = cus.lastName;
            //if (cus.gender == null)
            //{
            //    return;
            //}
            //else
            //{
            //    label_gender.Text = cus.gender;
            //}

            //if (cus.birthday == null)
            //{
            //    return;
            //}
            //else
            //{
            //    label_birthDate.Text = cus.birthday.Value.Date.ToString("dd/MM/yyyy");
            //}
            //label_email.Text = cus.email;
            //label_phone.Text = cus.phone;
            //label_address.Text = cus.address;



        }
        void loadProfile()
        {
            DatabaseContext context = new DatabaseContext();
            var cus = context.Users.OfType<Customer>().Where(t => t.ID == cusID).FirstOrDefault();
            if (cus.picture != null)
            {
                byte[] imageData = (byte[])cus.picture;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox_profile.Image = Image.FromStream(ms);
                }
            }

            label_username.Text = cus.username;
            label_firstName.Text = cus.firstName;
            label_lastName.Text = cus.lastName;
            if(cus.gender == null)
            {
                return;
            }
            else
            {
                label_gender.Text = cus.gender;
            }
            
            if(cus.birthday == null)
            {
                return;
            }
            else
            {
                label_birthDate.Text = cus.birthday.Value.Date.ToString("dd/MM/yyyy");
            }
            label_email.Text = cus.email;
            label_phone.Text = cus.phone;
            label_address.Text = cus.address;
        }

        private void tabPage_profile_Click(object sender, EventArgs e)
        {

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            loadProfile();
        }
    }
}
