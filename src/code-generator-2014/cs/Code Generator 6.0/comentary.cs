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
    public partial class comentary : Form
    {
        public comentary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            to.code = "//" + textBox1.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(2);
        }
    }
}
