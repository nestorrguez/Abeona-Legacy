using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form12 : Form
    {
        int lan;
        string lang,save;
        public Form12()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lan = 1;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (lan)
            {
                case 1:
                {
                    lang="1";
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

        void saved()
        {
            using (System.IO.StreamWriter a = new System.IO.StreamWriter(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\languaje.txt"));
            save = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\languaje.txt";
            System.IO.StreamWriter myStreamWriter = null;
            myStreamWriter = System.IO.File.AppendText(save);
            myStreamWriter.Write(lang);
            myStreamWriter.Flush();
        }

        void call()
        {
            key.title = "Atencion";
            key.info = "Para que los cambios tengan efecto en el programa se necesita cerrar y abrirla de nuevo";
            key.does = false;
            open.error();            
        }
    }

}
