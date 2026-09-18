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
    public partial class cases : Form
    {
        int c,a,b;
        double m;
        public cases()
        {
            InitializeComponent();
            label1.Text = "En caso que " + key.varnames + " valga:";
        }

        void analize()
        {
            for (c = 1; c <= key.num; c++)
            {
                a = c;
                if (key.var[c] == key.varnames)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            b = key.kind[a];
            switch(b)
            {
                case 1:
                    {
                        key.code = "case " + textBox1.Text + " :" + "\r\n" + "{";
                    } break;
                case 2:
                    {
                        key.title = "Advertencia";
                        key.info = "No se pueden utilizar variables tipo ''float'' o ''double'' en un switch";
                        key.does = true;
                        open.error();
                    } break;
                case 3:
                    {
                        key.code = "case '" + textBox1.Text + "' :" + "\r\n" + "{";
                    } break;
                case 4:
                    {
                        key.title = "Advertencia";
                        key.info = "No se pueden utilizar variables tipo ''float'' o ''double'' en un switch";
                        key.does = true;
                        open.error();
                    } break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            analize();
            Close();
        }
    }
}
