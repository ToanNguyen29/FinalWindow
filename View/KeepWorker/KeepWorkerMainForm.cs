using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Customer;
using FinalWindow.View.KeepWorker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow
{
    public partial class KeepWorkerMainForm : Form
    {
        private static int keepID;
        public static int KeepID { get => keepID; set => keepID = value; }

        public KeepWorkerMainForm()
        {
            InitializeComponent();
        }

        

        private void button_addVehicle_Click(object sender, EventArgs e)
        {
            
        }

        private void button_resetVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var vehicleData = context.Vehicles
                        .Where(v => v is Motor)
                        .Select(v => new
                        {
                            VehicleName = v.name,
                            VehicleBranch = v.branch,
                            VehicleStatus = v.status



                        })
                        .ToList();



                    dataGridView_listVehicle.DataSource = vehicleData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void KeepWorkerMainForm_Load(object sender, EventArgs e)
        {
            loadProfile();
        }

        void loadProfile()
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                var keeper = context.Users.OfType<KeepWorker>().Where(t => t.ID == keepID).FirstOrDefault();
                if (keeper.picture != null)
                {
                    byte[] imageData = (byte[])keeper.picture;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox_profile.Image = Image.FromStream(ms);
                    }
                }

                label_username.Text = keeper.username;
                label_firstName.Text = keeper.firstName;
                label_lastName.Text = keeper.lastName;
                label_gender.Text = keeper.gender;
                label_birthDate.Text = keeper.birthday.Value.Date.ToString("dd/MM/yyyy");
                label_email.Text = keeper.email;
                label_phone.Text = keeper.phone;
                label_address.Text = keeper.address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_editInformation_Click(object sender, EventArgs e)
        {
            KeepWorkerEditInformationForm editInformationForm = new KeepWorkerEditInformationForm();
            editInformationForm.Show();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            loadProfile();
        }
    }
}
