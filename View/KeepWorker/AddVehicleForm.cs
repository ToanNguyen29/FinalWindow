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

namespace FinalWindow.View.KeepWorker
{
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext db = new DatabaseContext();
                




                var motor = new Motor
                {
                    name = textBox_vehicleName.Text,
                    branch = textBox_vehicleBranch.Text,
                    status = textbox_status.Text

                };
                try
                {
                    db.Vehicles.Add(motor);
                    db.SaveChanges();
                    MessageBox.Show("Add successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
