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
    public partial class body : Form
    {
        public body()
        {
            InitializeComponent();

            if (key.libut) button1.Enabled = true;            
            else button1.Enabled = false;

            if (key.main==true)
            {
                button2.Enabled = true;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = false;                
                button3.Enabled = true;                
            }
            if (key.lengprog == 2)
            {
                button1.Enabled = false;
                button1.Text = " ";
            }
           
            
       }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            key.code = textBox1.Text;

            if (button1.Enabled) key.libut = true;
            else key.libut = false;

            if (button2.Enabled)
            {
                key.main = true;
                key.end = false;
            }
            else
            { 
                key.main = false; 
                key.end = true;
            }

            if (button3.Enabled) key.end = true;
            else key.end = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(key.lengprog)
            {
                case 1:
                {
                   textBox1.Text = "#include <iostream> \r\n#include <cstdlib> \r\n#include <windows.h> \r\nusing namespace std;";                   button1.Enabled = false;
                } break;

           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key.libut)
            {
                switch (key.lengprog)
                {
                    case 1:
                        {
                            textBox1.Text = textBox1.Text + "\r\nmain() \r\n{";
                            button2.Enabled = false;
                        } break;
                    case 2:
                        {
                            textBox1.Text = textBox1.Text + "using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Linq;" + "\r\n" + "using System.Text;" + "\r\n" + "namespace cs_program;" + "\r\n" + "{" + "\r\n" + "class program" + "\r\n" + "{" + "\r\n" + "static void Main(string[] args)" + "\r\n{";
                            button2.Enabled = false;
                        } break;
                    
                }
            }
            else
            {
                {
                    switch (key.lengprog)
                    {
                        case 1:
                            {
                                textBox1.Text = textBox1.Text + "main() \r\n{";
                                button2.Enabled = false;
                            } break;
                        case 2:
                            {
                                textBox1.Text = textBox1.Text + "using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Linq;" + "\r\n" + "using System.Text;" + "\r\n" + "namespace cs_program;" + "\r\n" + "{" + "\r\n" + "class Program" + "\r\n" + "{" + "\r\n" + "static void Main(string[] args)" + "\r\n{";
                                button2.Enabled = false;
                            } break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (key.lengprog)
            {
                case 1:
                    {
                        textBox1.Text = "}";
                        key.main = false;
                        button3.Enabled = false;
                    } break;
                case 2:
                    {
                        textBox1.Text = "}" + "\r\n}" + "\r\n}";
                        key.main = false;
                        button3.Enabled = false;
                    } break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (key.libut)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
            }

            if (key.libut)
            {
                button2.Enabled = true;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = false;
            }
        }
    }
}
