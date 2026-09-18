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
    public partial class convert : Form
    {
        int c,a,b;
        string d,e;
        bool doit;
        public convert()
        {
            InitializeComponent();
            string[] item = new string[440];
            for (c = 1; c <= key.n; c++)
            {
                item[c] = key.var[c];
                listBox1.Items.Add(item[c]);
                comboBox1.Items.Add(item[c]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void write()
        {
            validate();
            textBox1.Text= "La variable: " + comboBox1.Text + ", sus datos se converitan en tipo: " + e  + " y se guardaran en: "+ listBox1.Text;
        }

        void validate()
        {
            for (c = 1; c <= key.n; c++)
            {
                if (listBox1.Text == key.var[c])
                {
                    a = c;
                    break;
                }
                else
                {
                    continue;
                }                
            }
            b = key.kind[a];
            switch (b)
            {
                case 5:
                    {
                        d = "string";
                        e = "cadena de caracteres";
                    }break;

                case 3:
                    {
                        d = "char";
                        e = "caracter";
                    } break;

                case 2:
                    {
                        d = "flaot";
                        e = "flotante";
                    } break;

                case 1:
                {
                    d = "int";
                    e = "entero";
                } 
                break; 
             
                case 4:
                {
                    d = "double";
                    e = "doble";                    
                } 
                break;                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b == 5)
            {
                key.code = listBox1.Text + "=" + comboBox1.Text + ".ToString();";
                Close();
            }
            else
            {
                key.code = listBox1.Text + "=" + d + ".Parse(" + comboBox1.Text + ");";
                Close();
            }         

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            write();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            write();
        }
    }
}
