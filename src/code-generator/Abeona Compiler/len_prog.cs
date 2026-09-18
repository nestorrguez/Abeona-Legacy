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
    public partial class Form11 : Form
    {
        int len;
        string leng, save;
        public Form11()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            len = 1;
        }

        void saved()
        {
            using (System.IO.StreamWriter a = new System.IO.StreamWriter(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\lenguaje.txt"));
            System.IO.StreamWriter myStreamWriter = null;
            save = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\lenguaje.txt";
            myStreamWriter = System.IO.File.AppendText(save);
            myStreamWriter.Write(leng);
            myStreamWriter.Flush();
        }

        void call()
        {
            key.title = "Atencion";
            key.info = "Para que los cambios tengan efecto en el programa se necesita cerrar y abrirla de nuevo";
            key.does = false;
            open.error();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (len)
            {
                case 1:
                    {
                        leng = "1";
                    }
                    break;
                case 2:
                    {
                        leng = "2";
                    }
                    break;
            }
            saved();
            call();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            len = 2;
        }
    }
}
