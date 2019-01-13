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

namespace ProjectManager
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
            foreach (var employee in DataBaseEmployees.ListEmployees)
            {
                
                EmpListBox.Items.Add(employee);
                
            }
        }

        private void DelEmployee()
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
        
            
            var oibRegex = new Regex(@"\d{11}");
            foreach (var item in EmpListBox.CheckedItems)
            {

                DataBaseEmployees.ListEmployees.Remove(
                    DataBaseEmployees.GetEmployee(oibRegex.Match(item.ToString()).Value));

                //break;
            }



            Refresh();
        }
        private new void Refresh()
        {
            EmpListBox.Items.Clear();

            foreach (var employee in DataBaseEmployees.ListEmployees)
            {
                EmpListBox.Items.Add(employee);
            }
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
