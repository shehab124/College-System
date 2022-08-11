using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteProject
{
    class Institute
    {
        public string Name { set; get; }
        public int Id { set; get; }
        public string Address { set; get; }
        public static List<Subject> inst_Sub = new List<Subject>();
        public static List<Person> inst_pers = new List<Person>();
        public Institute()
        {
            Name = "";
            Id = 0;
            Address = "";
        }
        public Institute(string name, int id, string add)
        {
            Name = name;
            Id = id;
            Address = add;
        }
        /*public List<Staff> InstStaff
        {
            get
            {
                return inst_Staff;
            }
        }
        public List<Student> InstStudent
        {
            get
            {
                return inst_Student;
            }
        }*/
        public List<Subject> InstSubject
        {
            get
            {
                return inst_Sub;
            }


        }
    }
}
