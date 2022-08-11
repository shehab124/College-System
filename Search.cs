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
       
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("RegNum", "Registration Number");
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Term", "Term");
            dataGridView1.Columns.Add("No", "Num of Courses");
            try
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    
                    for (int i = 0; i < Institute.inst_pers.Count; i++)
                    {
                        if (Institute.inst_pers[i].Name == textBox1.Text && Institute.inst_pers[i] is Student)
                        {
                            Student std = Institute.inst_pers[i].GetStudent();
                            dataGridView1.Rows.Add(std.Name, std.RegistrationNo, std.ID, std.TermId, std.subjects.Count);
                        }

                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    for (int i = 0; i < Institute.inst_pers.Count; i++)
                    {
                        if (Institute.inst_pers[i].ID == Convert.ToInt32(textBox1.Text) && Institute.inst_pers[i] is Student)
                        {
                            
                            Student std = Institute.inst_pers[i].GetStudent();
                            dataGridView1.Rows.Add(std.Name, std.RegistrationNo, std.ID, std.TermId, std.subjects.Count);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Insert the right format");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
