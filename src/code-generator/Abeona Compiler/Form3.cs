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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            declare();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "AND")
            {
                textBox1.Text = textBox1.Text + "&&";
            }
            else if (comboBox2.Text == "OR")
            {
                textBox1.Text = textBox1.Text + "||";
            }
            else if (comboBox2.Text == "NOT")
            {
                textBox1.Text = textBox1.Text + "!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectAll();
            textBox1.Copy();
        }      

        void declare()
        {           
                System.Object[] ItemObject = new System.Object[440];
                for (int c = 1; c <= key.n; c++)
                {
                    ItemObject[c] = key.var[c];
                    comboBox5.Items.Add(ItemObject[c]);
                }            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Menor que")
            {
                textBox1.Text = textBox1.Text + "<";
            }
            else if (comboBox4.Text == "Mayor que")
            {
                textBox1.Text = textBox1.Text + ">";
            }
            if (comboBox4.Text == "Igual que")
            {
                textBox1.Text = textBox1.Text + "==";
            }
            else if (comboBox4.Text == "Mayor Igual que")
            {
                textBox1.Text = textBox1.Text + ">=";
            }
            if (comboBox4.Text == "Menor Igual que")
            {
                textBox1.Text = textBox1.Text + "<=";
            }
            else if (comboBox4.Text == "Diferente que")
            {
                textBox1.Text = textBox1.Text + "!=";
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + comboBox5.Text;
        }
    }
}
