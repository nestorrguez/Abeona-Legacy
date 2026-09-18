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
    public partial class delay : Form
    {
        public delay()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (to.lenprog)
                {
                    case 1: to.code = "Sleep(" + textBox1.Text + ");"; break;
                    case 2: to.code = "System.Threading.Thread.Sleep(" + textBox1.Text + ");"; break;
                }
                Close();
            }
            else
            {
                open.window("Atencion", "Primero debes de ingresar la cantidad de centecimas de segundo que deseas", true);
            }
        }
    }
}
