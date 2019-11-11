using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_01_11_11
{

    class User
    {
        public String fname;
        public String lname;
        public String tel;
        public static int COUNT=0;

        public User(String fname,String lname,String tel)
        {
            this.fname = fname;
            this.lname = lname;
            this.tel = tel;
            COUNT++;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
