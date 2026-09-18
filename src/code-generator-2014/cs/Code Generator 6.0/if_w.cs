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
    public partial class if_w : Form
    {
        int k,n;
        string[] change = new string[1500];
        public if_w()
        {
            InitializeComponent();                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (abririfToolStripMenuItem.Enabled == false && cerrarifToolStripMenuItem.Enabled == false)
            {
                if (abrirToolStripMenuItem.Enabled == true && cerrarToolStripMenuItem.Enabled == true || abrirToolStripMenuItem.Enabled == false && cerrarToolStripMenuItem.Enabled == false)
                {
                    to.code = richTextBox1.Text;
                    Close();
                }
                else
                {
                    open.window("Atencion","Se ha abierto un ''else'' pero no se ha cerrado",true);
                }
            }
            else 
            {
                open.window("Atencion","Se ha abierto un ''if'', pero nunca se cerro, verifica tu codigo",true);
            }
        }

        private void abririfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("if("))
            {
                abririfToolStripMenuItem.Enabled = false;
            }
            else
            {
                open.constant("if");
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("if("))
            {
                abririfToolStripMenuItem.Enabled = false;
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

        private void cerrarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1 + "\r\n}";
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
                if (richTextBox1.Text.Contains("if("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarifToolStripMenuItem.Enabled = true;
                }

                if (richTextBox1.Text.Contains("else"))
                {
                    abrirToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarToolStripMenuItem.Enabled = true;
                }
            }
            
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
                if (richTextBox1.Text.Contains("if("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarifToolStripMenuItem.Enabled = true;
                }

                if (richTextBox1.Text.Contains("else"))
                {
                    abrirToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarToolStripMenuItem.Enabled = true;
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
                if (richTextBox1.Text.Contains("if("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarifToolStripMenuItem.Enabled = true;
                }

                if (richTextBox1.Text.Contains("else"))
                {
                    abrirToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarToolStripMenuItem.Enabled = true;
                }
            }   
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("else"))
            {
                abrirToolStripMenuItem.Enabled = false; 
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\r\nelse\r\n{";
                abrirToolStripMenuItem.Enabled = false;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";
            cerrarToolStripMenuItem.Enabled = false;
        }

        private void abririfToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("if("))
            {
                abririfToolStripMenuItem.Enabled = false;
            }
            else
            {
                open.constant("if");
            }
        }

        private void cerrarifToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";
            cerrarifToolStripMenuItem.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
                n++;
                change[n] = richTextBox1.Text;
                to.code = "";
                k = n;
                if (richTextBox1.Text.Contains("if("))
                {
                    abririfToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarifToolStripMenuItem.Enabled = true;
                }

                if (richTextBox1.Text.Contains("else"))
                {
                    abrirToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cerrarToolStripMenuItem.Enabled = true;
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

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            open.help(9);
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
