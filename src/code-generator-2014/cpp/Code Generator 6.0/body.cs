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
    public partial class body : Form
    {
        public body()
        {
            InitializeComponent();
            if (open.lib) { button3.Enabled = true; button6.Enabled = false; }
            else { button3.Enabled = false; button6.Enabled = true; }

            if (open.main) { button1.Enabled = true; button2.Enabled = false; }
            else { button1.Enabled = false; button2.Enabled = true; }

            if (open.close == false) button2.Enabled = false;
            else button2.Enabled = true;

            if (open.namezpace == false) button6.Enabled = false;
            else button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    richTextBox1.Text = richTextBox1.Text + "\r\nvoid main()\r\n{";
                    break;
                case 2:
                    richTextBox1.Text = richTextBox1.Text + "\r\nclass Program\r\n{\r\nstatic void Main(string[] args)\r\n{";
                    break;
            }
            button1.Enabled = false;           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button3.Enabled == false)
            {
                open.lib = false;
            }

            if (button1.Enabled == false)
            {
                open.main = false;
            }
            if (button2.Enabled == false)
            {
                open.close = false;
            }
            if (button6.Enabled == false)
            {
                open.namezpace = false;
            }
            to.code = richTextBox1.Text;
            Close();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    richTextBox1.Text = richTextBox1 + "\r\n}";
                    break;
                case 2:
                    richTextBox1.Text = richTextBox1.Text + "\r\n}\r\n}";
                    break;
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    richTextBox1.Text = richTextBox1.Text + "#include <iostream>\r\n#include <cstdlib> \r\n#include <windows.h> \r\nusing namespace std;";                    
                    break;
                case 2:
                    richTextBox1.Text = richTextBox1.Text + "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nnamespace program_cs\r\n{";
                    break;
            }
            button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";
            button6.Enabled = false;
        }
    }
}
