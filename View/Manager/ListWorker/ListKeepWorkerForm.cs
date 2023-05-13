using FinalWindow.Database;
using FinalWindow.View.Manager.WorkerCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow.View.Manager.ListWorker
{
    public partial class ListKeepWorkerForm : Form
    {
        public ListKeepWorkerForm()
        {
            InitializeComponent();
        }

        private void ListKeepWorkerForm_Load(object sender, EventArgs e)
        {
            loadData();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView_listKeepWorker.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        void loadData()
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var keeperData = context.Users
                        .OfType<Model.KeepWorker>()
                        .Select(u => new
                        {
                            Username = u.username,
                            Password = u.password,
                            FisrtName = u.firstName,
                            LastName = u.lastName,
                            Gender = u.gender,
                            Phone = u.phone,
                            Email = u.email,
                            Birthday = u.birthday,
                            CardID = u.cardID,
                            Address = u.address,
                            Picture = u.picture,
                            FacilityID = u.facilityID
                        })
                        .ToList();


                    dataGridView_listKeepWorker.DataSource = keeperData;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dataGridView_listKeepWorker_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateWorkerForm updateManagerForm = new UpdateWorkerForm();

                updateManagerForm.textBox_username.Text = dataGridView_listKeepWorker.CurrentRow.Cells[0].Value.ToString();
                updateManagerForm.textBox_password.Text = dataGridView_listKeepWorker.CurrentRow.Cells[1].Value.ToString();
                updateManagerForm.textBox_firstName.Text = dataGridView_listKeepWorker.CurrentRow.Cells[2].Value.ToString();
                updateManagerForm.textBox_lastName.Text = dataGridView_listKeepWorker.CurrentRow.Cells[3].Value.ToString();
                updateManagerForm.comboBox_gender.SelectedItem = dataGridView_listKeepWorker.CurrentRow.Cells[4].Value;
                updateManagerForm.textBox_phone.Text = dataGridView_listKeepWorker.CurrentRow.Cells[5].Value.ToString();
                updateManagerForm.textBox_email.Text = dataGridView_listKeepWorker.CurrentRow.Cells[6].Value.ToString();
                updateManagerForm.birthday_picker.Value = (DateTime)dataGridView_listKeepWorker.CurrentRow.Cells[7].Value;
                updateManagerForm.textBox_cardID.Text = dataGridView_listKeepWorker.CurrentRow.Cells[8].Value.ToString();
                updateManagerForm.textBox_address.Text = dataGridView_listKeepWorker.CurrentRow.Cells[9].Value.ToString();

                byte[] imageData = (byte[])dataGridView_listKeepWorker.CurrentRow.Cells[10].Value;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    updateManagerForm.pictureBox_image.Image = Image.FromStream(ms);
                }
                updateManagerForm.comboBox_facilityID.SelectedItem = dataGridView_listKeepWorker.CurrentRow.Cells[11].Value;

                updateManagerForm.comboBox_typeWorker.SelectedIndex = 1;
                updateManagerForm.Show();
            }
            catch (Exception ex)
            { System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
