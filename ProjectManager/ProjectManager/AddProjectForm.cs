using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Infrastructure;
using Model;

namespace ProjectManager
{
    public partial class AddProjectForm : Form
    {
        public AddProjectForm()
        {
            InitializeComponent();
            foreach (var employee in DataBaseEmployees.ListEmployees)
            {
                employeeCheckedListbox.Items.Add(employee.FirstName + " " + employee.LastName);
            }
        }

        private void employeeCheckedListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var oibRegex = new Regex(@"\d{11}");
            foreach (var item in employeeCheckedListbox.CheckedItems)
            {
                DataBaseRelations.RelationList.Add(new Relations(oibRegex.Match(item.ToString()).Value,
                    projectNameTextBox.Text, oibRegex.Match(item.ToString()).Value));
            }
            DataBaseProjects.ListProjects.Add(new Project(projectNameTextBox.Text,dateTimePicker1.Value,
                dateTimePicker2.Value));
            Close();
        }
    }
}
