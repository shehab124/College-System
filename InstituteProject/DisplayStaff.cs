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
            //MessageBox.Show(Institute.inst_Student[0].Display());
            for (int i = 0; i < Institute.inst_pers.Count(); i++)
            {
                if (Institute.inst_pers[i] is Staff)
                    label1.Text = label1.Text + Institute.inst_pers[i].Display() + "\n";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
