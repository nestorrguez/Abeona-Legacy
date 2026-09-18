using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CodeGenCPP
{
    public partial class help : Form
    {
        int d,b,f;
        string a;
        public help()
        {
            InitializeComponent();
            a = Directory.GetCurrentDirectory().ToString() + @"/res/help/";
            string[]  dirs = Directory.GetFiles(a, "*.txt");
            d = dirs.Length;
            if (open.help == 0)
            {
                f = d - 1;
                System.IO.StreamReader myStreamReader = null;
                myStreamReader = System.IO.File.OpenText(a + "text[" + f + "].txt");
                text.Text = myStreamReader.ReadToEnd();
                picture.ImageLocation = a + "picture[" + f + "].bmp";
            }
            else
            {
                f = open.help;
                System.IO.StreamReader myStreamReader = null;
                myStreamReader = System.IO.File.OpenText(a + "text[" + f + "].txt");
                text.Text = myStreamReader.ReadToEnd();
                picture.ImageLocation = a + "picture[" + f + "].bmp";
            }
            textBox1.Text = f + "/" + d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f--;
            if (f >= 0)
            {
                System.IO.StreamReader myStreamReader = null;
                myStreamReader = System.IO.File.OpenText(a + "text[" + f + "].txt");
                text.Text = myStreamReader.ReadToEnd();
                picture.ImageLocation = a + "picture[" + f + "].bmp";
                textBox1.Text = f + "/" + d;
            }
            else
            {
                open.window("Atencion","No se puede retoceder mas",true);
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f++;
            if (f >= d)
            {
                open.window("Atencion", "No se puede avanzar mas", true);
            }
            else
            {
                System.IO.StreamReader myStreamReader = null;
                myStreamReader = System.IO.File.OpenText(a + "text[" + f + "].txt");
                text.Text = myStreamReader.ReadToEnd();
                picture.ImageLocation = a + "picture[" + f + "].bmp";
                textBox1.Text = f + "/" + d;
            }
        }
    }
}
