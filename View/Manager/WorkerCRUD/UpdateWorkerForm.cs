using FinalWindow.Database;
using FinalWindow.View.Director;
using FinalWindow.View.Manager.ListWorker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow.View.Manager.WorkerCRUD
{
    public partial class UpdateWorkerForm : Form
    {
        string temp = null;
        public UpdateWorkerForm()
        {
            InitializeComponent();
        }

        private void button_selectManager_Click(object sender, EventArgs e)
        {
            if(comboBox_typeWorker.SelectedIndex == 0)
            {
                ListFixWorkerForm listFixWorkerForm = new ListFixWorkerForm();
                listFixWorkerForm.Show();
                this.Hide();
            }
            else if(comboBox_typeWorker.SelectedIndex == 1)
            {
                ListKeepWorkerForm listKeepWorkerForm = new ListKeepWorkerForm();
                listKeepWorkerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please choose type of worker to add", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext context = new DatabaseContext();
                if(comboBox_typeWorker.SelectedIndex == 0 )
                {
                    try
                    {

                        Model.FixWorker fixer = context.Users.OfType<Model.FixWorker>().Where(u => u.cardID == textBox_cardID.Text).FirstOrDefault();

                        if (fixer == null)
                        {
                            textBox_cardID.Text = temp;


                            MessageBox.Show("Don't exist this worker");

                        }
                        else
                        {

                            fixer.username = textBox_username.Text;
                            fixer.password = textBox_password.Text;
                            fixer.picture = UpdateManagerForm.converterDemo(pictureBox_image.Image);
                            fixer.facilityID = (int?)comboBox_facilityID.SelectedValue;
                            fixer.firstName = textBox_firstName.Text;
                            fixer.lastName = textBox_lastName.Text;
                            fixer.gender = comboBox_gender.SelectedItem.ToString();
                            fixer.birthday = birthday_picker.Value;
                            fixer.phone = textBox_phone.Text;
                            fixer.email = textBox_email.Text;
                            fixer.address = textBox_address.Text;

                            context.SaveChanges();
                            MessageBox.Show("Update successfully !!!");
                        }


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot update !!");
                    }
                }
                else if(comboBox_typeWorker.SelectedIndex == 1)
                {
                    try
                    {
                        Model.KeepWorker keeper = context.Users.OfType<Model.KeepWorker>().Where(u => u.cardID == textBox_cardID.Text).FirstOrDefault();

                        if (keeper == null)
                        {
                            textBox_cardID.Text = temp;


                            MessageBox.Show("Don't exist this worker");

                        }
                        else
                        {

                            keeper.username = textBox_username.Text;
                            keeper.password = textBox_password.Text;
                            keeper.picture = UpdateManagerForm.converterDemo(pictureBox_image.Image);
                            keeper.facilityID = (int?)comboBox_facilityID.SelectedValue;
                            keeper.firstName = textBox_firstName.Text;
                            keeper.lastName = textBox_lastName.Text;
                            keeper.gender = comboBox_gender.SelectedItem.ToString();
                            keeper.birthday = birthday_picker.Value;
                            keeper.phone = textBox_phone.Text;
                            keeper.email = textBox_email.Text;
                            keeper.address = textBox_address.Text;

                            context.SaveChanges();
                            MessageBox.Show("Update successfully !!!");
                        }


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot update !!");
                    }
                }
            }   
            catch
            {
                MessageBox.Show("Update fail");
            }
        }
    }
}
