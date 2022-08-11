using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddStudent().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Report().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddStaff().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddSubject().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.aast.edu/en/index.php");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://studentportal.aast.edu/Login");
        }
    }
}
