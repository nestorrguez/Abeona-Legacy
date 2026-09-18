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
    public partial class declaration : Form
    {
        public declaration()
        {
            InitializeComponent();
            this.Text = open.tittle;
            label1.Text = "Escribe el valor de: " + open.tittle;
            richTextBox1.Text=open.text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
