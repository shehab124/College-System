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
    public partial class AddStaff : Form
    {
        List<Staff> staff = new List<Staff>();
        public AddStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                string n;
                string position;

                n = textBox1.Text;
                id = int.Parse(textBox2.Text);
                position = textBox3.Text;


                Staff s = new Staff(n, id, position);
                Institute.inst_pers.Add(s);
                MessageBox.Show("A new employee has joined!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error 404!\n" + "Please enter the inputs in the right format!\n" +
                    "Name: Name\n" +
                    "ID: Number\n" +
                    "Position: Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Institute.inst_Sub.Count(); i++)
            {
                //label6.Text = label6.Text + Institute.inst_Sub[i].ToString() + "\n";
                checkedListBox1.Items.Add(Institute.inst_Sub[i].SubjectName);
            }
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
