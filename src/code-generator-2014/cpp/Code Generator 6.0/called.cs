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
    public partial class called : Form
    {
        bool oki;
        public called()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            oki = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            oki = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            open.window(textBox1.Text, textBox2.Text, oki);
            this.Close();
        }
    }
}
