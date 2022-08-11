using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteProject
{
    class Staff : Person
    {
        public string position { set; get; }
        List<Subject> subjects = new List<Subject>();
        public Staff()
        {
            position = "";
            PType = PersonType.Staff;
        }
        public Staff(string name, int id, string pos) : base(name, id, PersonType.Staff)
        {
            position = pos;            
        }


        public List<Subject> Subjects
        {
            get
            {
                return subjects;
            }
        }
        public override string Display()
        {
            string str;
            str =  Name + "                " + ID + "                "+ position;
            return str;
        }
        public override Staff GetStaff()
        {
            return this;
        }
        public override Student GetStudent()
        {
            return new Student();
        }
        
    }
    
}
