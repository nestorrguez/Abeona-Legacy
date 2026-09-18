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
    public partial class Form14 : Form
    {
        string[] last_do = new string[1500];
        string j;
        int k ;
        bool a, b;
        public Form14()
        {
            InitializeComponent();
            Box.Text = Box.Text + "do{";
            if (key.lengprog == 2)
            {
                fincierreDeProgramaToolStripMenuItem.Text = "";
                fincierreDeProgramaToolStripMenuItem.Enabled = false;
            }
        }

        private void abrirCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "do{";
            a = true;
            abrirCicloToolStripMenuItem.Enabled = false;
        }

        private void cerrarCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key.title = "Condicion Do-While";
            key.info = "do-while";
            key.cic = 2;
            open.condit();
            b = true;
            cerrarCicloToolStripMenuItem.Enabled = false;
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
                key.numd = key.numd + 1;
                last_do[key.numd] = Box.Text;
                key.code = "";
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cerrarCicloToolStripMenuItem.Enabled == false && abrirCicloToolStripMenuItem.Enabled==false)
            {
                key.code = Box.Text;
                Close();
            }
            else
            {
                open.window("Atencion", "La sintaxis del ''do-while'' es incorrecta o no se a iniciado o finalizado correctamente, favor de revisar su codigo", true);
            }
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
            if (k > key.numd)
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

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            write();
            if (Box.Text.Contains("do{"))
            {
                abrirCicloToolStripMenuItem.Enabled = false;
            }

            if (Box.Text.Contains("}while"))
            {
                cerrarCicloToolStripMenuItem.Enabled = false;
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
                key.numd = key.numd + 1;
                last_do[key.numd] = Box.Text;
                key.code = "";
                k = key.numd;
            }
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            open.about(); 
        }
       
    }
}
