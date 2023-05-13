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

namespace FinalWindow.View.Director
{
    public partial class AddFacilityForm : Form
    {
        public AddFacilityForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext db = new DatabaseContext();
                if (string.IsNullOrEmpty(textBox_facilityAddress.Text) ||
                    string.IsNullOrEmpty(textBox_quantityFix.Text) ||
                    string.IsNullOrEmpty(textBox_quantityKeep.Text))
                    
                {
                    MessageBox.Show("Please enter all information");
                    return;
                }

                


                var facility = new Facility
                {
                    address = textBox_facilityAddress.Text,
                    quatityFix = Convert.ToInt32(textBox_quantityFix.Text),
                    quantityKeep = Convert.ToInt32(textBox_quantityKeep.Text)

                };
                try
                {
                    db.Facilities.Add(facility);
                    db.SaveChanges();
                    MessageBox.Show("Add successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_facilityAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_quantityKeep_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_quantityFix_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFacilityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
