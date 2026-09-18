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
    public partial class est : Form
    {
        public est()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            open.ifw(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            open.switchw(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
