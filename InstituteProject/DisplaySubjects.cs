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
            //MessageBox.Show(Institute.inst_Sub[0].ToString());
            for (int i = 0; i < Institute.inst_Sub.Count(); i++)
            {
                label6.Text = label6.Text + Institute.inst_Sub[i].ToString() + "\n";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
