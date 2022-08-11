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
    public partial class DisplayStudent : Form
    {
        public DisplayStudent()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Institute.inst_pers.Count; i++)   ///////
            {
                
                if (Institute.inst_pers[i] is Student)    //////////////
                {
                    label1.Text = label1.Text + Institute.inst_pers[i].Name + "\n";
                    label8.Text = label8.Text + Institute.inst_pers[i].Display_Reg() + "\n";
                    label9.Text = label9.Text + Institute.inst_pers[i].Display_id() + "\n";
                    label10.Text = label10.Text + Institute.inst_pers[i].Display_termid() + "\n";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
