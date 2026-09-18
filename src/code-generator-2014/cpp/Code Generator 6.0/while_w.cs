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
    public partial class while_w : Form
    {
        int k, n;
        string[] change = new string[1500];
        public while_w()
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

        private void abririfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("while("))
            {
                abririfToolStripMenuItem.Enabled = false;
            }
            else
            {
                open.constant("while");
            }
        }

        private void cerrarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n{";
            cerrarifToolStripMenuItem.Enabled = false;
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.color();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1: to.code = "system(" + (char)34 + "PAUSE" + (char)34+");"; break;
                case 2: to.code = "Console.ReadKey(true);"; break;
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

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            open.printf(open.a);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            open.variable(open.a, 1);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.coment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (abririfToolStripMenuItem.Enabled == false && abririfToolStripMenuItem.Enabled == false)
            {
                to.code = richTextBox1.Text;
                Close();
            }
            else
            {
                open.window("Atencion","Se ha abierto un ''while'' pero no se ha cerrado",true);
            }
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
                if (richTextBox1.Text.Contains("while("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarifToolStripMenuItem.Enabled = true;
                }
            }
        }
    }
}
