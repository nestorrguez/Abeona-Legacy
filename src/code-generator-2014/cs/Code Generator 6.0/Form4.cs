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
    public partial class Form4 : Form
    {
        string dir;
        int c, n;
        public Form4()
        {
            InitializeComponent();
            dir = System.IO.Directory.GetCurrentDirectory() + @"\res\help\";
            string[] dirs = System.IO.Directory.GetFiles(dir, "*.BMP");
            c = dirs.Length;            
            n = open.hn;
            textBox2.Text = "/" + c;
            show(n); 
        }

        void show(int a)
        {
            //4 Text           
            /*System.IO.StreamReader myStreamReader = null;
            myStreamReader = System.IO.File.OpenText(dir + "h[" + a + "].txt");
            text.Text = myStreamReader.ReadToEnd();     */
            //4 Picture
            pict.ImageLocation = dir + "p[" + a + "].BMP";
            textBox1.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show(0);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0)
            {
                n = 0;
                show(n);
            }
            else
                show(n);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n++;
            if (n > c)
            {
                n = c - 1;
                show(n);
            }
            else
                show(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show(c - 1);
        }
    }
}

