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
    public partial class GPA : Form
    {
        String lettergrd;
        double credit;
        double caltimes = 0;
        double totalcal = 0;
        double totalcredit = 0;
        double finalgpa = 0;
        double APLUS = 4.0;
        double A = 4.0;
        double AMINUS = 3.70;
        double BPLUS = 3.30;
        double B = 3.0;
        double BMINUS = 2.70;
        double CPLUS = 2.30;
        double C = 2.0;
        double CMINUS = 1.70;
        double DPLUS = 1.30;
        double D = 1.0;
        double F = 0.0;
        ComboBox defaultcombo = new ComboBox();
        NumericUpDown defaultnumeric = new NumericUpDown();

        public GPA()
        {
            InitializeComponent();
        }

        private void GPA_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lettergrd = "";
            credit = 0;
            caltimes = 0;
            totalcal = 0;
            totalcredit = 0;
            finalgpa = 0;
            defaultcombo = new ComboBox();
            defaultnumeric = new NumericUpDown();
            for (int i = 0; i < 7; i++)
            {

                switch (i)
                {
                    case 0:
                        defaultcombo = comboBox1;
                        defaultnumeric = numericUpDown1;
                        break;
                    case 1:
                        defaultcombo = comboBox2;
                        defaultnumeric = numericUpDown2;
                        break;
                    case 2:
                        defaultcombo = comboBox3;
                        defaultnumeric = numericUpDown3;
                        break;
                    case 3:
                        defaultcombo = comboBox4;
                        defaultnumeric = numericUpDown4;
                        break;
                    case 4:
                        defaultcombo = comboBox5;
                        defaultnumeric = numericUpDown5;
                        break;
                    case 5:
                        defaultcombo = comboBox6;
                        defaultnumeric = numericUpDown6;
                        break;
                    case 6:
                        defaultcombo = comboBox7;
                        defaultnumeric = numericUpDown7;
                        break;
                }

                lettergrd = defaultcombo.Text;
                credit = Double.Parse(defaultnumeric.Value.ToString());


                if (lettergrd != String.Empty && credit != 0)
                {

                    switch (lettergrd)
                    {
                        case "A+":
                            caltimes = credit * APLUS;
                            break;
                        case "A":
                            caltimes = credit * A;
                            break;
                        case "A-":
                            caltimes = credit * AMINUS;
                            break;
                        case "B+":
                            caltimes = credit * BPLUS;
                            break;
                        case "B":
                            caltimes = credit * B;
                            break;
                        case "B-":
                            caltimes = credit * BMINUS;
                            break;
                        case "C+":
                            caltimes = credit * CPLUS;
                            break;
                        case "C":
                            caltimes = credit * C;
                            break;
                        case "C-":
                            caltimes = credit * CMINUS;
                            break;
                        case "D+":
                            caltimes = credit * DPLUS;
                            break;
                        case "D":
                            caltimes = credit * D;
                            break;
                        case "F":
                            caltimes = credit * F;
                            break;

                    }

                    totalcredit = totalcredit + credit;
                    totalcal = totalcal + caltimes;
                }

            }

            finalgpa = totalcal / totalcredit;

            textBox1.Text = finalgpa.ToString("#.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox6.ResetText();
            comboBox7.ResetText();

            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
            numericUpDown3.ResetText();
            numericUpDown4.ResetText();
            numericUpDown5.ResetText();
            numericUpDown6.ResetText();
            numericUpDown7.ResetText();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
