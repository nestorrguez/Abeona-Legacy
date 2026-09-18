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
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void web_Load(object sender, EventArgs e)
        {
            string a = "http://www.selenesoftware.blogspot.mx";
            webBrowser1.Navigate(a);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void adelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
