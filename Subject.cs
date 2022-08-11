using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteProject
{
    public class Subject
    {
        public int SubjectID { set; get; }
        public string SubjectName { set; get; }
        public int CreditHours { set; get; }
        public float GPA { set; get; }
        public Subject()
        {
            SubjectID = 0;
            SubjectName = "";
            CreditHours = 0;
        }
        public Subject(int id, string name, int credit)
        {
            SubjectID = id;
            SubjectName = name;
            CreditHours = credit;
        }
        /*public string GradeCalculation()
        {
            string Grade;
            if(Mark >= 97)
            {
                Grade = "A+";
                GPA = 4.0f;
            }
            else if(Mark >= 93)
            {
                Grade = "A";
                GPA = 4.0f;
            }
            else if(Mark >= 90)
            {
                Grade = "A-";
                GPA = 3.7f;
            }
            else if(Mark >= 87)
            {
                Grade = "B+";
                GPA = 3.3f;
            }
            else if(Mark >= 83)
            {
                Grade = "B";
                GPA = 3.0f;
            }
            else if(Mark >= 80)
            {
                Grade = "B-";
                GPA = 2.7f;
            }
            else if(Mark >= 77)
            {
                Grade = "C+";
                GPA = 2.3f;
            }
            else if(Mark >= 73)
            {
                Grade = "C";
                GPA = 2.0f;
            }
            else if (Mark >= 70)
            {
                Grade = "C-";
                GPA = 1.7f;
            }
            else if (Mark >= 67)
            {
                Grade = "D+";
                GPA = 1.3f;
            }
            else if (Mark >= 65)
            {
                Grade = "D";
                GPA = 1.0f;
            }
            else
            {
                Grade = "F";
                GPA = 0.0f;
            }
            return Grade;
        }*/
        public override string ToString()
        {
            string str = "             " + SubjectName + "              " + SubjectID + "           " + CreditHours ;
            return str;
        }
    }
}
