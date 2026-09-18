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
    public partial class vector : Form
    {
        int c, t, n, m, M, s, i, a,k=0,j=1;
        string kind,w,p1,p2;
        bool doit, does,on,onn;
        public vector()
        {
            InitializeComponent();
            button1.Enabled = false;
            button6.Enabled = false;
            TextBox2.Enabled = false;
            TextBox1.Enabled = false;
            System.Object[] ItemObject = new System.Object[440];
            System.Object[] Item = new System.Object[440];
            for (c = 1; c <= key.n; c++)
            {
                ItemObject[c] = key.var[c];
                Item[c] = key.vec[c];
                listBox1.Items.Add(Item[c]);
                comboBox1.Items.Add(ItemObject[c]);
            }
            label6.Text = "Tamaño de la " + j + "º dimension:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validation {
            doit = true;
            if (key.v >= 1)
            {
                for (c = 1; c <= key.v; c++)
                {
                    if (george.Text == key.vec[c] || george.Text == key.var[c])
                    {
                        doit = false;
                        t = 0;
                        break;
                    }
                }
            }
            // Validation }
            //Verification {
            n = 0; m = 0; M = 0; s = 0;
            for (c = 0; c <= george.Text.Length; c++)
            {
                does = true;
                //Numeros
                for (i = 48; i <= 57; i++)
                {
                    if (george.Text[c] == (char)i)
                    {
                        n++;
                    }
                }
                //minisculas
                for (i = 97; i <= 122; i++)
                {
                    if (george.Text[c] == (char)i)
                    {
                        m++;
                    }
                }
                //Mayusculas
                for (i = 65; i <= 90; i++)
                {
                    if (george.Text[c] == (char)i)
                    {
                        M++;
                    }
                }
                //Caracteres Especiales
                for (i = 1; i <= 47; i++)
                {
                    if (george.Text[c] == (char)i)
                    {
                        s++;
                    }
                }

                for (i = 58; i <= 64; i++)
                {
                    if (george.Text[c] == (char)i)
                    {
                        s++;
                    }
                }

                for (i = 91; i <= 96; i++)
                {
                    if (george.Text[c] == (char)i)
                    {
                        s++;
                    }
                }

                for (i = 123; i <= 255; i++)
                {
                    if (george.Text[c] == (char)i)
                    {
                        s++;
                    }
                }

                if (n > 0 && m == 0 || n > 0 && M == 0)
                {
                    does = false;
                    t = 1;
                }
                if (s > 0)
                {
                    does = false;
                    t = 2;
                }
                for (c = 0; c <= 9; c++)
                {
                    if (george.Text[0] == c)
                    {
                        does = false;
                        t = 3;
                        break;
                    }
                }
            }

            //Verification }
            if (button6.Enabled == true)
            {
                t = 4;
            }

            if (doit == true && does == true && button6.Enabled==false)
            {
                //Declaration {
                key.v = key.v + 1;                
                key.vec[key.n] = george.Text;
                key.kinv[key.n] = a;
                switch (key.lengprog)
                {
                    case 1:
                        {
                            key.code = w+";";
                            Close();
                        } break;
                    case 2:
                        {
                            key.code = p1+george.Text+p2+";";
                            Close();
                        } break;
                }
                
                //Declaration }
            }
            else
            {
                //Error {               
                switch (t)
                {
                    case 0:
                        {
                            open.window("Error", "Identificador " + george.Text + " ya ha sido utilizado previamente", true);
                        }
                        break;

                    case 1:
                        {
                            open.window("Error", "No se pueden utilizar solo numeros como identificador, o al principio del mismo", true);
                        }
                        break;

                    case 2:
                        {
                            open.window("Error", "No se pueden utilizar caracteres especiales en un identificador", true);
                        }
                        break;

                    case 3:
                        {
                            open.window("Error", "No se pueden utilizar solo numeros como identificador, o al principio del mismo", true);
                        }
                        break;

                    case 4:
                        {
                            open.window("Error", "No se ha completado la declaracion del arreglo", true);
                        }
                        break;

                    default:
                        {
                            open.window("Error", "No especificado", true);
                        }
                        break;
                }
                george.Clear();
                //Error }  
            }
        }     

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            switch (key.lengprog)
            {
                case 1:
                    {
                        kind = "string ";
                        a = 5;
                    } break;

                case 2:
                    {
                        kind = "string ";
                        a = 5;
                    } break;
            }
            openit();
        }
        void openit()
        {
            if (kind!="" && george.Text!="" && button6.Enabled == false)
            {
                button1.Enabled = true;
                switch (key.lengprog)
                {
                    case 1:
                    w = kind + george.Text;
                    break;
                    case 2:
                    p1=kind;
                    p2 = " = new " + kind;
                    break;
                }
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            switch (key.lengprog)
            {
                case 1:
                    {
                        kind = "int ";
                        a = 1;
                    } break;
                case 2:
                    {
                        kind = "int ";
                        a = 1;
                    } break;
            }
            openit();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            switch (key.lengprog)
            {
                case 1:
                    {
                        kind = "float ";
                        a = 2;
                    } break;
                case 2:
                    {
                        kind = "float ";
                        a = 2;
                    } break;
            }
            openit();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            switch (key.lengprog)
            {
                case 1:
                    {
                        a = 3;
                        kind = "char ";
                    } break;
                case 2:
                    {
                        a = 3;
                        kind = "char ";
                    } break;
            }
            openit();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            switch (key.lengprog)
            {
                case 1:
                    {
                        a = 4;
                        kind = "double ";
                    } break;
                case 2:
                    {
                        a = 4;
                        kind = "double ";
                    } break;
            }
            openit();
        }

        private void george_TextChanged(object sender, EventArgs e)
        {
            onn = true;
            if (george.Text.Length >= 1)
            {
                TextBox1.Enabled = true;                
            }
            openit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                TextBox2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            j++;
            label6.Text = "Tamaño de la "+ j +"º dimension:";
            k = int.Parse(TextBox1.Text);
            if (j > k)
            {
                button6.Enabled = false;
                label6.Text = "-----";
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                TextBox1.Clear();
                TextBox2.Clear();
            }
            else
            {
                w = w + "[" + TextBox2.Text + "]";
                p1 = p1 + "[]";
                p2 = p2 + "[" + TextBox2.Text + "]";
                TextBox1.Clear();
                TextBox2.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }          
                  
    }
}
