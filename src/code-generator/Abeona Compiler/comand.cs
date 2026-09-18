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
    public partial class comand : Form
    {
        public comand()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp();
            Close();
        }

        void comp()
        {
            if (text.Text == "PRINT" || text.Text == "IMPRIMIR")
            {
                open.printxt();
            }
            else if (text.Text == "VARIABLE")
            {
                open.variable();
            }
            else if (text.Text == "IF")          
            {
                open.ifv();
            }
            else if (text.Text == "SWITCH")
            {
                open.switchv();
            }
            else if (text.Text == "WHILE")
            {
                open.whilev();
            }
            else if (text.Text == "FOR")
            {
                open.forv();
            }
            else if (text.Text == "DOWHILE")
            {
                open.dowhile();
            }
            else if (text.Text == "BODY" || text.Text == "ESTRUCTURA")
            {
                open.body();
            }
            else if (text.Text == "CLOSEIT" || text.Text == "CERRAR")
            {
                Application.Exit();
            }
            else if (text.Text == "COMENTARY" || text.Text == "COMENTARIO")
            {
                open.comentary();
            }
            else if(text.Text == "FUNTIONS" || text.Text == "FUNCIONES")
            {
                open.funtions();
            }
            else if (text.Text == "GEN-FUN")
            {
                Form3 form = new Form3();
                form.Show();
            }
            else if (text.Text == "NAME-CLASS")
            {
                Form4 form = new Form4();
                form.Show();
            }
         }
       
    }
}
