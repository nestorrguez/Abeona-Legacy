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
    public partial class variable : Form
    {
        string kind, b;
        int a;
        int x;
        int wrong;
        public variable()
        {
            InitializeComponent();
            wrong = 0;
            a = 0;
            x = open.nv;
            switch (open.size)
            {
                case 0:
                    label1.Visible = true;
                    panel1.Visible = true;
                    label4.Visible = true;
                    panel3.Visible = true;
                    this.Text = "Opciones de Variable";
                    break;
                case 1:
                    panel1.Visible = false;
                    label1.Visible = false;
                    this.Text = "Utilizar Variable";
                    break;
                case 2:
                    panel3.Visible = false;
                    label4.Visible = false;
                    this.Text = "Nueva Variable";
                    break;
            }

            int c;

            if (claz.numvar[x] < 1)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                System.Object[] ItemObject = new System.Object[440];
                for (c = 1; c <= claz.numvar[x]; c++)
                {
                    if (claz.variables[x, c].Contains("()"))
                    { }
                    else
                    {
                        ItemObject[c] = claz.variables[x, c];
                        comboBox1.Items.Add(ItemObject[c]);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    a = 1;
                    kind = "int ";
                    break;
                case 2:
                    a = 1;
                    kind = "int ";
                    break;
            };
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    a = 2;
                    kind = "float ";
                    break;
                case 2:
                    a = 2;
                    kind = "float ";
                    break;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    a = 3;
                    kind = "char ";
                    break;
                case 2:
                    a = 3;
                    kind = "char ";
                    break;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    a = 4;
                    kind = "double ";
                    break;
                case 2:
                    a = 4;
                    kind = "double ";
                    break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    a = 5;
                    kind = "void ";
                    break;
                case 2:
                    a = 5;
                    kind = "void ";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                if (a == 5)
                {
                    if (textBox1.Text.Contains("()"))
                    {                        
                        to.code =kind + textBox1.Text + ";";
                        claz.numfunt++;
                        claz.funtdef[x, 0] = textBox1.Text;
                        claz.funtdef[x, 1] = "0";
                    }
                    else
                    {                        
                        to.code = b + kind + textBox1.Text + "();";
                        claz.numfunt++;
                        claz.funtdef[x, 0] = textBox1.Text + "()";
                        claz.funtdef[x, 1] = "0";
                    }

                }
                else
                {
                    claz.numvar[x]++;
                    claz.kindvar[x, claz.numvar[x]] = a;
                    claz.variables[x, claz.numvar[x]] = textBox1.Text;
                    to.code = b + kind + textBox1.Text + ";";
                }
                Close();
            }
            else
            {
                open.window("Atencion", "No se ha seleccionado un tipo de dato, por favor seleccione uno", true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            switch (to.lenprog)
            {
                case 1:
                    to.code = "cin>>" + comboBox1.Text + ";";
                    break;

                case 2:
                    for (int i = 1; i <= claz.numvar[x]; i++)
                    {
                        if (comboBox1.Text == claz.variables[x, i])
                        {
                            j = i;
                            break;
                        }

                    }

                    if (claz.kindvar[x, j] == 5)
                    {
                        to.code = comboBox1.Text + " = Console.Readline();";
                        Close();
                    }
                    else
                    {
                        open.window("Atencion", "En C#, solo reciben datos las variables tipo ''Cadena de Caracteres''", true);
                    }
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            open.namevar = comboBox1.Text;
            Close();
            declare form = new declare();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            open.namevar = comboBox1.Text;
            Close();
            conbert form = new conbert();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
