using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.KeepWorker;
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
    public partial class KeepWorkerMainForm : Form
    {
        public KeepWorkerMainForm()
        {
            InitializeComponent();
        }

        private void button_addVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.Show();
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
    }
}
