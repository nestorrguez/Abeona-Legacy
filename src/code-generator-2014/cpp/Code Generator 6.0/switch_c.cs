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
    public partial class switch_c : Form
    {
        int x = open.a;
        public switch_c()
        {
            InitializeComponent();
            System.Object[] ItemObject = new System.Object[440];
            for (int c = 1; c <= claz.numvar[x]; c++)
            {
                if (claz.kindvar[x, c] == 1 || claz.kindvar[x, c] == 3)
                {
                    ItemObject[c] = claz.variables[x, c];
                    comboBox1.Items.Add(ItemObject[c]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                to.code = "switch(" + comboBox1.Text + ")\r\n{";
                open.var = comboBox1.Text;
                Close();
            }
        }
    }
}
