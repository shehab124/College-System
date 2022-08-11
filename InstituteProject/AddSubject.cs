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
    
    public partial class AddSubject : Form
    {
        List<Subject> subjects = new List<Subject>();
        public AddSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int subjid; 
            string subn;
            int hours;
            try
            {
                subjid = int.Parse(TextBox1.Text);
                subn = textBox2.Text;
                hours = int.Parse(textBox3.Text);
                Subject sub = new Subject(subjid, subn, hours);
                Institute.inst_Sub.Add(sub);
                MessageBox.Show("A new Subject has been created");
            }
            catch
            {
                MessageBox.Show( "Error 404!\n"+"Please enter the inputs in the right format!\n" +
                    "Subject ID: Number\n" +
                    "Subject Name: Name\n" +
                    "Credit hours: Number\n");
            }
            

            
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
