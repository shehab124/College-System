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
    public partial class DisplayStaff : Form
    {
        public DisplayStaff()
        {
            InitializeComponent();
        }

        private void DisplayStaff_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Pos", "Position");
            dataGridView1.Columns.Add("Count", "Num of Teached Courses");
            for (int i = 0; i < Institute.inst_pers.Count; i++)
            {
                if (Institute.inst_pers[i].PType == PersonType.Staff)
                {
                    Staff stf = Institute.inst_pers[i].GetStaff();
                    dataGridView1.Rows.Add(stf.Name, stf.ID, stf.position, stf.Subjects.Count);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
