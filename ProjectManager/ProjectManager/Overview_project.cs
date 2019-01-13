using Infrastructure;
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
    public partial class Overview_project : Form
    {
        public Overview_project()
        {
            InitializeComponent();
            foreach (var project in DataBaseProjects.ListProjects)
            {
                projectCheckedListbox.Items.Add(project);

            }
        }
        public void RefreshProjectListbox()
        {
            projectCheckedListbox.Items.Clear();
            foreach (var project in DataBaseProjects.ListProjects)
            {

                projectCheckedListbox.Items.Add(project);

            }
        }

        private void Overview_project_Load(object sender, EventArgs e)
        {
            
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            
            foreach (var item in projectCheckedListbox.CheckedItems)
            {
                var detailsWindow = new DetailsProject(DataBaseProjects.GetProject(item.ToString()));
                detailsWindow.ShowDialog();
            }

            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            foreach (var item in projectCheckedListbox.CheckedItems)
            {
                var editProject = new EditProjectForm(DataBaseProjects.GetProject(item.ToString()));
                editProject.ShowDialog();
            }
            RefreshProjectListbox();
            
        }
    }
}
