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
    public partial class for_w : Form
    {
        int n,k;
        string[] change = new string[1500];
        public for_w()
        {
            InitializeComponent();
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
                if (richTextBox1.Text.Contains("for("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abririfToolStripMenuItem.Enabled = true;
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
                if (richTextBox1.Text.Contains("for("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abririfToolStripMenuItem.Enabled = true;
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
                //richTextBox1.Text = change[k];
                if (richTextBox1.Text.Contains("for("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abririfToolStripMenuItem.Enabled = true;
                }
            }   
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            open.comand();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            open.help(14);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            open.printf(open.nv);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            open.variable(open.nv, 1);
        }

        private void abririfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("for("))
            {
                abririfToolStripMenuItem.Enabled = false;
            }
            else
            {
                for_c form = new for_c();
                form.Show();
            }
        }

        private void cerrarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\n}";
            cerrarifToolStripMenuItem.Enabled = false;
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.color();
        }

        private void retrasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.delayt();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1: richTextBox1.Text = richTextBox1.Text + "system(" + (char)34 + "PAUSE" + (char)34 + ");"; break;
                case 2: richTextBox1.Text = richTextBox1.Text + "Console.ReadKey(true);"; break;
            }
    
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
            open.forw(open.a);
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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.coment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (abririfToolStripMenuItem.Enabled == false && cerrarifToolStripMenuItem.Enabled == false)
            {
                to.code = richTextBox1.Text;
                Close();
            }
            else
            {
                open.window("Atencion", "Se ha abierto un ''for'' pero no ha sido cerrado", true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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
                n++;
                change[n] = richTextBox1.Text;
                to.code = "";
                k = n;
                if (richTextBox1.Text.Contains("for("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    abririfToolStripMenuItem.Enabled = true;
                }
            }
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

        private void llamarUnMetodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objets form = new objets();
            form.Show();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Console.Clear();";
        }
    }
}
