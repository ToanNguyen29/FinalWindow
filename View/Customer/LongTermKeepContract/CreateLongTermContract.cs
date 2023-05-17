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
using FinalWindow.Model;

namespace FinalWindow.View.Customer.LongTermKeepContract
{
    public partial class CreateLongTermContract : Form
    {
        public CreateLongTermContract()
        {
            InitializeComponent();
        }

        private void CreateLongTermContract_Load(object sender, EventArgs e)
        {
            NumericUpDown_period.Minimum = 1;
            DatabaseContext context = new DatabaseContext();
            
            var cus = context.Users.OfType<Model.Customer>().Where(t => t.ID == CustomerMainForm.CusID).FirstOrDefault();
            textBox_firstName.Text = cus.firstName;
            textBox_lastName.Text = cus.lastName;
            textbox_phone.Text = cus.phone;
            textBox_email.Text = cus.email;
            var rule = context.Rules.Where(t => t.nameContract == "LongTermContract").FirstOrDefault();
            textBox_Rule.Text = rule.description;
            using (DatabaseContext db = new DatabaseContext())
            {
                comboBox_facility.DataSource = db.Facilities.ToList();
                comboBox_facility.DisplayMember = "address";
                comboBox_facility.ValueMember = "ID";
                comboBox_facility.SelectedItem = null;
            }

        }

        private void comboBox_TypePeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_TypePeriod.Text == "Week")
            {
                NumericUpDown_period.Maximum = 3;
            } 
            else if (comboBox_TypePeriod.Text == "Month")
            {
                NumericUpDown_period.Maximum = 12;
            }    
        }

        private float CalculateFee()
        {
            DatabaseContext context = new DatabaseContext();
            var fee = context.FeeKeeps.Where(t => t.typeVehicle == comboBox_TypeVehicle.Text).FirstOrDefault();
            float result = 0;
            if(comboBox_TypePeriod.Text == "Week")
            {
                result = float.Parse(fee.weekPrice.ToString()) * float.Parse(NumericUpDown_period.Value.ToString());

            }
            else
            {
                result = float.Parse(fee.monthPrice.ToString()) * float.Parse(NumericUpDown_period.Value.ToString());

            }
            return result;
        }

        private void button_CalculatePrice_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboBox_facility.Text) || string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(textbox_phone.Text)
                || string.IsNullOrEmpty(textBox_branchVehicle.Text) || string.IsNullOrEmpty(textBox_nameVehicle.Text) || string.IsNullOrEmpty(textBox_licensePlate.Text) || string.IsNullOrEmpty(comboBox_TypeVehicle.Text)
                || string.IsNullOrEmpty(comboBox_TypePeriod.Text))
            {
                MessageBox.Show("Please enter all information");
                return;
            }
            textBox_Fee.Text = CalculateFee().ToString();          
        }

        private void button_CreateLongContract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_facility.Text) || string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(textbox_phone.Text)
                || string.IsNullOrEmpty(textBox_branchVehicle.Text) || string.IsNullOrEmpty(textBox_nameVehicle.Text) || string.IsNullOrEmpty(textBox_licensePlate.Text) || string.IsNullOrEmpty(comboBox_TypeVehicle.Text)
                || string.IsNullOrEmpty(comboBox_TypePeriod.Text))
            {
                MessageBox.Show("Please enter all information");
                return;
            }

            DatabaseContext context = new DatabaseContext();

            var checkVehicle = context.Vehicles.Where(t => t.licensePlates == textBox_licensePlate.Text && t.status == "In").Count();
            if(checkVehicle>0)
            {
                MessageBox.Show("Your license plate has alreally in my parking, please check again or call for us");
                return;
            }    

            var cus = context.Users.OfType<Model.Customer>().Where(t => t.ID == CustomerMainForm.CusID).FirstOrDefault();
            if (CheckInput.IsPhoneNbr(textbox_phone.Text) == false)
            {
                MessageBox.Show("Invalid phone number");
                return;
            }
            if (CheckInput.checkEmailIsValid(textBox_email.Text) == false)
            {
                MessageBox.Show("Invalid email");
                return;
            }
            var checkemail = context.Users.OfType<Model.Customer>().Where(t => t.ID != CustomerMainForm.CusID && t.email == textBox_email.Text).Count();
            if (checkemail > 0)
            {
                MessageBox.Show("Email has been used!!");
                return;
            }
            var checkphone = context.Users.OfType<Model.Customer>().Where(t => t.ID != CustomerMainForm.CusID && t.phone == textbox_phone.Text).Count();
            if (checkphone > 0)
            {
                MessageBox.Show("Phone has been used!!");
                return;
            }
            cus.firstName = textBox_firstName.Text;
            cus.lastName = textBox_lastName.Text;
            cus.email = textBox_email.Text;
            cus.phone = textbox_phone.Text;

            context.SaveChanges();

            try
            {
                Vehicle vehicle;
                if (comboBox_TypePeriod.Text == "Motor")
                {
                    vehicle = new Motor
                    {
                        name = textBox_nameVehicle.Text,
                        branch = textBox_branchVehicle.Text,
                        licensePlates = textBox_licensePlate.Text,


                    };
                }
                else if (comboBox_TypePeriod.Text == "Car")
                {
                    vehicle = new Car
                    {
                        name = textBox_nameVehicle.Text,
                        branch = textBox_branchVehicle.Text,
                        licensePlates = textBox_licensePlate.Text,

                    };
                }
                else
                {
                    vehicle = new Truck
                    {
                        name = textBox_nameVehicle.Text,
                        branch = textBox_branchVehicle.Text,
                        licensePlates = textBox_licensePlate.Text,

                    };
                }

                vehicle.status = "Out";
                context.Vehicles.Add(vehicle);
                context.SaveChanges();
                
                MessageBox.Show("Create contract fail");
                    
                
            }
            catch
            {
                MessageBox.Show("Create contract fail");
                return;
            }

            try
            {
                var vehicle = context.Vehicles.Where(t => t.licensePlates == textBox_licensePlate.Text).FirstOrDefault();
               
                var contract = new Model.LongTermKeepContract
                {
                    name = comboBox_TypePeriod + " contract",
                    rule = textBox_Rule.Text,
                    dateCreate = DateTime.Now,
                    facilityId = (int)comboBox_facility.SelectedValue,
                    customerID = CustomerMainForm.CusID,
                    status = "Booked",
                    fee = CalculateFee(),
                    period = float.Parse(NumericUpDown_period.Value.ToString())

                };

                if(comboBox_TypeVehicle.Text=="Car")
                {
                    contract.carID = vehicle.ID;
                }
                else if (comboBox_TypeVehicle.Text == "Motor")
                {
                    contract.motorID = vehicle.ID;
                }
                else
                {
                    contract.truckID=vehicle.ID;
                }

                if (comboBox_TypePeriod.Text == "Week")
                {
                    contract.typeContract = "Week";
                    contract.dateEnd = DateTime.Now.AddDays(7 * double.Parse(NumericUpDown_period.Value.ToString()));
                }
                else
                {
                    contract.typeContract = "Month";
                    contract.dateEnd = DateTime.Now.AddMonths(int.Parse(NumericUpDown_period.Value.ToString()));
                }


                
                context.Contracts.Add(contract);
                context.SaveChanges();
                
                MessageBox.Show("Create contract successfully");
            }
            catch
            {
                MessageBox.Show("Create contract fail");
                var vehicle = context.Vehicles.Where(t => t.licensePlates == textBox_licensePlate.Text).FirstOrDefault();
                context.Vehicles.Remove(vehicle);
                return;
            }

            

                
            
        }
    }
}
