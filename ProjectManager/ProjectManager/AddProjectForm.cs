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
using Utility;

namespace ProjectManager
{
    public partial class AddProjectForm : Form
    {
        public AddProjectForm()
        {
            InitializeComponent();
            foreach (var employee in DataBaseEmployees.ListEmployees)
            {
                Functions.RemoveWhitespaces(employee.FirstName);
                Functions.RemoveWhitespaces(employee.LastName);
                employeeCheckedListbox.Items.Add(Functions.CapitalizeName(employee.FirstName) + " " + Functions.CapitalizeName(employee.LastName));
            }
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            var oibRegex = new Regex(@"\d{11}");
            foreach (var item in employeeCheckedListbox.CheckedItems)
            {
                
                Functions.RemoveWhitespaces(projectNameTextBox.Text);
                DataBaseRelations.RelationList.Add(new Relations(oibRegex.Match(item.ToString()).Value,
                    Functions.CapitalizeName(projectNameTextBox.Text), oibRegex.Match(item.ToString()).Value));
                
               // var emp = DataBaseEmployees.GetEmployee(oibRegex.Match(item.ToString()).Value);
                //DataBaseEmployees.ListEmployees.Add(new Employee(emp.FirstName, emp.LastName,emp.DateOfBirth, oibRegex.ToString(), emp.Position));
            }
            DataBaseProjects.ListProjects.Add(new Project(projectNameTextBox.Text,dateTimePicker1.Value,
                dateTimePicker2.Value));
            Close();
        }
    }
}
