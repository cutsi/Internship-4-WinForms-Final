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
using Infrastructure;
using Model;

namespace ProjectManager
{
    public partial class EditProjectForm : Form
    {
        private readonly Project ToEditProject;
        public EditProjectForm(Project toEditProject)
        {
            InitializeComponent();
            ToEditProject = toEditProject;
            EditProjectFormLoad();
        }

        public void EditProjectFormLoad()
        {
            projectNameTextBox.Text = ToEditProject.Name;
            dateTimePicker1.Value = ToEditProject.StartTime;
            dateTimePicker2.Value = ToEditProject.EndTime;
            var index = 0;
            foreach (var  employee in DataBaseEmployees.ListEmployees)
            {
                employeeCheckedListbox.Items.Add(employee.FirstName + " " + employee.LastName + " " + employee.Oib);
                
                if (DataBaseRelations.GetRelation(ToEditProject.Name, employee.Oib) != null)
                {
                    employeeCheckedListbox.SetItemChecked(index, true);
                }
                index++;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var uncheckedItems = new List<object>();
            var oibRegex = new Regex(@"\d{11}");

            foreach (var item in employeeCheckedListbox.Items)
            {
                uncheckedItems.Add(item);
            }

            foreach (var item in employeeCheckedListbox.CheckedItems)
            {
                uncheckedItems.Remove(item);
                
            }
            
            foreach (var item in uncheckedItems)
            {
                var empOib = oibRegex.Match(item.ToString()).Value;
                if (DataBaseRelations.GetRelation(ToEditProject.Name, empOib) != null)
                {
                    DataBaseRelations.RelationList.Remove(
                        DataBaseRelations.GetRelation(ToEditProject.Name, empOib));
                }
            }
            foreach (var item in employeeCheckedListbox.CheckedItems)
            {
                var empOib = oibRegex.Match(item.ToString()).Value;
                if (DataBaseRelations.GetRelation(ToEditProject.Name, empOib) != null)
                {
                    DataBaseRelations.RelationList.Remove(
                        DataBaseRelations.GetRelation(ToEditProject.Name, empOib));
                }
            }
            foreach (var item in employeeCheckedListbox.CheckedItems)
            {
                var empOib = oibRegex.Match(item.ToString()).Value;
                var hours = DataBaseRelations.GetHoursFromRelation(ToEditProject.Name, empOib);
                DataBaseRelations.RelationList.Add(new Relations(empOib, ToEditProject.Name, hours.ToString()));

            }

            DataBaseProjects.ListProjects.Remove(ToEditProject);
            DataBaseProjects.ListProjects.Add(new Project(projectNameTextBox.Text,dateTimePicker1.Value,dateTimePicker2.Value));
            Close();
        }
    }
}
