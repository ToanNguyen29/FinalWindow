using FinalWindow.Database;
using FinalWindow.Model;
using FinalWindow.View.Manager.WorkerCRUD;
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
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        

        private void button_resetFix_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var fixerData = context.Users.OfType<FixWorker>()
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



                    dataGridView_listFixWorker.DataSource = fixerData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_addFixWorker_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm();
            addWorkerForm.Show();
            addWorkerForm.comboBox_typeWorker.SelectedIndex = 0;
        }

        private void button_addKeepWorker_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm();
            addWorkerForm.Show();
            addWorkerForm.comboBox_typeWorker.SelectedIndex = 1;
        }

        private void button_resetKeep_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var keeperData = context.Users.OfType<KeepWorker>()
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



                    dataGridView_listKeepWorker.DataSource = keeperData;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_updateFixWorker_Click(object sender, EventArgs e)
        {
            UpdateWorkerForm updateWorkerForm = new UpdateWorkerForm();
            updateWorkerForm.Show();
        }
    }
}
