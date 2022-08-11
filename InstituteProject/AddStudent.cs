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
       // List<Student> student = new List<Student>();

        public AddStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("A new student has joined the institue!");
                this.Close();
            }    
            catch
            {
                MessageBox.Show("Error 404!\n" + "Please enter the inputs in the right format!\n" +
                    "Name: Name\n" +
                    "ID: Number\n" +
                    "Term: Number: Number\n" +
                    "Registration Number: Number");
            }
            /*for(int i=0;i< checkedListBox1.CheckedItems.Count;i++)
            {
                Student x = (Student)Institute.inst_pers[i];
                
                //x.AddSubject(checkedListBox1.);
            }*/
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();
            for (int i = 0; i < Institute.inst_Sub.Count(); i++)
            {
                //label6.Text = label6.Text + Institute.inst_Sub[i].ToString() + "\n";
                checkedListBox1.Items.Add(Institute.inst_Sub[i].SubjectName);
            }
        }
    }
}
