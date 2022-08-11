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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Institute.inst_Sub.Count(); i++)
            {
                checkedListBox1.Items.Add(Institute.inst_Sub[i].SubjectName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string n;
            int term;
            int reg;
            try
            {
                n = textBox1.Text;
                id = int.Parse(textBox2.Text);
                term = int.Parse(textBox3.Text);
                reg = int.Parse(textBox4.Text);

                Student s = new Student(n, id, term, reg);

                Institute.inst_pers.Add(s);
                foreach (var v in checkedListBox1.CheckedItems)
                {
                    for (int i = 0; i < Institute.inst_Sub.Count; i++)
                    {
                        if (v.ToString() == Institute.inst_Sub[i].SubjectName)
                        {
                            s.Subjects.Add(Institute.inst_Sub[i]);
                        }
                    }
                }
                MessageBox.Show("A new student has joined the institue!");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
                checkedListBox1.ClearSelected();
                textBox1.Focus();
            }    
            catch
            {
                MessageBox.Show("Error 404!\n" + "Please enter the inputs in the right format!\n" +
                    "Name: Name\n" +
                    "ID: Number\n" +
                    "Term: Number: Number\n" +
                    "Registration Number: Number");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
