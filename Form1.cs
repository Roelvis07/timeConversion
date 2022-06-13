using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timeConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string s = "07:05:45PM";
            //string s = "12:00:00AM";
            //string s = "12:45:54PM";
            string s = "12:40:22AM";

            Console.WriteLine( timeConversion(s) );
        }
        public static string timeConversion(string s)
        {
            int military = Convert.ToInt32(s.Substring(0, 2));

            string varToReturn = s;
            if (military != 12 && s.Contains("PM"))
                varToReturn = s.Remove(0, 2).Insert(0, (military + 12).ToString());
            if (military == 12 && s.Contains("AM"))
                varToReturn = s.Remove(0, 2).Insert(0, "00");
           
            return varToReturn.Substring(0, s.Length - 2);
        }
    }
}
