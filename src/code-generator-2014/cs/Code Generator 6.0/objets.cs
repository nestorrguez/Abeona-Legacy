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
    public partial class objets : Form
    {
        public static string a, b;
        public static int c,cs,j;
        public objets()
        {
            InitializeComponent();
            /*if (open.lib == false && open.main == true || open.close == false && open.namezpace == true)
            {
                button2.Enabled = true;
                panel1.Enabled = false;
            }
            else
            {*/
                button2.Enabled = true;
                panel1.Enabled = true;
                System.Object[] ItemObject = new System.Object[440];
                for (int g = 0; g <= claz.numclass; g++)
                {
                    ItemObject[g] = claz.variables[g, 0];
                    comboBox1.Items.Add(ItemObject[g]);
                }
            //}
         }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (c = 0; c <= claz.numclass; c++)
            {
                if (claz.variables[c, 0] == comboBox1.Text)
                {
                    System.Object[] ItemObject = new System.Object[440];
                    for (int i = 1; i <= claz.numvar[c]; i++)
                    {
                        if (claz.variables[c, i].Contains("()"))
                        { }
                        else
                        {
                            ItemObject[(c * 10) + i] = claz.variables[c, i];
                            comboBox2.Items.Add(ItemObject[(c * 10) + i]);
                        }
                    }
                    break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Contains("()"))
            {
                to.code = comboBox1.Text + "." + comboBox2.Text;
            }
            else
            {                
                for (int i = 1; i <= claz.numvar[c]; i++)
                {
                    if (comboBox1.Text == claz.variables[c, i])
                    {
                        j = i;
                        break;
                    }

                }
                if (claz.kindvar[c, j] == 5)
                {
                    to.code = comboBox1.Text + "." + comboBox2.Text + " = Console.ReadLine();";
                    Close();
                }
                else
                {
                    open.window("Atencion", "En C#, solo reciben datos las variables tipo ''Cadena de Caracteres''", true);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classes form = new classes();
            form.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            open.namevar = comboBox1.Text + "." + comboBox2.Text;
            Close();
            declare form = new declare();
            form.Show();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" || comboBox2.Text != "")
            {
                a = comboBox1.Text;
                b = comboBox2.Text;
                convertO form = new convertO();
                form.Show();
                this.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.Contains("()"))
            {
                button1.Enabled = false;
                button5.Enabled = false;
                button6.Text = "Llamar metodo";
            }
            else
            {
                button1.Enabled = true;
                button5.Enabled = true;
                button6.Text = "Pedir Valor";
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(15);
        }
    }
}
