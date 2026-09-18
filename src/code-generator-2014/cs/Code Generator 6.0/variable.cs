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
    public partial class variable : Form
    {       
        string kind,b,vars;
        int a;
        int x;
        int wrong;
        public variable()
        {
            InitializeComponent();
            wrong = 0;
            //comboBox1.DataSource = "";
            a = 1;
            x = open.nv;
            kind = "int ";
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
                for (c = 1; c <= claz.numvar[x]; c++)
                {
                    comboBox1.Items.Add(claz.variables[x, c]);

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
                    a = 4;
                    kind = "char ";
                    break;
                case 2:
                    a = 4;
                    kind = "char ";
                    break;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    a = 3;
                    kind = "double ";
                    break;
                case 2:
                    a = 3;
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
                    kind = "string ";
                    break;
                case 2:
                    a = 5;
                    kind = "string ";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(','))
            {
                if (textBox1.Text[textBox1.Text.Length-1] == ',')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
                }
            }

            wrong = 0;            
            for (int c = 0; c <= claz.numvar[x]; c++) 
            {
                if (textBox1.Text.Contains(','))
                {
                    char[] h = { ',' };
                    string[] words = textBox1.Text.Split(h);
                    int f = words.Count();
                    for (int z = 0; z < f; z++)
                    {
                        if (words[z] == claz.variables[x, c])
                        {
                            wrong = 1;
                            vars = words[z];
                            break;                            
                        }
                    }
                }
                else
                {
                    if (textBox1.Text == claz.variables[x, c])
                    {
                        wrong = 1;
                        vars = textBox1.Text;
                        break;
                    }

                }
            }

            for (int c = 1; c <= 47; c++)
            {
                if (c == 44)
                { }
                else
                {
                    if (textBox1.Text.Contains((char)c))
                        wrong = 2;
                }
            }

            for (int c = 58; c <= 64; c++)
            {
                if (textBox1.Text.Contains((char)c))
                    wrong = 2;
            }

            for (int c = 91; c <= 96; c++)
            {
                if (textBox1.Text.Contains((char)c))
                    wrong = 2;
            }

            for (int c = 123; c <= 256; c++)
            {
                if (textBox1.Text.Contains((char)c))
                    wrong = 2;
            }

            if (textBox1.Text[0] >= '0' && textBox1.Text[0] <= '9')
            {
                wrong = 3;
            }

            if (textBox1.Text[0] == ',')
                wrong = 4;

                if (wrong == 0)
                {
                    if (textBox1.Text.Contains(','))
                    {
                        char[] h = { ',' };
                        string[] words = textBox1.Text.Split(h);
                        int f = words.Count();
                        for (int c = 0; c < f; c++)
                        {
                            claz.numvar[x]++;
                            claz.kindvar[x, claz.numvar[x]] = a;
                            claz.variables[x, claz.numvar[x]] = words[c];
                            to.code = b + kind + textBox1.Text + ";";
                            to.addvar(x.ToString(), claz.numvar[x].ToString(), words[c], a.ToString());
                        }
                        if (x != 0) b = "public static  ";
                        else b = "";
                        to.code = b + kind + textBox1.Text + ";";
                    }
                    else
                    {
                        if (x != 0) b = "public static  ";
                        else b = "";
                        claz.numvar[x]++;
                        claz.kindvar[x, claz.numvar[x]] = a;
                        claz.variables[x, claz.numvar[x]] = textBox1.Text;
                        to.code = b + kind + textBox1.Text + ";";
                        to.addvar(x.ToString(), claz.numvar[x].ToString(), textBox1.Text, a.ToString());
                    }
                    Close();
                }
                else
                {
                    switch(wrong)
                    {
                        case 1:
                            open.window("Atencion", "La variable \"" + vars + "\" ya ha sido previmanete declarada", true);
                            break;
                        case 2:
                            open.window("Atencion", "El nombre de la variable contiene caracteres invalidos", true);
                            break;
                        case 3:
                            open.window("Atencion", "El nombre puede tener numero al inicio", true);
                            break;
                        case 4:
                            open.window("Atencion", "Utiliza la coma para dividir variables despues del nombre", true);
                            break;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
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
                            to.code = comboBox1.Text + " = Console.ReadLine();";
                            Close();
                        }
                        else
                        {
                            open.window("Atencion", "En C#, solo reciben datos las variables tipo ''Cadena de Caracteres''", true);
                        }
                        break;
                }
            }
            else
                open.window("Atencion", "Debe seleccionar un variable primero", true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                open.namevar = comboBox1.Text;
                Close();
                declare form = new declare();
                form.Show();
            }
            else
                open.window("Atencion", "Debe seleccionar un variable primero", true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                open.namevar = comboBox1.Text;
                Close();
                conbert form = new conbert();
                form.Show();
            }
            else
                open.window("Atencion", "Debe seleccionar un variable primero", true);
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(3);
        }          
    }
}
