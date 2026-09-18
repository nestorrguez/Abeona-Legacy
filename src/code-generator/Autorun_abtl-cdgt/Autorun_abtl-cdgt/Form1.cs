using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autorun_abtl_cdgt
{
    public partial class Form1 : Form
    {
        string path,n;
        bool installed,used;
        public Form1()
        {
            InitializeComponent();
            validate();
            path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string txtdireccion = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\licence.txt";
            System.IO.StreamReader sr = new System.IO.StreamReader(@txtdireccion, System.Text.Encoding.Default);
            n = sr.ReadToEnd();
            sr.Close();
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            validate();            
            if (File.Exists(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\instaled.txt"))
            {
                button2.Enabled = false;
                validate();
            }
            else
            {
                System.Diagnostics.Process.Start(path + "\\resources\\cdgt-setup.exe");
                validate();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (n == "1")
            {
                validate();
                System.Diagnostics.Process.Start(path + "\\resources\\validation.exe");
            }
            else
            {
                button3.Enabled = false;
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void validate()
        {            
            if (File.Exists(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\instaled.txt"))
            {                
                button2.Text = "";
                button2.Enabled = false;
            }

            if (n == "1")
            {
                button3.Text = "Abrir\r\nCode Generator";               
            }
        }

        void comprobation()
        {        

            if (File.Exists(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\instaled.txt"))
            {
                installed = true;
            }
        }
        
    }
}
