using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Director;
using FinalWindow.View.Director.FacilityCRUD;
using FinalWindow.View.Director.List;
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

        private static int dirID;

        public static int DirID { get => DirID; set => DirID = value; }

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
            DatabaseContext db = new DatabaseContext();
           
            comboBox_facilityLong.DataSource = db.Facilities.ToList();
            comboBox_facilityLong.DisplayMember = "address";
            comboBox_facilityLong.ValueMember = "ID";
            comboBox_facilityLong.SelectedItem = null;
            
            comboBox_facilityLong.DataSource = db.Facilities.ToList();
            comboBox_facilityLong.DisplayMember = "address";
            comboBox_facilityLong.ValueMember = "ID";

            comboBox_facilityLong.SelectedItem = null;

            var managerData = db.Users
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

            var facilityData = db.Facilities
                                .Select(f => new
                                {
                                    Address = f.address,
                                    QuantityFix = f.quatityFix,
                                    QuantityKeep = f.quantityKeep

                                })
                                .ToList();

            dataGridView_listFacility.DataSource = facilityData;



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

        private void button_editManager_Click(object sender, EventArgs e)
        {
            UpdateManagerForm updateManagerForm = new UpdateManagerForm();
            updateManagerForm.Show();
        }

        private void button_updateFacility_Click(object sender, EventArgs e)
        {
            UpdateFacilityForm updateFacilityForm = new UpdateFacilityForm();
            updateFacilityForm.Show();
        }

        private void dataGridView_listFacility_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button_updateFixWorker_Click(object sender, EventArgs e)
        {

        }

        private void button_resetFix_Click(object sender, EventArgs e)
        {

        }

        private void button_addFixWorker_Click(object sender, EventArgs e)
        {

        }

        private void button_resetKeep_Click(object sender, EventArgs e)
        {

        }

        private void button_addKeepWorker_Click(object sender, EventArgs e)
        {

        }

        private void button_ShowLong_Click(object sender, EventArgs e)
        {

        }

        private void LongTermContract_Click(object sender, EventArgs e)
        {
            
        }

        private void LoanContract_Click(object sender, EventArgs e)
        {
            
        }

        private void button_setRuleLong_Click(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            var rule = context.Rules.Where(t => t.nameContract == "LongTermContract").FirstOrDefault();
            rule.description = textBox_ruleLong.Text;
        }

        private void button_setRuleLoan_Click(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            var rule = context.Rules.Where(t => t.nameContract == "LoanContract").FirstOrDefault();
            rule.description = textBox_ruleLoan.Text;
        }

        private void button_showListLoan_Click(object sender, EventArgs e)
        {
            ListLoanContract list = new ListLoanContract();
            list.Show();
        }
    }
}
