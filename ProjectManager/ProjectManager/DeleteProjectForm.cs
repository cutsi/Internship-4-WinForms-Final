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
    public partial class DeleteProjectForm : Form
    {
        public DeleteProjectForm()
        {
            InitializeComponent();
            foreach (var project in DataBaseProjects.ListProjects)
            {
                projectCheckBox.Items.Add(project);
            }
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            foreach (var project in projectCheckBox.CheckedItems)
            {
                DataBaseProjects.ListProjects.Remove(DataBaseProjects.GetProject(project.ToString()));
            }
            Refresh();
            
        }
        private new void Refresh()
        {
            projectCheckBox.Items.Clear();

            foreach (var project in DataBaseProjects.ListProjects)
            {
                projectCheckBox.Items.Add(project);
            }
        }
    }
}
