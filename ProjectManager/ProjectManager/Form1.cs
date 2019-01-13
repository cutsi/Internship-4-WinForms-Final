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

namespace ProjectManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DateBaseRelations.Init();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var empWindow = new employees();
            empWindow.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var projectWindow = new Projects();
           // listBox1_SelectedIndexChanged(sender,EventArgs.Empty);
            projectWindow.Show();
        }
    }
}
