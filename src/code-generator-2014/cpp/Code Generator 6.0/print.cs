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
    public partial class print : Form
    {
        string toprint = "Console.Write(";
        string towrite = "cout<<";
        int c;
        string a;
        public print()
        {
            InitializeComponent();
            int x = open.nv;            
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
                    ItemObject[c] = claz.variables[x, c];
                    comboBox1.Items.Add(ItemObject[c]);
                }                
            }

            System.Object[] itemObject = new System.Object[440];
            for (int q = 1; q <= 256; q++)
            {
                itemObject[q] = (char)q;
                comboBox3.Items.Add(itemObject[q]);
            }

            c = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            if (c == 1)
            {
                toprint = toprint + (char)34 + textBox1.Text + (char)34;
                towrite = towrite + (char)34 + textBox1.Text + (char)34;
            }
            else if (c>1)
            {
                toprint = toprint + "+" + (char)34 + textBox1.Text + (char)34;
                towrite = towrite + "<<" + (char)34 + textBox1.Text + (char)34;
            }
            textBox2.Text = textBox2.Text + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comparation();
            textBox2.Text = textBox2.Text + comboBox3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        void comparation()
        {
            c++;
            for (int i = 1; i <= 256; i++)
            {
                if (comboBox3.Text == ((char)i + ""))
                {
                    a = i.ToString();
                    break;                    
                }
            }            
            if (c == 1)
            {
                toprint = toprint + "(char)" + a;
                towrite = towrite + "char(" + a + ")";
            }
            else if (c > 1)
            {
                toprint = toprint + "+" + "(char)" + a; ;
                towrite = towrite + "<<" + "char(" + a + ")";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c++;
            if (c == 1)
            {
                toprint = toprint + comboBox1.Text;
                towrite = towrite + comboBox1.Text;
            }
            else if (c > 1)
            {
                toprint = toprint +  "+" + comboBox1.Text;
                towrite = towrite + "<<" + comboBox1.Text;
            }
            textBox2.Text = textBox2.Text + "%" + comboBox1.Text + "%";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c++;
            if (c == 1)
            {
                toprint = toprint + (char)34 + (char)92 + (char)114 + (char)92 + (char)110 + (char)34;
                towrite = towrite + "endl";
            }
            else if (c > 1)
            {
                toprint = toprint + "+" + (char)34 + (char)92 + (char)114 + (char)92 + (char)110 + (char)34;
                towrite = towrite + "<<" + "endl";
            }
            textBox2.Text = textBox2.Text + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    to.code = towrite + ";";
                    break;
                case 2:
                    to.code = toprint + ");";
                    break;
            }
            Close();
        }
          
    }
}
