using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteProject
{
    class Student : Person
    {
        public int TermId { set; get; }
        public long RegistrationNo { set; get; }
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
            PType = PersonType.Student;
        }
        public Student(string name, int id, int term, long reg) : base(name, id, PersonType.Student)
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
        public override Staff GetStaff()
        {
            return new Staff();
        }
        public override Student GetStudent()
        {
            return this;
        }

    }
}
