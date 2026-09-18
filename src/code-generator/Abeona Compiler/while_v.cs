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
    public partial class Form13 : Form
    {
        string[] last_do = new string[1500];
        int k ;
        bool a;
        public Form13()
        {
            InitializeComponent();            
            if (key.lengprog == 2)
            {
                fincierreDeProgramaToolStripMenuItem.Enabled = false;
                fincierreDeProgramaToolStripMenuItem.Text = "";
            }            
        }
        

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            box.Clear();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            box.Focus();
            box.SelectAll();
            box.Copy();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            k = k - 1;
            if (k <= 0)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                box.Text = last_do[k];
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > key.num)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                box.Text = last_do[k];
            }          
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (key.code == "")
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {                
                box.Text = box.Text + "\r\n" + key.code;
                key.numw = key.numw + 1;
                last_do[key.numw] = box.Text;
                key.code = "";
                
            }
        }

        private void abrirCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key.title = "Condicion While";
            key.info  = "while";
            key.cic = 1;
            open.condit();
        }

        private void cerrarCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box.Text = box.Text + "}";
            a = true;
            abrirCicloToolStripMenuItem.Enabled = false;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.color();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (key.lengprog)
            {
                case 1:
                    {
                        box.Text = box.Text + "system(" + (char)34 + "PAUSE" + (char)34 + ");";
                    }
                break;
                case 2:
                {
                    box.Text = box.Text + "Console.ReadKey(true);";
                }
                break;
            }
            
        }

        private void tiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.time();
        }

        private void fincierreDeProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box.Text = box.Text + "return 0;";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            open.comentary();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            open.printxt();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            open.variable();
        }

        private void iFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.ifv();
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.switchv();
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.whilev();
        }

        private void dowhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.dowhile();
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.forv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (abrirCicloToolStripMenuItem.Enabled = false && a == true)
            {
                key.code = box.Text;
                Close();
            }
            else
            {
                open.window("Atencion", "Se ha abierto un ''while'', pero no ha sido cerrado, favor de revisar su codigo", true);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            box.Clear();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            box.Focus();
            box.SelectAll();
            box.Copy();
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            k = k - 1;
            if (k < 0)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                box.Text = last_do[k];
            }
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > key.numw)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                box.Text = last_do[k];
            }            
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            write();

            if (box.Text.Contains("while"))
            {
                abrirCicloToolStripMenuItem.Enabled = false;
            }
            else
            {
                abrirCicloToolStripMenuItem.Enabled = true;
            }
        }

        void write()
        {
            if (key.code == "")
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                box.Text = box.Text + "\r\n" + key.code;
                key.numw = key.numw + 1;
                last_do[key.numw] = box.Text;
                key.code = "";
                k = key.numw;
            }
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            open.about(); 
        }

    }
}
