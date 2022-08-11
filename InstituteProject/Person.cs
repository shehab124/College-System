using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteProject
{
    abstract class Person
    {
        public string Name { set; get; }
        public int ID { set; get; }

        public Person()
        {
            Name = "";
            ID = 0;
        }
        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }
        public abstract string Display();
        public abstract int Display_id();
        public abstract int Display_termid();
        public abstract long Display_Reg();
    }
}
