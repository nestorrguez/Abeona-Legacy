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
    public partial class time : Form
    {
        public time()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (key.lengprog)
            {
                case 1:
                    {
                        key.code = "Sleep(" + textBox1.Text + ");";
                    } break;
                case 2:
                    {
                        key.code = "System.Threading.Thread.Sleep(" + textBox1.Text + ");";
                    } break;

            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
