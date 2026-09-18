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
    public partial class funtions : Form
    {
        public funtions()
        {
            InitializeComponent();
            if (key.lengprog == 2)
            {
                button4.Enabled = false;
                button4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.color();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (key.lengprog)
            {
                case 1:
                    {
                        key.code = "system(" + (char)34 + "PAUSE" + (char)34 + ");";
                    } break;
                case 2:
                    {
                        key.code = "Console.ReadKey(true);";
                    } break;
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open.time();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (key.lengprog)
            {
                case 1:
                    {
                        key.code = "return 0;";
                    } break;
            }
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
