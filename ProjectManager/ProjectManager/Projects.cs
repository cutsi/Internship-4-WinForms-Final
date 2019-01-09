using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure;
namespace ProjectManager
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
            Project_Load();
            
        }

        private void Project_Load()
        {
            foreach (var project in Data.AllProjects)
            {
                listBox1.Items.Add(project.Name);
            }
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
