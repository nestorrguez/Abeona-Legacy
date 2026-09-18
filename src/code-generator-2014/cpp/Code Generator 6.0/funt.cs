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
    public partial class funt : Form
    {
        int k, n;
        string[] change = new string[1500];
        public funt()
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

        private void funt_Load(object sender, EventArgs e)
        { }

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
                if (richTextBox1.Text.Contains("void"))
                {
                    abrirMetodoToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abrirMetodoToolStripMenuItem.Enabled = true;
                }
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
                if (richTextBox1.Text.Contains("void"))
                {
                    abrirMetodoToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abrirMetodoToolStripMenuItem.Enabled = true;
                }
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
                if (richTextBox1.Text.Contains("void"))
                {
                    abrirMetodoToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abrirMetodoToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (abrirMetodoToolStripMenuItem.Enabled == false && cerrarMetodoToolStripMenuItem.Enabled == false)
            {
                to.code = richTextBox1.Text;
                claz.numvar[claz.numclass]++;
                claz.variables[claz.numclass, claz.numvar[claz.numclass]] = open.namefunt + "()";
            }
            else 
            {
                open.window("Atencion", "Se ha abierto un ''metodo'' pero no se ha cerrado", true);
            }
        }

        private void cerrarMetodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";
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
            open.ifw(claz.numfunt);
        }

        private void sWITCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.switchw(claz.numfunt);
        }

        private void dOWHILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.do_whilew(claz.numfunt);
        }

        private void wHILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.whilew(claz.numfunt);

        }

        private void fORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.forw(claz.numfunt);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            open.printf(claz.numfunt);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            open.variable(claz.numfunt, 1);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.coment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abrirMetodoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            nameclass form = new nameclass();
            form.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        { }
    }
}
