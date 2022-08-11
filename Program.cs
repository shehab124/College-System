using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteProject
{
    static class Program
    {
        /// <summary>
        /// in entry point for the application.
        /// </summary>
        //public static List<Student> student = new List<Student>();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
     
}
