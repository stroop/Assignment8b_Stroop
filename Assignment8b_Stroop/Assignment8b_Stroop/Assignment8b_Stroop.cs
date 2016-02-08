using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Jacob Stroop
CIS353 - Assignment 8b
2/7/16
*/

namespace Assignment8b_Stroop
{
    public partial class Assignment8 : Form
    {
        // constructor calls method to initialize form
        public Assignment8()
        {
            InitializeComponent();
        }

        // Button click method displays message box
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Button Has Been Clicked", "Click Me");
        }

        // button click method closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
