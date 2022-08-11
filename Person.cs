using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteProject
{
    public enum PersonType { Staff, Student, NAN}
    abstract class Person
    {
        public PersonType PType { set; get; }
        public string Name { set; get; }
        public int ID { set; get; }

        public Person()
        {
            Name = "";
            ID = 0;
            PType = PersonType.NAN;
        }
        public Person(string name, int id, PersonType ptype)
        {
            Name = name;
            ID = id;
            PType = ptype;
        }
        public abstract string Display();
        public abstract Student GetStudent();   
        public abstract Staff GetStaff();
    }
}
