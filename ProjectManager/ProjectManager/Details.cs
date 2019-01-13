using Infrastructure;
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
using Model;

namespace ProjectManager
{
    public partial class Details : Form
    {
        //private Overview form;
        private readonly Employee ToViewEmployee;

        public Details(Employee toViewEmployee)
        {
            InitializeComponent();
            ToViewEmployee = toViewEmployee;

        }

        private void Details_Load(object sender, EventArgs e)
        {            
            nameBox.Text = ToViewEmployee.FirstName + " " + ToViewEmployee.LastName;
            oibBox.Text = ToViewEmployee.Oib;
            birthdayBox.Text = ToViewEmployee.DateOfBirth.ToString();
            positionBox.Text = ToViewEmployee.Position.ToString();
            workHoursBox.Text = DataBaseRelations.GetHours(ToViewEmployee.Oib).ToString();

            foreach (var project in DataBaseRelations.GetEmployeesProjects(ToViewEmployee.Oib))
            {
                if (project.Started() && !project.Ended())
                {
                    projectsInWorkingListbox.Items.Add(project.Name);
                }
                else if (project.Ended())
                {
                    finishedProjectsListbox.Items.Add(project.Name);
                }
                else
                {
                    plannedProjectsListbox.Items.Add(project.Name);
                }
            }
        }
    }
}
