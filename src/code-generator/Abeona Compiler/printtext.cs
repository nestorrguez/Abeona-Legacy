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
    public partial class printtext : Form
    {
        int c,i,j;
        string a,b,totext="cout<<",toprint="Console.Write(";
        bool doit;
        public printtext()
        {
            InitializeComponent();
            declare();
        }      

        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        void declare()
        {
            string[] item = new string[440];
            for (c = 1; c <= 256; c++)
            {                
               item[c] = "" + ((char)c);                
               listBox1.Items.Add(item[c]);
            } 
              
            if (key.n < 1)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                System.Object[] ItemObject = new System.Object[440];
                for ( c = 1; c <= key.n; c++)
                {
                    ItemObject[c] = key.var[c];
                    comboBox1.Items.Add(ItemObject[c]);
                }                
            }                
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            for (c = 1; c <= 256; c++)
            {
                a = "" + ((char)c);
                b = c.ToString();               
                if (listBox1.Text == a)
                {
                    break;
                }
                else
                {
                    continue;
                }               
            }
            totext = totext + "<<char(" + b + ")<<";
            toprint = toprint + "+" +"(char)" + b ;
            Box.Text = Box.Text  + (char)c ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doit = true;
            // {
            string cadena = george.Text;
            for (c = 0; c <= 31; c++)
            {
                if (cadena.Contains((char)c))
                {
                    open.window("Atencion", "No puedes usar '" + (char)c + "' para agregar un caracter especial, seleccionalo de la lista", true);
                    doit = false;
                    break;
                }
            }

            for (c = 127; c <= 255; c++)
            {
                if (cadena.Contains((char)c))
                {
                    open.window("Atencion", "No puedes usar '" + (char)c + "' para agregar un caracter especial, seleccionalo de la lista", true);
                    doit = false;
                    break;
                }
            }

            if (cadena.Contains((char)34))
            {
                open.window("Atencion", "No puedes usar '" + (char)34 + "' para agregar un caracter especial, seleccionalo de la lista", true);
                doit = false;                
            }

            // }
            if (doit == true)
            {
                totext = totext + "+" + (char)34 + george.Text + (char)34;
                toprint = toprint + "<<" + (char)34 + george.Text + (char)34;
                Box.Text = Box.Text + george.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            totext = totext + "<<" + comboBox1.Text ;
            toprint = toprint + "+" + comboBox1.Text ;
            Box.Text = Box.Text + "% Valor de: " + comboBox1.Text + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            totext = totext + "<<" + "endl" ;
            toprint = toprint + (char)34+(char)92 + (char)114 + (char)92 + (char)110 + (char)34;
            Box.Text = Box.Text + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(key.lengprog)
            {
                case 1:
                    {
                        key.code = totext + (char)34 + ";";
                        Close();
                    }break;
                case 2:
                    {
                        key.code = toprint + (char)34 + ");";
                        Close();
                    } break;
        }
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Box.Clear();
            george.Clear();
            totext = "cout<<" + (char)34;
            toprint = "Console.Write(" + (char)34;
        }        
    }
}
