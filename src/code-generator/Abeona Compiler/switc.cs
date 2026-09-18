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
    public partial class swvar : Form
    {
        int c,a;
        bool doit;
        public swvar()
        {
            InitializeComponent();
            declare();
        }

        void declare()
        {
            string[] item = new string[440];
            for (c = 1; c <= key.n; c++)
            {
                item[c] = key.var[c];
                listBox1.Items.Add(item[c]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate();
            if (doit)
            {
                switch (key.lengprog)
                {
                    case 1:                        
                            key.code = "switch(" + listBox1.Text + ")" + "\r\n" + "{";
                            key.varnames = listBox1.Text;                        
                        break;

                    case 2:
                        key.code = "switch(" + listBox1.Text + ")" + "\r\n" + "{";
                            key.varnames = listBox1.Text;
                        break;
                }
            }
            else
            {
                key.title = "Atencion";
                key.info = "Selecciona una variable primero" + (char)34;
                key.does = true;
                open.error();
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void validate()
        {    
            if (listBox1.Text != "")
            {
                doit = true;
            }
            else
            {
                doit = false;
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

    }
}
