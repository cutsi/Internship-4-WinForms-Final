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
using Utility;

namespace ProjectManager
{
    public partial class Overview_project : Form
    {
        public Overview_project()
        {
            InitializeComponent();
            RefreshProjectListbox();
        }

        public void RefreshProjectListbox()
        {
            projectCheckedListbox.Items.Clear();
            foreach (var project in DataBaseProjects.ListProjects)
            {
                Functions.RemoveWhitespaces(project.Name);
                Functions.CapitalizeName(project.Name);
                projectCheckedListbox.Items.Add(project.Name);

            }
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
