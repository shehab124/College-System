using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteProject
{
    class Student : Person
    {
        int TermId { set; get; }
        long RegistrationNo { set; get; }
        public List<Subject> subjects = new List<Subject>();
        public List<Subject> Subjects
        {
            get
            {
                return subjects;
            }
        }
        public Student()
        {
            TermId = 0;
            RegistrationNo = 0;
        }
        public Student(string name, int id, int term, long reg) : base(name, id)
        {
            TermId = term;
            RegistrationNo = reg;
        }
        public void AddSubject(Subject sub)
        {
            Subjects.Add(sub);
        }
        public override string Display()
        {
            string str;
            str = Name + "                 " + ID + "                     " + TermId + "                  " + RegistrationNo + "                 " + Subjects.Count ;

            return str;
        }
        public override int Display_id()
        {
            return ID;
        }
        public override int Display_termid()
        {
            return TermId;
        }
        public override long Display_Reg()
        {
            return RegistrationNo;
        }

    }
}
