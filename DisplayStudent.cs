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
        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("RegNum", "Registration Number");
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Term", "Term");
            dataGridView1.Columns.Add("No", "Num of Courses");
            int j = 0;
            for(int i = 0; i < Institute.inst_pers.Count; i++)
            {
                if (Institute.inst_pers[i].PType == PersonType.Student)
                {
                    Student std = Institute.inst_pers[i].GetStudent();
                    dataGridView1.Rows.Add(std.Name, std.RegistrationNo, std.ID ,std.TermId, std.subjects.Count);
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
