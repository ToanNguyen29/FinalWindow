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

namespace FinalWindow.View.Director
{
    public partial class ListManagerForm : Form
    {
        public ListManagerForm()
        {
            InitializeComponent();
        }

        private void ListManagerForm_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var managerData = context.Users
                    .Where(u => u is Manager)
                    .Select(u => new
                    {
                        FisrtName = u.firstName,
                        u.lastName,
                        u.gender,
                        u.phone
                    })
                    .ToList();

                

                dataGridView1.DataSource = managerData;
            }






        }
    }
}
