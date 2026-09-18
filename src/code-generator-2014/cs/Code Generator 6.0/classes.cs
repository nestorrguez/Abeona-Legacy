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
    public partial class classes : Form
    {

        int k, n;
        string[] change = new string[1500];
        public classes()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (abririfToolStripMenuItem.Enabled == false && cerrarifToolStripMenuItem.Enabled == false)
            {
                to.code = richTextBox1.Text;                
                claz.variables[claz.numclass, 0] = open.nameclass;
            }
            else
            {
                open.window("Atencion","Se ha abierto una ''clase'' per no se ha cerrado",true);
            }
            Close();
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
                if (richTextBox1.Text.Contains("class"))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abririfToolStripMenuItem.Enabled = true;
                }
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
                if (richTextBox1.Text.Contains("class"))
                    abririfToolStripMenuItem.Enabled = false;
                else
                    abririfToolStripMenuItem.Enabled = true;
            }

            if(richTextBox1.Text.Contains("class"))
            {
                abririfToolStripMenuItem.Enabled = false;
            }
            else
            {
                abririfToolStripMenuItem.Enabled = true;
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
                if (richTextBox1.Text.Contains("class"))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abririfToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void abririfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.q = 1;
            nameclass form = new nameclass();
            form.Show();
            if(richTextBox1.Text.Contains("class"))
            {
                abririfToolStripMenuItem.Enabled = false;
            }
            else
            {
                abririfToolStripMenuItem.Enabled = true;
            }
        }

        private void cerrarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";
            cerrarifToolStripMenuItem.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuevaVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.variable(claz.numclass, 2);
        }

        private void nuevoMetodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.q = 0;
            funt form = new funt();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nameclass form = new nameclass();
            form.Show();
            open.q = 1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\n}";
            toolStripMenuItem2.Enabled = false;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (to.code == "")
            {

                open.window("Advertencia", "No se a ingresado una accion", true);
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\r\n" + to.code;
                to.nm++;
                change[to.nm] = richTextBox1.Text;
                to.code = "";
                k = to.nm;               
                //organize();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            funt form = new funt();
            form.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            open.variable(claz.numclass++, 2);
        }

        private void copiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void seleccionarTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void generarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (to.code == "")
            {

                open.window("Advertencia", "No se a ingresado una accion", true);
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\r\n" + to.code;
                to.nm++;
                change[to.nm] = richTextBox1.Text;
                to.code = "";
                k = to.nm;
                //organize();
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            open.help(20);
        }
    }
}
