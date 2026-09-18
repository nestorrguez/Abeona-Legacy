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
    public partial class for_c : Form
    {
        int x = open.nv;
        string m;
        public for_c()
        {
            InitializeComponent();
            System.Object[] ItemObject = new System.Object[440];
            for (int c = 1; c <= claz.numvar[x]; c++)
            {
                if (claz.kindvar[x, c] >= 1 || claz.kindvar[x, c] <= 3)
                {
                    ItemObject[c] = claz.variables[x, c];
                    listBox1.Items.Add(ItemObject[c]);
                    comboBox4.Items.Add(ItemObject[c]);
                }
            }            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox4.Text = listBox1.Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Incrementa")
                m = "+";
            else
                m = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            to.code = "for(" + listBox1.Text + "=" + textBox1.Text + ";" + textBox2.Text + comboBox3.Text + comboBox4.Text + ";" + textBox4.Text + m + "=" + textBox3.Text + ")\r\n{";
            Close();
        }
    }
}
