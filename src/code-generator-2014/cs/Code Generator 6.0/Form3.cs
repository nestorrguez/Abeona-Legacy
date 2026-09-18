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
    public partial class Form3 : Form
    {
        public Form3()
        {
            int c, x = open.nv;
            InitializeComponent();
            System.Object[] ItemObject = new System.Object[440];
            for (c = 1; c <= claz.numvar[x]; c++)
            {
                if (claz.variables[x, c].Contains("()"))
                { }
                else
                {
                    ItemObject[c] = claz.variables[x, c];
                    comboBox3.Items.Add(ItemObject[c]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            to.paste = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text += " " + comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text += " " + comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text += " " + comboBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " " + textBox2.Text;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(17);
        }
    }
}
