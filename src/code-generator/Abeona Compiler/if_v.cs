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
    public partial class Form16 : Form
    {
        string[] last_do = new string[1500];
        string j;
        int k;
        public Form16()
        {
            InitializeComponent();
            if (key.lengprog == 2)
            {
                fincierreDeProgramaToolStripMenuItem.Enabled = false;
                fincierreDeProgramaToolStripMenuItem.Text = "";
            }          
           
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

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
                key.numi = key.numi + 1;
                last_do[key.numi] = Box.Text;
                key.code = "";
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key.title = "Condicion If";
            key.info = "if";
            key.cic = 3;
            open.condit();
            abrirToolStripMenuItem.Enabled = false;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "}";
            cerrarToolStripMenuItem.Enabled = false;
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "else" + "\r\n" + "{";
            abrirToolStripMenuItem1.Enabled = false;
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "}";
            cerrarToolStripMenuItem1.Enabled = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (abrirToolStripMenuItem.Enabled == false && cerrarToolStripMenuItem.Enabled == false)
            {

                if (abrirToolStripMenuItem1.Enabled == false && cerrarToolStripMenuItem1.Enabled == false)
                {
                    key.code = Box.Text;
                    Close();
                }
                else if (abrirToolStripMenuItem1.Enabled == true && cerrarToolStripMenuItem1.Enabled == true)
                {
                    key.code = Box.Text;
                    Close();
                }
                else
                {
                    open.window("Atencion", "Se ha abierto un ''else'' pero no has ido cerrado, favor de revisar su codigo", true);
                }
            }
            else
            {
                open.window("Atencion", "Se ha abierto un ''if'' pero no has ido cerrado, favor de revisar su codigo", true);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
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
            if (k > key.numi)
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
                key.numi = key.numi + 1;
                last_do[key.numi] = Box.Text;
                key.code = "";
                k = key.numi;
            }
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            write();
            if (Box.Text.Contains("if"))
            {
                abrirToolStripMenuItem.Enabled = false;
            }
            if (Box.Text.Contains("else"))
            {
                abrirToolStripMenuItem1.Enabled = false;
            }
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            open.about();
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
