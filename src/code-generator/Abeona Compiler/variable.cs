using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class variable : Form
    {
        int c,a=1,i,n,m,M,s,t,g=1,j=1,k=0;
        string kind="";
        bool doit,does,on,onn;        
        public variable()
        {
            InitializeComponent();
            declare();
            button1.Enabled = true;
            j = 1;
            if (key.lengprog == 2)
            { button4.Enabled = true; }
            else
            {
                button4.Enabled = false;
                button4.Text = "";
            }            
        }

        void openit()
        {
            if (on == true && onn == true) { button1.Enabled = true; }              
        }

        void verification()
        {
            //Validation {            

            for (c = 1; c <= key.n; c++)
            {
                if (george.Text != key.var[c])
                {
                    k++;
                }
                else
                {
                    k--;
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
                for (i = 1; i < 48; i++)
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
                if (george.Text.Contains(','))
                {
                    does = false;
                    t = 2;
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
        }

        void declaration()
        {
            if (george.Text=="") t = 5;
            if (kind=="" || a==0) t = 4;
            if (k < key.n) { t = 0; doit = false; }
            else { doit = false; }
            if (k==key.n && does == true && kind!="" && george.Text!="")
            {
                //Declaration {
                key.n = key.n + 1;
                key.num = key.n;
                key.var[key.n] = george.Text;
                key.kind[key.n] = a;
                switch (key.lengprog)
                {
                    case 1:
                        {
                            key.code = kind + george.Text + ";";
                        } break;
                    case 2:
                        {
                            key.code = kind + george.Text + ";";
                        } break;
                }
                Close();
                //Declaration }
            }
            else
            {
                //Error {                  
                switch (t)
                {
                    case 0:
                        {
                            open.window("Error", "El identificador " + george.Text + " ya ha sido utilizado previamente", true);
                            george.Clear();
                        }
                        break;
                    case 1:
                        {
                            open.window("Error", "No se pueden utilizar solo numeros como identificador, o al principio del mismo", true);
                            george.Clear();
                        }
                        break;
                    case 2:
                        {
                            open.window("Error", "No se pueden utilizar caracteres especiales en un identificador", true);
                            george.Clear();
                        }
                        break;
                    case 3:
                        {
                            open.window("Error", "No se pueden utilizar solo numeros como identificador, o al principio del mismo", true);
                            george.Clear();
                        }
                        break;
                    case 4:
                        {
                            open.window("Error", "No se  ha seleccionada el tipo de dato", true);
                        }
                        break;
                    default:
                        {
                            open.window("Error", "No especificado", true);
                            george.Clear();
                        }
                        break;
                    case 5:
                        {
                            open.window("Error", "No se  a escrito un identificador", true);
                            george.Clear();
                        }
                        break;
                }                
                //Error }                
            } 
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            verification();
            declaration();
        }

        void declare()
        {
            if (key.n < 1)
            {
                listBox1.Enabled = false;
            }
            else
            {
                listBox1.Enabled = true;
                System.Object[] ItemObject = new System.Object[440];
                for (c = 1; c <= key.n; c++)
                {
                    ItemObject[c] = key.var[c];
                    listBox1.Items.Add(ItemObject[c]);
                }
                
            }
        }        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            g = 0;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            g = 0;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            g = 0;
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            g = 0;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                switch (key.lengprog)
                {

                    case 1:
                        {
                            key.code = "cin>>" + listBox1.Text + ";";                           
                        } break;
                    case 2:
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
                            if (key.kind[a] == 5)
                            {
                                key.code = listBox1.Text + " = " + "Console.ReadLine();";
                            }
                            else
                            {
                                open.window("Atencion", "Solo variables del tipo ''Cadena de caracteres (string)'' pueden recibir datos en C#", true);
                            }
                        } break;  
                }
                Close();
            }
            else
            {
                open.window("Atencion","Seleccione la variable que desea usar antes de continuar",true);
            }           
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                key.varname = listBox1.Text;
                open.declare();
                this.Close();
            }
            else
            {
                open.window("Atencion", "Seleccione la variable que desea usar antes de continuar", true);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            on = true;
            g = 0;
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

        private void button4_Click(object sender, EventArgs e)
        {

            convert form = new convert();
            form.Show();
            Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            vector form = new vector();
            form.Show();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            on = true;
            g = 0;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            verification();
            declaration();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            on = true;
            g = 0;
            switch (key.lengprog)
            {
                case 1:
                    {
                        kind = "float ";
                        a = 1;
                    } break;
                case 2:
                    {
                        kind = "float ";
                        a = 1;
                    } break;
            }
            openit();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            on = true;
            g = 0;
            switch (key.lengprog)
            {
                case 1:
                    {
                        kind = "char ";
                        a = 1;
                    } break;
                case 2:
                    {
                        kind = "char ";
                        a = 1;
                    } break;
            }
            openit();
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            on = true;
            g = 0;
            switch (key.lengprog)
            {
                case 1:
                    {
                        kind = "double ";
                        a = 1;
                    } break;
                case 2:
                    {
                        kind = "double ";
                        a = 1;
                    } break;
            }
            openit();
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            on = true;
            g = 0;
            switch (key.lengprog)
            {
                case 1:
                    {
                        kind = "string ";
                        a = 1;
                    } break;
                case 2:
                    {
                        kind = "string ";
                        a = 1;
                    } break;
            }
            openit();
        }

        private void george_TextChanged_1(object sender, EventArgs e)
        {
            int x = george.Text.Length;
            if(x>0)
            {
                onn = true;
                j = 0;
            }
            else
            {
                j = 1;
            }
            openit();
        }                 
    }
}
