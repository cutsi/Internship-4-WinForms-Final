using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure;
using Model;
using Model.Enums;
using Utility;

namespace ProjectManager
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            foreach (var project in DataBaseProjects.ListProjects)
            {
                ProjectListBox.Items.Add(project);
                
            }

            foreach (var jobs in Enum.GetValues(typeof(Position)))
            {
                JobComboBox.Items.Add(jobs);
            }
        }

        
        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OibTextbox.Text) ||
                string.IsNullOrWhiteSpace(FirstNametextbox.Text) || string.IsNullOrWhiteSpace(LastNametextbox.Text) || 
                string.IsNullOrWhiteSpace(JobComboBox.Text) || string.IsNullOrWhiteSpace(HoursTextbox.Text) || 
                Functions.ValidOib(OibTextbox.Text)==false)
            {
                var errorBox = new ErrorWindow();
                errorBox.ShowDialog();
                Close();
                return;
            }
            
            foreach (var item in ProjectListBox.CheckedItems)
            {
                DataBaseRelations.RelationList.Add(new Relations(OibTextbox.Text, item.ToString(), HoursTextbox.Text));
            }

            if (!Functions.CheckAge(birthTimePicker.Value))
            {
                var errorBox = new ErrorWindow();
                errorBox.ShowDialog();
                Close();
                return;
            }

            DataBaseEmployees.ListEmployees.Add(new Employee(Functions.CapitalizeName(FirstNametextbox.Text), Functions.CapitalizeName(LastNametextbox.Text),
                birthTimePicker.Value, OibTextbox.Text, (Position) Enum.Parse(typeof(Position), JobComboBox.Text)));
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OibTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
