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
using Model.Enums;

namespace ProjectManager
{
    public partial class EditEmployeeForm : Form
    {
        private readonly Employee ToViewEmployee;
        public EditEmployeeForm(Employee toViewEmployee)
        {
            InitializeComponent();
            
            ToViewEmployee = toViewEmployee;
            EditEmployeeForm_Load();
        }

        private void EditEmployeeForm_Load()
        {
            FirstNametextbox.Text = ToViewEmployee.FirstName;
            LastNametextbox.Text = ToViewEmployee.LastName;
            OibTextbox.Text = ToViewEmployee.Oib;
            birthTimePicker.Text = ToViewEmployee.DateOfBirth.ToString();
            JobComboBox.Text = ToViewEmployee.Position.ToString();
            HoursTextbox.Text = DataBaseRelations.GetHours(ToViewEmployee.Oib).ToString();
            var index = 0;
            
            foreach (var project in DataBaseProjects.ListProjects)
            {
                 ProjectListBox.Items.Add(project.Name);
                
                if (DataBaseRelations.GetRelation(project.Name, ToViewEmployee.Oib) != null)
                {
                    ProjectListBox.SetItemChecked(index,true);
                }
                index++;
                
            }

        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            var uncheckedItems = new List<object>();

            foreach (var item in ProjectListBox.Items)
            {
                uncheckedItems.Add(item);
            }

            foreach (var item in ProjectListBox.CheckedItems)
            {
                uncheckedItems.Remove(item);
            }

            foreach (var item in uncheckedItems)
            {
                if (DataBaseRelations.GetRelation(item.ToString(), ToViewEmployee.Oib) != null)
                {
                    //provjera je l zadnji
                    //if(brojemployeeanaprojektu == 1)  {
                    //error
                    //continue;
                    //}
                    DataBaseRelations.RelationList.Remove(
                        DataBaseRelations.GetRelation(item.ToString(), ToViewEmployee.Oib));
                }
            }
            foreach (var item in ProjectListBox.CheckedItems)
            {
                if (DataBaseRelations.GetRelation(item.ToString(), ToViewEmployee.Oib) != null)
                {
                    DataBaseRelations.RelationList.Remove(
                        DataBaseRelations.GetRelation(item.ToString(), ToViewEmployee.Oib));
                }
            }
            foreach (var item in ProjectListBox.CheckedItems)
            {
                DataBaseRelations.RelationList.Add(new Relations(OibTextbox.Text, item.ToString(), HoursTextbox.Text));

            }

            DataBaseEmployees.ListEmployees.Remove(ToViewEmployee);
            DataBaseEmployees.ListEmployees.Add(new Employee(FirstNametextbox.Text,LastNametextbox.Text,birthTimePicker.Value,
                OibTextbox.Text,(Position) Enum.Parse(typeof(Position),JobComboBox.Text)));
            Close();
        }
    }
}
