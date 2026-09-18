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
    public partial class conditions : Form
    {
        public conditions()
        {
            InitializeComponent();
            this.Text = key.title;
            Box.Text = "Escribe la condicion para el ciclo " + key.info;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (key.cic)
            {
                case 1:
                    {
                        key.code = "while(" + textBox1.Text + ")" + "\r\n" + "{";
                    } break;
                case 2:
                    {
                        key.code = "}while(" + textBox1.Text + ");";
                    } break;
                case 3:
                    {
                        key.code = "if(" + textBox1.Text + ")" + "\r\n" + "{";
                    } break;
            }
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
