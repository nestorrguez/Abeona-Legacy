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
            if(a==3)
            {
                if (label1.Text.Length > 1)
                {
                    open.window("Atencion", "Se esta evaluando un caracter, no una cadena", true);
                }
                else if (label1.Text.Length > 0 && label1.Text.Length < 1)
                {
                    to.code = "case '" + textBox1.Text + "':";
                    Close();
                }
                else if (label1.Text.Length == 0)
                {
                    open.window("Atencion", "Escriba un caracter antes de continuar", true);
                }
            }
            else if (a==1)
            {
                for (int c = 0; c <= textBox1.Text.Length; c++)
                {
                    if ((textBox1.Text[c] >= '0' && textBox1.Text[c] <= '9'))
                    {
                        n++;
                    }
                    else
                    {
                        d++;
                    }
                }
                if (d > 0)
                {
                    open.window("Atencion", "Se esta evaluando un numero tipo entero, no una cadena, caracter o decimal", true);
                }
                else if (n < 0)
                {
                    open.window("Atencion", "Escriba un numero antes de continuar", true);
                }
                else
                {
                    to.code = "case " + textBox1.Text + ":";
                }
            }
            Close();
        }
    }
}
