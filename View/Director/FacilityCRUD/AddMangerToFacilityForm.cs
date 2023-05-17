using FinalWindow.Database;
using FinalWindow.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindow.View.Director.FacilityCRUD
{
    public partial class AddMangerToFacilityForm : Form
    {
        public AddMangerToFacilityForm()
        {
            InitializeComponent();
        }

        private void AddMangerToFacilityForm_Load(object sender, EventArgs e)
        {
          DatabaseContext context = new DatabaseContext();
            var managerData = context.Users
                        .OfType<Model.Manager>()
                        .Select(u => new
                        {
                            FisrtName = u.firstName,
                            LastName = u.lastName,
                            Gender = u.gender,
                            Phone = u.phone,
                            Email = u.email,
                            Birthday = u.birthday,
                            CardID = u.cardID,
                            Address = u.address,
                        })
                        .ToList();


            dataGridView_listManager.DataSource = managerData;

        }

        private void dataGridView_listManager_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure add this manager?", "Add manager to facility", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DatabaseContext context = new DatabaseContext();
                var manager = context.Users.OfType<Model.Manager>().Where(t => t.cardID == dataGridView_listManager.CurrentRow.Cells[6].Value.ToString()).FirstOrDefault();
                AddFacilityForm.IdManager = manager.ID;
                MessageBox.Show("Add manager completed");
            }
               

            

            
            
        }
    }
}
