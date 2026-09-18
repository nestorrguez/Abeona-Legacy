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
    public partial class convertO : Form
    {
        string s;
        int aclass, bclass, akind, bkind;
        public convertO()
        {
            InitializeComponent();
            textBox1.Text = objets.a;
            textBox2.Text = objets.b;

            System.Object[] ItemObject = new System.Object[440];
            for (int g = 0; g <= claz.numclass; g++)
            {
                ItemObject[g] = claz.variables[g, 0];
                comboBox2.Items.Add(ItemObject[g]);
            }

            for (int c = 0; c <= claz.numclass; c++)
            {
                if (textBox1.Text == claz.variables[c, 0])
                {
                    aclass = c;
                    break;
                }
            }
            for (int c = 1; c <= claz.numvar[aclass]; c++)
            {
                if (textBox2.Text == claz.variables[aclass, c])
                {
                    akind = claz.kindvar[aclass, c];
                    break;
                }
            }
            comboBox3.Items.Clear();
            if (akind >= 1 && akind <= 3)
            {
                comboBox3.Items.Add("Cadena de Caracteres");
            }
            else if (akind == 4)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int c = 0; c <= claz.numclass; c++)
            {
                if (comboBox2.Text == claz.variables[c, 0])
                {
                    bclass = c;
                }
            }

            System.Object[] ItemObject = new System.Object[440];
            for (int c = 0; c <= claz.numvar[bclass]; c++)
            {
                if (claz.kindvar[bclass, c] == bkind)
                {
                    ItemObject[c] = claz.variables[bclass, c];
                    comboBox2.Items.Add(ItemObject[c]);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            bkind = 0;
            /*
             Entero
             Doble
             Caracter
             Flotante
             Cadena de Caracteres
            */
            comboBox3.Items.Clear();
            if (comboBox3.Text == "Entero")
                bkind = 1;
            else if (comboBox3.Text == "Doble")
                bkind = 3;
            else if (comboBox3.Text == "Caracter")
                bkind = 4;
            else if (comboBox3.Text == "Flotante")
                bkind = 2;
            else if (comboBox3.Text == "Cadena de Caracteres")
                bkind = 5;
            comboBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                open.window("Atencion", "Uno de los campos esta vacio", true);
            }
            else
            {
                string adata, bdata;
                adata = textBox1.Text + "." + textBox2.Text;
                bdata = comboBox2.Text + "." + comboBox1.Text;
                if (bkind == 5)
                    to.code = bdata + " = " + adata + ".ToString();";
                else if ((akind == 5 || akind == 4) && (bkind <= 3 && bkind >= 1))
                    to.code = bdata + " = " + s + ".Parse(" + adata + ");";
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = "";
            for (int c = 1; c <= claz.numvar[bclass]; c++)
            {
                if (comboBox1.Text == claz.variables[bclass, c])
                {
                    int f = claz.kindvar[bclass, c];
                    switch (f)
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

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(19);
        }
    }
}
