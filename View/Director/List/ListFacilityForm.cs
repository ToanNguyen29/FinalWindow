using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Director.FacilityCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow.View.Director.List
{
    public partial class ListFacilityForm : Form
    {
        public ListFacilityForm()
        {
            InitializeComponent();
        }

        private void ListFacilityForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var facilityData = context.Facilities
                        .Select(u => new
                        {
                            QuantityKeep = u.quantityKeep,
                            QuantityFix = u.quatityFix,
                            Address = u.address
                        })
                        .ToList();



                    dataGridView_listFacility.DataSource = facilityData;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView_listFacility_Click(object sender, EventArgs e)
        {
            UpdateFacilityForm updateFacilityForm = new UpdateFacilityForm();
            updateFacilityForm.textBox_facilityAddress.Text = dataGridView_listFacility.CurrentRow.Cells[0].Value.ToString();
            updateFacilityForm.textBox_quantityFix.Text = dataGridView_listFacility.CurrentRow.Cells[1].Value.ToString();
            updateFacilityForm.textBox_quantityKeep.Text = dataGridView_listFacility.CurrentRow.Cells[2].Value.ToString();

            updateFacilityForm.Show();

        }
    }
}
