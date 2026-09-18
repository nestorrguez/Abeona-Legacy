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
    public partial class For2 : Form
    {
        int a,b,c;
        bool doit;
        string value,f;
        public For2()
        {
            InitializeComponent();
            declare();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor();
            o();
            key.code = "for(" + listBox1.Text + "=" + textBox1.Text + ";" +listBox1.Text + value + comboBox4.Text + ";" + f + ")" + "\r\n" + "{";
            Close();
        }

        void o()
        {
            if (comboBox5.Text == "Incrementa" && textBox3.Text == "1")
            {
                f = listBox1.Text + "++";
            }
            else
            {
                if (comboBox5.Text == "Incrementa" && textBox3.Text != "1")
                {
                    f = listBox1.Text + "+=" + textBox3.Text ;
                }
                else
                {
                    if (comboBox5.Text == "Decrementa" && textBox3.Text == "1")
                    {
                        f = listBox1.Text + "--";
                    }
                    else
                    {
                        if (comboBox5.Text == "Decrementa" && textBox3.Text != "1")
                        {
                            f = listBox1.Text + "-=" + textBox3.Text;
                        }
                    }
                }
            }
        }

        void valor()
        {
            if (comboBox3.Text == "Menor que")
            {
                value = "<";
            }
            else
            {
                if (comboBox3.Text == "Mayor que")
                {
                    value = ">";
                }
                else
                {
                    if (comboBox3.Text == "Igual que")
                    {
                        value = "==";
                    }
                    else
                    {
                        if (comboBox3.Text == "Mayor Igual que")
                        {
                            value = ">=";
                        }
                        else
                        {
                            if (comboBox3.Text == "Menor Igual que")
                            {
                                value = "<=";
                            }
                            else
                            {
                                if (comboBox3.Text == "Diferente que")
                                {
                                    value = "!=";
                                }                                
                            }
                        }
                    }
                }
            }
        }


        void declare()
        {
            string[] item = new string[440];
            for (a = 1; a <= key.n; a++)
            {
                if (key.kind[a] == 1)
                {
                    item[a] = key.var[a];
                    item[a] = key.var[a];
                    if (key.kind[a] == 1)
                    {
                        listBox1.Items.Add(item[a]);
                        comboBox4.Items.Add(item[a]);
                    }
                }                
            }
            /*
            string[] ite = new string[440];
            for (b = 1; b <= key.n; b++)
            {
                if (key.kind[b] == 1)
                {
                    ite[b] = key.var[b];
                }
                comboBox1.Items.Add(ite[b]);
            }

            string[] it = new string[440];
            for (c = 1; c <= key.n; c++)
            {
                if (key.kind[a] == 1)
                {
                    it[c] = key.var[b];
                }
                comboBox2.Items.Add(it[c]);
            }
            string[] i = new string[440];
            for (c = 1; c <= key.n; c++)
            {
                if (key.kind[a] == 1)
                {
                    i[c] = key.var[b];
                }
                comboBox4.Items.Add(i[c]);
            } */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Text = textBox1.Text;
            listBox1.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}              
    }
}
