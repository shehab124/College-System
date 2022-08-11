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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    for (int i = 0; i < Institute.inst_pers.Count; i++)
                    {
                        if (Institute.inst_pers[i].Name == textBox1.Text && Institute.inst_pers[i] is Student)
                        {
                            label7.Text = label7.Text + Institute.inst_pers[i].Name + "\n";
                            label8.Text = label8.Text + Institute.inst_pers[i].Display_Reg() + "\n";
                            label9.Text = label9.Text + Institute.inst_pers[i].Display_id() + "\n";
                            label10.Text = label10.Text + Institute.inst_pers[i].Display_termid() + "\n";
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    for (int i = 0; i < Institute.inst_pers.Count; i++)
                    {
                        if (Institute.inst_pers[i].Display_Reg() == Convert.ToInt32(textBox1.Text) && Institute.inst_pers[i] is Student)
                        {
                            label7.Text = label7.Text + Institute.inst_pers[i].Name + "\n";
                            label8.Text = label8.Text + Institute.inst_pers[i].Display_Reg() + "\n";
                            label9.Text = label9.Text + Institute.inst_pers[i].Display_id() + "\n";
                            label10.Text = label10.Text + Institute.inst_pers[i].Display_termid() + "\n";
                        }
                    }
                }
                if(label7.Text == "")
                {
                    MessageBox.Show("Error 404!" +
                        "Student Not Found!");
                }
            }catch
            {
                MessageBox.Show("Insert the right format");
            }
        }
    }
}
