using FinalWindow.Database;
using FinalWindow.Model;
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

namespace FinalWindow.View.Customer.LoanContractForm
{
    public partial class CreateLoanContract : Form
    {
        public CreateLoanContract()
        {
            InitializeComponent();
        }

        private void load()
        {
            DatabaseContext context = new DatabaseContext();
            var cus = context.Users.OfType<Model.Customer>().Where(t => t.ID == CustomerMainForm.CusID).FirstOrDefault();
            textBox_firstName.Text = cus.firstName;
            textBox_lastName.Text = cus.lastName;
            textbox_phone.Text = cus.phone;
            textBox_email.Text = cus.email;
            var rule = context.Rules.Where(t => t.nameContract == "LoanContract").FirstOrDefault();
            label_Rule.Text = rule.description;

        }

        private void CreateLoanContract_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button_CreateContract_Click(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();


            if (string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text) || string.IsNullOrEmpty(textbox_phone.Text) || string.IsNullOrEmpty(textBox_email.Text))
            {
                MessageBox.Show("Please enter all information");
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
            DialogResult dialogResult = MessageBox.Show("Are you sure create this contract?", "Create contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                cus.firstName = textBox_firstName.Text;
                cus.lastName = textBox_lastName.Text;
                cus.email = textBox_email.Text;
                cus.phone = textbox_phone.Text;
                try
                {
                    context.SaveChanges();
                }
                catch
                {
                    
                }

                var contractLong = context.Contracts.OfType<Model.LongTermKeepContract>().Where(t => t.ID == LoanServiceForm.ContractID).FirstOrDefault();
                contractLong.status = "Rented";
                   
                var contract = new LoanContract
                {
                    name = "Loan Contract",
                    rule = label_Rule.Text,
                    dateCreate = DateTime.Now,
                    dateEnd= DateTime.Now.AddDays(double.Parse(LoanServiceForm.Period1)),
                    customerID= CustomerMainForm.CusID,
                    status = "Booked"
                };
                if(LoanServiceForm.VehicleType=="Car")
                {
                    contract.carID = LoanServiceForm.VehicleID;
                }
                else if (LoanServiceForm.VehicleType == "Truck")
                {
                    contract.truckID = LoanServiceForm.VehicleID;
                }
                else
                {
                    contract.motorID = LoanServiceForm.VehicleID;
                }

                try
                {
                    context.Contracts.Add(contract);
                    context.SaveChanges();
                    MessageBox.Show("Create loan contract successfully");
                }
                catch
                {
                    MessageBox.Show("Create fail");
                }
            }


        }

        private void button_CalculatePrice_Click(object sender, EventArgs e)
        {

        }
    }
}
