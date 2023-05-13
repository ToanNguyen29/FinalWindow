using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Director.List;
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
    public partial class UpdateFacilityForm : Form
    {
        string temp = null;
        public UpdateFacilityForm()
        {
            InitializeComponent();
        }

        private void button_selectFacility_Click(object sender, EventArgs e)
        {
            ListFacilityForm listFacilityForm = new ListFacilityForm();
            listFacilityForm.Show();
            this.Hide();
        }

        private void button_updateFacility_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                try
                {

                    Facility facility = context.Facilities.Where(u => u.address == textBox_facilityAddress.Text).FirstOrDefault();

                    if (facility == null)
                    {
                        textBox_facilityAddress.Text = temp;


                        MessageBox.Show("Don't exist this facility");

                    }
                    else
                    {
                        facility.address = textBox_facilityAddress.Text;
                        facility.quatityFix = Convert.ToInt32(textBox_quantityFix.Text);
                        facility.quantityKeep = Convert.ToInt32(textBox_quantityFix.Text);    
                        

                        context.SaveChanges();
                        MessageBox.Show("Update successfully !!!");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot update !!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Update fail");
            }
        }
    }
}
