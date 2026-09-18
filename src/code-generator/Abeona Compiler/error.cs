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
    public partial class error : Form
    {       
        public error()
        {
            InitializeComponent();
            this.Text = key.title;
            box.Text = key.info;
            if (key.does)
            {
                button1.Text = "OK";
                button2.Enabled = false;
            }
            else
            {
                button1.Text = "Cerrar Aplicacion";
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key.does)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
