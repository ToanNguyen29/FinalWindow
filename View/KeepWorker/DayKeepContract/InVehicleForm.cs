using FinalWindow.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow.View.KeepWorker.DayKeepContract
{
    public partial class InVehicleForm : Form
    {
        public InVehicleForm()
        {
            InitializeComponent();
        }

        private static byte[] converterDemo(System.Drawing.Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        private void button_UploadPlate_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (.jpg;.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_ImagePlate.Image = new Bitmap(opnfd.FileName);
            }
            textBox_LicensePlate.Text = "1";
            textBox_Key.Text = GenerateRandomString(10);
        }

        private void button_In_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_Key.Text)|| string.IsNullOrEmpty(textBox_LicensePlate.Text)|| string.IsNullOrEmpty(comboBox_TypeVehicle.Text))
            {
                MessageBox.Show("Please choose type of vehicle or license plate");
                return;
            }    
            DatabaseContext context = new DatabaseContext();
            if(comboBox_TypeVehicle.Text=="Motor")
            {
                var vehicle = new Model.Motor
                {
                    licensePlates = textBox_LicensePlate.Text,
                    picture=converterDemo(pictureBox_ImagePlate.Image),
                    status ="In"
                };
            }  
            else if(comboBox_TypeVehicle.Text == "Car")
            {
                var vehicle = new Model.Car
                {
                    licensePlates = textBox_LicensePlate.Text,
                    picture = converterDemo(pictureBox_ImagePlate.Image),
                    status ="In"
                };
            }
            else
            {
                var vehicle = new Model.Truck
                {
                    licensePlates = textBox_LicensePlate.Text,
                    picture = converterDemo(pictureBox_ImagePlate.Image),
                    status = "In"
                };
            }
        }

        private void InVehicleForm_Load(object sender, EventArgs e)
        {

        }
    }
}

