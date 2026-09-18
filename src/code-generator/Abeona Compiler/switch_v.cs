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
    public partial class switch_v : Form
    {
        string[] last_do = new string[1500];
        string j;
        int k,n;
        public switch_v()
        {
            InitializeComponent();
            if (key.lengprog == 2)
            {
                fincierreDeProgramaToolStripMenuItem.Enabled = false;
                fincierreDeProgramaToolStripMenuItem.Text = "";
            }
            n = 0;
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
                        Box.Text = Box.Text + "system(" + (char)34 + "PAUSE" + (char)34 + ");";
                    }
                    break;
                case 2:
                    {
                        Box.Text = Box.Text + "Console.ReadKey(true);";
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
            Box.Text = Box.Text + "return 0;";
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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Box.Clear();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Box.Focus();
            Box.SelectAll();
            Box.Copy();
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
                Box.Text = last_do[k];
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
                Box.Text = last_do[k];
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
                Box.Text = Box.Text + "\r\n" + key.code;
                key.nums = key.nums + 1;
                last_do[key.nums] = Box.Text;
                key.code = "";
            }
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open.caset();
            n++;
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "\r\n" + "} break;";
            n--;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.svar();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "}";
            cerrarToolStripMenuItem.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {

                if (abrirToolStripMenuItem.Enabled == false && cerrarToolStripMenuItem.Enabled == false)
                {
                    key.code = Box.Text;
                    Close();
                }
                else
                {
                    open.window("Atencion", "El ''switch'' ha sido abierto, pero no ha sido cerrado, favor de revisar tu codigo", true);
                }
            }
            else
            {
                open.window("Atencion", "'" + n + "' de casos no han sido cerrados, por favor revisa tu codigo", true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Box.Clear();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            Box.Focus();
            Box.SelectAll();
            Box.Copy();
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
                Box.Text = last_do[k];
            }
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > key.nums)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                Box.Text = last_do[k];
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
                Box.Text = Box.Text + "\r\n" + key.code;
                key.nums = key.nums + 1;
                last_do[key.nums] = Box.Text;
                key.code = "";
                k = key.nums;
            }
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            write();
            if (Box.Text.Contains("switch"))
            {
                abrirToolStripMenuItem.Enabled = false;
            }
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            open.about();
        }
               
    }
}
