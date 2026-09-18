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
    public partial class wizzard : Form
    {
        int n;
        public wizzard()
        {
            InitializeComponent();
            n = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            n--;
            if (n < 1)
            {
                open.window("Atencion", "No hay mas consejos", true);
            }
            else
            {
                organize();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 10)
            {
                open.window("Atencion", "No hay mas consejos", true);
            }
            else
            {
                organize();
            }
        }

        void organize()
        {
            switch (n)
            {
                  case 1:
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\ABTL-Resources\CDGT\help images\1.bmp");
                        textBox1.Text = "Si es tu primera vez en este programa, te daremos una serie de tips que te ayudaran a entender y utilizar el programa.\r\n\r\nTe recordamos que este programa se dedica a la generacion de codigo en un lenguaje de programacion, no hace las tareas de un compilador, para utilizar el codigo hecho en un compilador, guarda el codigo como Codigo Fuente";
                    }
                    break;

                case 2:
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\ABTL-Resources\CDGT\help images\1.bmp");
                        textBox1.Text = "Antes de empezar a utilizar el programa, debes de reconocer la interfaz";
                    }
                    break;
                case 3:
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\ABTL-Resources\CDGT\help images\2.bmp");
                        textBox1.Text = "La parte encerrada en rojo, es la barra de menús, donde encontraras herramientas relacionadas al nombre que tienen";
                    }
                    break;
                case 4:
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\ABTL-Resources\CDGT\help images\3.bmp");
                        textBox1.Text = "La parte encerrada en rojo, es la barra de herramientas, donde encontraras las herramientas basicas o mas usadas en este programa";
                    }
                    break;
                case 5:
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\ABTL-Resources\CDGT\help images\4.bmp");
                        textBox1.Text = "Aqui encontraras las tareas mas basicas para programar, exploraremos cada una de ellas..";
                    }
                    break;
                case 6:
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\ABTL-Resources\CDGT\help images\5.bmp");
                        textBox1.Text = "Hemos precionado el boton ";
                    }
                    break;
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
