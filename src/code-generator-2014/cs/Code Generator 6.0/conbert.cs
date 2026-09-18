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
    public partial class conbert : Form
    {
        int x,a,b;
        string s;
        public conbert()
        {
            InitializeComponent();
            x = open.nv;
            textBox1.Text = open.namevar;
            comboBox3.Items.Clear();
            for (int c = 0; c <= claz.numvar[x]; c++)
            {
                if (textBox1.Text == claz.variables[x, c])
                    a = claz.kindvar[x, c];
            }
            if (a >= 1 && a <= 3)
            {
                comboBox3.Items.Add("Cadena de Caracteres");
            }
            else if(a == 4)
            {
                comboBox3.Items.Add("Entero");
                comboBox3.Items.Add("Flotante");
                comboBox3.Items.Add("Doble");
                comboBox3.Items.Add("Cadena de Caracteres");
            }
            else
            {
                comboBox3.Items.Add("Entero");
                comboBox3.Items.Add("Flotante");
                comboBox3.Items.Add("Doble");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            b = 0;
            /*
             Entero
             Doble
             Caracter
             Flotante
             Cadena de Caracteres
            */          
            if (comboBox3.Text == "Entero")
                b = 1;
            else if (comboBox3.Text == "Doble")
                b = 3;
            else if (comboBox3.Text == "Caracter")
                b = 4;
            else if (comboBox3.Text == "Flotante")
                b = 2;
            else if (comboBox3.Text == "Cadena de Caracteres")
                b = 5;

            System.Object[] ItemObject = new System.Object[440];
            comboBox2.Items.Clear();
            for (int c = 1; c <= claz.numvar[x]; c++)
            {                
                if (claz.kindvar[x, c] == b)
                {
                    ItemObject[c] = claz.variables[x, c];
                    comboBox2.Items.Add(ItemObject[c]);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = "";
            for (int c = 1; c <= claz.numvar[x]; c++)
            {
                if (comboBox2.Text == claz.variables[x, c])
                {
                    int f = claz.kindvar[x, c];
                    switch(f)
                    {
                        case 1:
                            s = "int";
                            break;
                        case 2:
                            s = "float";
                            break;
                        case 3:
                            s = "double";
                            break;
                        case 4:
                            s = "char";
                            break;
                        case 5:
                            s = "string";
                            break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || comboBox3.Text == "")
            {
                open.window("Atencion", "Uno de los campos esta vacio", true);
            }
            else
            {
                if (b == 5)
                    to.code = comboBox2.Text + " = " + textBox1.Text + ".ToString();";
                else if ((a == 5 || a == 4) && (b <= 3 && b >= 1))
                    to.code = comboBox2.Text + " = " + s + ".Parse(" + textBox1.Text + ");";
                Close();
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(18);
        }
    }
}
