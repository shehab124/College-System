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
    public partial class DisplaySubjects : Form
    {
        public DisplaySubjects()
        {
            InitializeComponent();
        }

        private void DisplaySubjects_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Code", "Code");
            dataGridView1.Columns.Add("Credit", "Credit Hours");
            dataGridView1.Columns.Add("Reg", "Num of Registered Student");
            for (int i = 0; i < Institute.inst_Sub.Count; i++)
            {
                Subject sub = Institute.inst_Sub[i];
                int Reg = 0;
                for (int j = 0; j < Institute.inst_pers.Count; j++)
                {
                    if (Institute.inst_pers[j].PType == PersonType.Student)
                    {
                        Student std = Institute.inst_pers[j].GetStudent();
                        for (int m = 0; m < std.subjects.Count; m++)
                        {
                            if (std.subjects[m].SubjectName == sub.SubjectName)
                            {
                                Reg++;
                            }
                        }
                    }
                }
                dataGridView1.Rows.Add(sub.SubjectName, sub.SubjectID, sub.CreditHours, Reg);
                
            }
        }

      
    }
}
