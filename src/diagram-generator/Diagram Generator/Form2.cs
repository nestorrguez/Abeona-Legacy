using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagram_Generator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = open.title;
            textBox2.Text = open.text;
            if (open.multi == true)
            {
                textBox1.Multiline = true;
            }
            else
            {
                textBox1.Multiline = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.messenger = textBox1.Text;
            Close();
        }

    }
}
