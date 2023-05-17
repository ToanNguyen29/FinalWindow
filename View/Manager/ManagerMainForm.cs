﻿using FinalWindow.Database;
using FinalWindow.Model;
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

namespace FinalWindow
{
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        private static int manID;

        public static int ManID { get => manID; set => manID = value; }

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

        private void ManagerMainForm_Load(object sender, EventArgs e)
        {
            loadProfile();
        }

        void loadProfile()
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                var manager = context.Users.OfType<Manager>().Where(t => t.ID == manID).FirstOrDefault();
                if (manager.picture != null)
                {
                    byte[] imageData = (byte[])manager.picture;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox_managerImage.Image = Image.FromStream(ms);
                    }
                }
                label_username.Text = manager.username;
                label_firstName.Text = manager.firstName;
                label_lastName.Text = manager.lastName;
                label_gender.Text = manager.gender;
                label_birthDate.Text = manager.birthday.Value.Date.ToString("dd/MM/yyyy");
                label_email.Text = manager.email;
                label_phone.Text = manager.phone;
                label_address.Text = manager.address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
