using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure;
using Model;
using static ProjectManager.Details;
namespace ProjectManager
{
    public partial class Overview : Form
    {
        
        public Overview()
        {
            InitializeComponent();
            RefreshListbox();
            
        }

        public void RefreshListbox()
        {
            checkedListBoxOverview.Items.Clear();
            foreach (var employee in DataBaseEmployees.ListEmployees)
            {

                checkedListBoxOverview.Items.Add(employee);

            }
        }

        public void checkedListBoxOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Details_Click(object sender, EventArgs e)
        {
            var oibRegex = new Regex(@"\d{11}");
            foreach (var item in checkedListBoxOverview.CheckedItems)
            {
                var itemOib = oibRegex.Match(item.ToString()).Value;
                var detailsEmp = new Details(DataBaseEmployees.GetEmployee(itemOib));
                detailsEmp.ShowDialog();
            }
            
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var oibRegex = new Regex(@"\d{11}");
            foreach (var emp in checkedListBoxOverview.CheckedItems)
            {
                var empOib = oibRegex.Match(emp.ToString()).Value;
                var overViewEmp = new EditEmployeeForm(DataBaseEmployees.GetEmployee(empOib));
                overViewEmp.ShowDialog();
            }

            RefreshListbox();
        }
    }
}
