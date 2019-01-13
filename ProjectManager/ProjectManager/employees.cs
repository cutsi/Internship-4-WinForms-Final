using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
            
        }

        private void employees_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addEmp = new AddEmployeeForm();
            addEmp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var delEmp = new DeleteEmployee();
            delEmp.ShowDialog();
        }

        private void Overview_Click(object sender, EventArgs e)
        {
            var overviewEmp = new Overview();
            overviewEmp.ShowDialog();
        }
    }
}
