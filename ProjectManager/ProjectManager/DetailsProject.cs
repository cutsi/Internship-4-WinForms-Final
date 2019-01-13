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
using Model;
using Model.Enums;
using Utility;
using static ProjectManager.Overview_project;
namespace ProjectManager
{
    public partial class DetailsProject : Form
    {
        private readonly Project ToViewProject;
        public DetailsProject(Project toViewProject)
        {
            InitializeComponent();
            ToViewProject = toViewProject;
        }

        private void DetailsProject_Load(object sender, EventArgs e)
        {
            //Functions
            projectNameTextbox.Text = ToViewProject.Name;
            projectDatetextbox.Text = ToViewProject.StartTime + "-" + ToViewProject.EndTime;
            ProgrammerComboBox.Text = Position.Programmer.ToString();
            accoutantComboBox.Text = Position.Accountant.ToString();
            designerComboBox.Text = Position.Designer.ToString();
            marketingComboBox.Text = Position.Marketing.ToString();
            SecretarComboBox.Text = Position.Secretary.ToString();

            foreach (var relation in DataBaseRelations.GetRelationByName(ToViewProject.Name))
            {
                var emp = DataBaseEmployees.GetEmployee(relation.Oib);
                if (emp.Position == Position.Programmer)
                    ProgrammerComboBox.Items.Add(emp.FirstName + " " + emp.LastName + " "+ DataBaseRelations.GetHoursFromRelation(ToViewProject.Name, emp.Oib));
                else if (emp.Position == Position.Accountant)
                    accoutantComboBox.Items.Add(emp.FirstName + " " + emp.LastName + " " + DataBaseRelations.GetHoursFromRelation(ToViewProject.Name, emp.Oib));
                else if (emp.Position == Position.Designer)
                    designerComboBox.Items.Add(emp.FirstName + " " + emp.LastName + " " + DataBaseRelations.GetHoursFromRelation(ToViewProject.Name, emp.Oib));
                else if (emp.Position == Position.Marketing)
                    marketingComboBox.Items.Add(emp.FirstName + " " + emp.LastName + " " + DataBaseRelations.GetHoursFromRelation(ToViewProject.Name, emp.Oib));
                else if (emp.Position == Position.Secretary)
                    SecretarComboBox.Items.Add(emp.FirstName + " " + emp.LastName + " " + DataBaseRelations.GetHoursFromRelation(ToViewProject.Name, emp.Oib));
            }
            
            /*foreach (var jobs in Enum.GetValues(typeof(Position)))
            {
                JobComboBox.Items.Add(jobs);
            }*/

        }
    }
}
