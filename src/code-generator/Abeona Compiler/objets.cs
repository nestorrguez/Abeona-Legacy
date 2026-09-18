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
    public partial class objets : Form
    {
        int a;
        public objets()
        {
            InitializeComponent();
        }      

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            key.varname = key.code = comboBox1.Text + "." + comboBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int c = 1; c <= key.n; c++)
            {
                if (comboBox1.Text == key.var[c])
                {
                    a = c;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (key.kind[a] == 5)
            {
                key.code = comboBox1.Text + " = " + "Console.ReadLine();";
            }
            else
            {
                open.window("Atencion", "Solo variables del tipo ''Cadena de caracteres (string)'' pueden recibir datos en C#", true);
            }
        }
    }
}
