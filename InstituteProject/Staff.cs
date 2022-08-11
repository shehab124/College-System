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
        }
        public Staff(string name, int id, string pos) : base(name, id)
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
        public override int Display_id()
        {
            return 0;
        }
        public override int Display_termid()
        {
            return 0;
        }
        public override long Display_Reg()
        {
            return 0;
        }
    }
    
}
