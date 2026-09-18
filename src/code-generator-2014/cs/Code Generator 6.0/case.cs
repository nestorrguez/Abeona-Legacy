using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGenCS
{
    public partial class @case : Form
    {
        int a,n,d;        
        public @case()
        {
            InitializeComponent();
            label1.Text = "En caso que ''" + open.var + "'' sea: ";
            for (int c = 1; c <= claz.numvar[open.a]; c++)
            {
                if (claz.variables[open.a, c] == open.var)
                {
                    a = claz.kindvar[open.a, c];
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 1)
                to.code = "case " + textBox1.Text + ":";
            else
                to.code = "case '" + textBox1.Text + "':";
            Close();
        }
    }
}
