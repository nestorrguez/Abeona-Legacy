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
    public partial class body : Form
    {
        public body()
        {
            InitializeComponent();
            /*if (open.lib) { button3.Enabled = true; }
            else { button3.Enabled = false;  }

            if (open.main) { button1.Enabled = true; }
            else { button1.Enabled = false; }

            if (open.lib == false && open.main == false)
            {
                if (open.close == false) button2.Enabled = false;
                else button2.Enabled = true;
            }
            else
                button2.Enabled = false;
            if (open.close == false)
            {
                if (open.namezpace == false) button6.Enabled = false;
                else button6.Enabled = true;
            }
            else
                button6.Enabled = false;*/
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
                    richTextBox1.Text = richTextBox1.Text + "\r\nclass Program\r\n{\r\nstatic void Main(string[] args)\r\n{\r\nConsole.Title=\""+Proyect.name+"\";";
                    break;
            }
            button1.Enabled = false;           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button3.Enabled == false)
            {
                open.lib = false;
                to.tab += "   ";
            }

            if (button1.Enabled == false)
            {
                open.main = false;
            }
            if (open.lib == false && open.main == false)
            {
                if (button2.Enabled == false)
                {
                    open.close = false;
                }
            }
            if (open.close == false)
            {
                if (button6.Enabled == false)
                {
                    open.namezpace = false;
                }
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
                    richTextBox1.Text = richTextBox1.Text + "using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\nnamespace " + Proyect.name.Replace(' ','_') +"\r\n{";
                    break;
            }
            button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";
            button6.Enabled = false;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.help(1);
        }
    }
}
