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
    public partial class cic : Form
    {
        public cic()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            open.forw(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            open.whilew(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            open.do_whilew(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(11);
        }
    }
}
