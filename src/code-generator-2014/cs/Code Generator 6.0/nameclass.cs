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
    public partial class nameclass : Form
    {
        public nameclass()
        {
            InitializeComponent();
            if (open.q == 1)
            {
                this.Text = "Nombre de la Clase";
                label1.Text = "Ingresa el nombre de la clase";
            }
            else
            {
                this.Text = "Nombre del Metodo";
                label1.Text = "Ingresa el nombre del metodo";
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            claz.numclass++;
            claz.variables[claz.numclass, 0] = textBox1.Text;

            if (open.q == 1)
            {
                to.code = "class " + textBox1.Text + "\r\n{";
                open.nameclass = textBox1.Text;
            }
            else
            {
                to.code = "public static void " + textBox1.Text + "\r\n{";
                open.namefunt = textBox1.Text;                
            }
            Close();
         }
    }
}
