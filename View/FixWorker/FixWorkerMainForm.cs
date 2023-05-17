using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Customer;
using FinalWindow.View.FixWorker;
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
    public partial class FixWorkerMainForm : Form
    {
        private static int fixID;
        public static int FixID { get => fixID; set => fixID = value; }

        public FixWorkerMainForm()
        {
            InitializeComponent();
        }

       

        private void FixWorkerMainForm_Load(object sender, EventArgs e)
        {
            loadProfile();
        }


        void loadProfile()
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                var fixer = context.Users.OfType<FixWorker>().Where(t => t.ID == fixID).FirstOrDefault();
                if (fixer.picture != null)
                {
                    byte[] imageData = (byte[])fixer.picture;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox_profile.Image = Image.FromStream(ms);
                    }
                }

                label_username.Text = fixer.username;
                label_firstName.Text = fixer.firstName;
                label_lastName.Text = fixer.lastName;
                label_gender.Text = fixer.gender;
                label_birthDate.Text = fixer.birthday.Value.Date.ToString("dd/MM/yyyy");
                label_email.Text = fixer.email;
                label_phone.Text = fixer.phone;
                label_address.Text = fixer.address;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_editInformation_Click(object sender, EventArgs e)
        {
            FixWorkerEditInformationForm form = new FixWorkerEditInformationForm();
            form.Show();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            loadProfile();
        }
    }
}
