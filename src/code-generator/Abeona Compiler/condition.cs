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
    public partial class condition : Form
    {
        public condition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.switchv();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open.ifv();
            this.Close();
        }
    }
}
