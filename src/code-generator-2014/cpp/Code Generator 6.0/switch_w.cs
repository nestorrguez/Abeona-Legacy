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
    public partial class switch_w : Form
    {
        int k,n,c,b;
        string[] change = new string[1500];
        public switch_w()
        {
            InitializeComponent();
            System.Object[] ItemObject = new System.Object[440];
            for (int g = 1; g <= claz.numclass; g++)
            {
                if (claz.variables[0, g].Contains("()"))
                {
                    ItemObject[g] = claz.variables[0, g];
                    toolStripComboBox1.Items.Add(ItemObject[g]);
                }
            }
        }

        private void abrirswitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("switch("))
            {
                abrirswitchToolStripMenuItem.Enabled = false;
            }
            else
            {
                switch_c form = new switch_c();
                form.Show();
            }
        }

        private void cerrarswitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";
            cerrarswitchToolStripMenuItem.Enabled = false;
        }

        private void abrircaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            @case form = new @case();
            form.Show();
        }

        private void cerrarcaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\nbreak;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (abrirswitchToolStripMenuItem.Enabled == false && cerrarcaseToolStripMenuItem.Enabled == false)
            {
               a =  new System.Text.RegularExpressions.Regex("case").Matches(richTextBox1.Text).Count;
               b = new System.Text.RegularExpressions.Regex("break").Matches(richTextBox1.Text).Count;
               if (a == b)
               {
                   to.code = richTextBox1.Text;
                   Close();
               }
               else
               {
                   open.window("Atencion", "No se han cerrado todos los casos que se han abierto o se han cerrado mas casos de los que se han abierto, verifica tu codigo", true);
               }

            }
            else
            {
                open.window("Atencion","No se a cerrado el switch",true);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (to.code == "")
            {
                open.window("Advertencia", "No se a ingresado una accion", true);
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\r\n" + to.code;
                n++;
                change[n] = richTextBox1.Text;
                to.code = "";
                k = n;
                if (richTextBox1.Text.Contains("switch("))
                {
                    abrirswitchToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abrirswitchToolStripMenuItem.Enabled = true;
                }
            }

            if(to.code.Contains("case"))
            {
                c++;
            }
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.color();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1: richTextBox1.Text = "system(" + (char)34 + "PAUSE" + (char)34 + ");"; break;
                case 2: richTextBox1.Text = "Console.ReadKey(true);"; break;
            }
        }

        private void retrasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.delayt();
        }

        private void iFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.ifw(open.a);
        }

        private void sWITCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.switchw(open.a);
        }

        private void dOWHILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.do_whilew(open.a);
        }

        private void wHILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.whilew(open.a);
        }

        private void fORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.forw(open.a);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            k = k - 1;
            if (k < 0)
            {
                open.window("Advertencia", "No se a ingresado una accion", true);
            }
            else
            {
                richTextBox1.Text = change[k];
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > n)
            {
                open.window("Advertencia", "No se a ingresado una accion", true);
            }
            else
            {
                richTextBox1.Text = change[k];               
            }   
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            open.printf(open.a);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            open.variable(open.a,1);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.coment();
        }        
    }
}
