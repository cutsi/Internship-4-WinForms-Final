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
            /*foreach (var project in DataBaseRelations.RelationList)
            {
                listBox1.Items.Add(project.ProjectName);
            }*/
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProject_Click(object sender, EventArgs e)
        {
            var addProject = new AddProjectForm();
            addProject.ShowDialog();
        }

        private void OverviewProject_Click(object sender, EventArgs e)
        {
            var overviewWindow = new Overview_project();
            overviewWindow.ShowDialog();
        }

        private void DeleteProject_Click(object sender, EventArgs e)
        {
            var deleteWindow = new DeleteProjectForm();
            deleteWindow.ShowDialog();
        }
    }
}
