using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Director;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FinalWindow
{
    public partial class DirectorMainForm : Form
    {
        public DirectorMainForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void loadData()
        {

        }

        private void button_resetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var managerData = context.Users.OfType<Manager>()
                       // .Where(u => u.cardID)
                        .Select(u => new
                        {
                            CardID = u.cardID,
                            FisrtName = u.firstName,
                            LastName = u.lastName,
                            Gender = u.gender,
                            Phone = u.phone,
                            Birthday = u.birthday

                            

                        })
                        .ToList();



                    dataGridView_listManager.DataSource = managerData;
                }
            } catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void tabControl_director_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //using (var context = new DatabaseContext())
            //{
            //    var managerData = context.Users
            //        .Where(u => u is Manager)
            //        .Select(u => new
            //        {
            //            FisrtName = u.firstName,
            //            LastName = u.lastName,
            //            Gender = u.gender,
            //            Phone = u.phone,
            //            Birthday = u.birthday

            //        })
            //        .ToList();



            //    dataGridView_listManager.DataSource = managerData;
            //}
        }

        private void DirectorMainForm_Load(object sender, EventArgs e)
        {
            // Get a reference to the initially selected tab page
            TabPage selectedTabPage = tabPage_management;

            // Check if the initially selected tab page contains a DataGridView
            foreach (System.Windows.Forms.Control control in selectedTabPage.Controls)
            {
                if (control is DataGridView dataGridView)
                {
                    // Load the data source for the DataGridView

                    using (var context = new DatabaseContext())
                    {
                        var managerData = context.Users
                            .Where(u => u is Manager)
                            .Select(u => new
                            {
                                FisrtName = u.firstName,
                                LastName = u.lastName,
                                Gender = u.gender,
                                Phone = u.phone,
                                Birthday = u.birthday

                            })
                            .ToList();



                        dataGridView_listManager.DataSource = managerData;
                        break;
                    }
                }
            }


            if(selectedTabPage == tabPage_facility)
            {
                foreach (System.Windows.Forms.Control control in selectedTabPage.Controls)
                {
                    if (control is DataGridView dataGridView)
                    {
                        // Load the data source for the DataGridView

                        using (var context = new DatabaseContext())
                        {
                            var facilityData = context.Facilities
                                .Select(f => new
                                {
                                    Address = f.address,
                                    QuantityFix = f.quatityFix,
                                    QuantityKeep = f.quantityKeep

                                })
                                .ToList();



                            dataGridView_listFacility.DataSource = facilityData;
                        }
                    }
                }
            }
        }

        private void button_resetFacility_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var facilityData = context.Facilities
                        .Select(f => new
                        {
                            Address = f.address,
                            QuantityFix = f.quatityFix,
                            QuantityKeep = f.quantityKeep

                        })
                        .ToList();



                    dataGridView_listFacility.DataSource = facilityData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_addFacility_Click(object sender, EventArgs e)
        {
            AddFacilityForm addFacilityForm = new AddFacilityForm();
            addFacilityForm.Show();
        }

        private void dataGridView_listFacility_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_addManager_Click(object sender, EventArgs e)
        {
            AddManagerForm addManagerForm = new AddManagerForm();
            addManagerForm.Show();
        }
    }
}
