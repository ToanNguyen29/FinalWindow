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

namespace FinalWindow.View.Director.FacilityCRUD
{
    public partial class AddFacilityForm : Form
    {
        public AddFacilityForm()
        {
            InitializeComponent();
        }

        private static int idManager = -1;

        public static int IdManager { get => idManager; set => idManager = value; }

        private void button_addFacility_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext db = new DatabaseContext();
                if (string.IsNullOrEmpty(textBox_facilityAddress.Text))
                {
                    MessageBox.Show("Please enter all information");
                    return;
                }


                var facility = new Facility
                {
                    address = textBox_facilityAddress.Text,
                    quantityKeep = 0,
                    quatityFix = 0
                };

                    

                try
                {
                    db.Facilities.Add(facility);
                    db.SaveChanges();
                    if (idManager != -1)
                    {
                        var manager = db.Users.OfType<Model.Manager>().Where(t => t.ID == idManager).FirstOrDefault();
                        manager.facilityID = facility.ID;

                        db.SaveChanges();
                    }
                    MessageBox.Show("Add successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AddFacilityForm_Load(object sender, EventArgs e)
        {

        }

        private void AddFacilityForm_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddManagerToFacilityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseContext db = new DatabaseContext();
            var manager = db.Users.OfType<Model.Manager>().Where(t => t.ID == idManager).FirstOrDefault();
            // Update some data after the form is closed
            textBox_Manger.Text = manager.firstName + " " + manager.lastName;
        }

        private void button_addManager_Click(object sender, EventArgs e)
        {
            AddMangerToFacilityForm addM = new AddMangerToFacilityForm();
            addM.Show();
            addM.FormClosed += AddManagerToFacilityForm_FormClosed;
        }

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
