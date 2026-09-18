using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            label1.Text = key.varname + " = ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (key.lengprog)
            {
                case 1:
                    {
                        key.code = key.varname + "=" + textBox1.Text + ";";
                    } break;
                case 2:
                    {
                        key.code = key.varname + "=" + textBox1.Text + ";";
                    } break;
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
