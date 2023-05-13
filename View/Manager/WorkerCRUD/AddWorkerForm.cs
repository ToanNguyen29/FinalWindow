using FinalWindow.Database;
using FinalWindow.Tool;
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
    public partial class AddWorkerForm : Form
    {

        string[] checkUser = { "fuck", "Nigger", "Twat", "Ass" };
        public AddWorkerForm()
        {
            InitializeComponent();
        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            comboBox_facilityID.DataSource = context.Facilities.ToList();
            comboBox_facilityID.DisplayMember = "address";
            comboBox_facilityID.ValueMember = "ID";
            comboBox_facilityID.SelectedItem = null;
        }

        private void pictureBox_image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if ((opf.ShowDialog() == DialogResult.OK))
                {
                    pictureBox_image.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseContext db = new DatabaseContext();
                if (string.IsNullOrEmpty(textBox_cardID.Text) ||
                    //string.IsNullOrEmpty(textBox_facilityID.Text) ||
                    string.IsNullOrEmpty(textBox_firstName.Text) ||
                    string.IsNullOrEmpty(textBox_lastName.Text) ||
                    string.IsNullOrEmpty(textBox_phone.Text) ||
                    string.IsNullOrEmpty(textBox_email.Text) ||
                    string.IsNullOrEmpty(textBox_address.Text) ||
                    (comboBox_gender.SelectedItem == null))
                {
                    MessageBox.Show("Please enter all information");
                    return;
                }

                if (CheckInput.checkAlphabeticCharacters(textBox_firstName.Text) == false)
                {

                    MessageBox.Show("Your first name has invalid characters");
                    return;
                }
                else
                {
                    for (int i = 0; i < checkUser.Length; i++)
                    {
                        if (String.Compare(textBox_firstName.Text, checkUser[i], true) == 0)
                        {
                            MessageBox.Show("First name is a sensetive word");
                            textBox_firstName.Text = "";
                            return;
                        }

                    }
                }
                if (CheckInput.checkAlphabeticCharacters(textBox_lastName.Text) == false)
                {

                    MessageBox.Show("Your last name has invalid characters");
                    return;
                }
                else
                {
                    for (int i = 0; i < checkUser.Length; i++)
                    {
                        if (String.Compare(textBox_lastName.Text, checkUser[i], true) == 0)
                        {
                            MessageBox.Show("Last name is a sensetive word");
                            textBox_lastName.Text = "";
                            return;
                        }

                    }
                }

                if (CheckInput.checkEmailIsValid(textBox_email.Text) == false)
                {
                    MessageBox.Show("Email is invalid");
                    return;
                }

                if (CheckInput.IsPhoneNbr(textBox_phone.Text) == false)
                {
                    MessageBox.Show("Phone number is invalid");
                    return;
                }

                //if (CheckInput.CheckYear(birthday_picker.Text) == false)
                //{
                //    MessageBox.Show("Student is invalid age");
                //    return;
                //}

                if (pictureBox_image == null)
                {
                    MessageBox.Show("Please choose picture");
                    return;
                }

                var checkcardID = db.Users.OfType<Model.Manager>().Where(t => t.cardID == textBox_cardID.Text).Count();

                if (checkcardID > 0)
                {
                    MessageBox.Show("Card ID already exist.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if(comboBox_typeWorker.SelectedIndex == 0)
                {
                    var fixWorker = new Model.FixWorker
                    {
                        cardID = textBox_cardID.Text,
                        facilityID = Convert.ToInt32(comboBox_facilityID.SelectedValue.ToString()),
                        username = textBox_username.Text,
                        password = textBox_password.Text,
                        firstName = textBox_firstName.Text,
                        lastName = textBox_lastName.Text,
                        gender = comboBox_gender.SelectedItem.ToString(),
                        phone = textBox_phone.Text,
                        email = textBox_email.Text,
                        address = textBox_address.Text,
                        birthday = birthday_picker.Value.Date,
                        picture = converterDemo(pictureBox_image.Image)

                    };
                    try
                    {
                        db.Users.Add(fixWorker);
                        db.SaveChanges();
                        MessageBox.Show("Add successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else if (comboBox_typeWorker.SelectedIndex == 1)
                {
                    var keepWorker = new Model.KeepWorker
                    {
                        cardID = textBox_cardID.Text,
                        facilityID = Convert.ToInt32(comboBox_facilityID.SelectedValue.ToString()),
                        username = textBox_username.Text,
                        password = textBox_password.Text,
                        firstName = textBox_firstName.Text,
                        lastName = textBox_lastName.Text,
                        gender = comboBox_gender.SelectedItem.ToString(),
                        phone = textBox_phone.Text,
                        email = textBox_email.Text,
                        address = textBox_address.Text,
                        birthday = birthday_picker.Value.Date,
                        picture = converterDemo(pictureBox_image.Image)

                    };
                    try
                    {
                        db.Users.Add(keepWorker);
                        db.SaveChanges();
                        MessageBox.Show("Add successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Please choose type of worker to add", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
            }
            catch (Exception ex)
            { MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
