using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGenCPP
{
    public partial class prefuntions : Form
    {
        public prefuntions()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1: to.code = "system(" + (char)34 + "PAUSE" + (char)34 + ");"; break;
                case 2: to.code = "Console.ReadKey(true);"; break;                    
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.color();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open.delayt();
            Close();
        }
    }
}
