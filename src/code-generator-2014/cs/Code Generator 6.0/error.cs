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
    public partial class error : Form
    {
        public error()
        {
            InitializeComponent();
            this.Text = open.tittle;
            richTextBox1.Text = open.text;
            if (open.ok)
            {
                button1.Text = "OK";
                button2.Enabled = false;
                button2.Text = "";
            }
            else
            {
                button1.Text = "Cerrar Aplicacion";
                button2.Text = "Cancelar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (open.ok)
            {
                Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (open.ok == false)
            {
                Close();
            }
        }
    }
}
