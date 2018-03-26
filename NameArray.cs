//DYLAN GRANDJEAN
//This class is designed to take in user string input and display a string from string array
//April 14th, 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Assignment11
{
    class NameArray
    {
        //Variable instantiation
        private string[] names = new string[3];
        int i = 0;

        //Default constructor
        public NameArray(){}

        //Sets array values to input value
        public string Names { set { names[i] = value; i++; } }

        //Display method assignes array values to string and display result into a message box
        public void Display()
        {
            //Declare an empty string
            string str = string.Empty;
            //Assign array value to the string str
            foreach (string name in names)
                str += name + "\n";

            //Display str into a message box
            MessageBox.Show(str, "Class Name");
        }
    }
}
