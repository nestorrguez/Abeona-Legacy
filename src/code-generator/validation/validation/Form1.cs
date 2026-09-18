using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace validation
{    
    public partial class Form1 : Form
    {
        int c,lan,len;
        string e,f,g;
        bool w,x,y,z;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            test.Text = "SS13-ABTL-CDGT-TRY1-FAKE";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c = textBox1.Text.Length;
            if (c == 4)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            c = textBox2.Text.Length;
            if (c == 4)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c = textBox3.Text.Length;
            if (c == 4)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            c = textBox4.Text.Length;
            if (c == 4)
            {
                textBox5.Focus();
            }
        }       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            c = textBox5.Text.Length;
            if (c == 4)
            {
                x = true;
                validate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lan = 1;
            z = true;
            validate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            len = 1;
            w = true;
            validate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text + "-" + textBox5.Text ;
            if (test.Text == f)
            {
                make();               
                Form2 form = new Form2();
                form.Show();
                write();
            }
            else
            {
                Form3 form = new Form3();
                form.Show();
                InitializeComponent();
            }
           
        }

        void make()
        {
            using (System.IO.StreamWriter a = new System.IO.StreamWriter(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\languaje.txt")) { }

            using (System.IO.StreamWriter b = new System.IO.StreamWriter(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\lenguaje.txt")) { }

            using (System.IO.StreamWriter c = new System.IO.StreamWriter(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\name.txt")) { }

            using (System.IO.StreamWriter d = new System.IO.StreamWriter(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\licence.txt")) { }            
        }

        void lang()
        {
            //Idioma
            string save;
            save = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\language.txt";
            System.IO.StreamWriter myStreamWriter = null;
            myStreamWriter = System.IO.File.AppendText(save);
            myStreamWriter.Write(lan);
            myStreamWriter.Flush();         
        }

        void leng()
        {
            //Lenguaje De Programacion
            string save;
            save = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\lengprog.txt";
            System.IO.StreamWriter myStreamWriter = null;
            myStreamWriter = System.IO.File.AppendText(save);
            myStreamWriter.Write(len);
            myStreamWriter.Flush();
        }

        void name()
        {
            //Lenguaje De Programacion
            string save;
            save = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\name.txt";
            System.IO.StreamWriter myStreamWriter = null;
            myStreamWriter = System.IO.File.AppendText(save);
            string n = textBox6.Text;
            myStreamWriter.Write(n);
            myStreamWriter.Flush();
        }

        void licence()
        {
            //Lenguaje De Programacion
            string save;
            save = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\licence.txt";
            System.IO.StreamWriter myStreamWriter = null;
            myStreamWriter = System.IO.File.AppendText(save);            
            myStreamWriter.Write("1");
            myStreamWriter.Flush();
        }

        void write()
        {
            licence();
            lang();
            leng();
            name();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                y = true;
            }
            validate();
        }

        void validate()
        {
            if (w == true && x == true && y == true && z == true)
            {
                button2.Enabled = true;
            }
        }

        void look()
        {
            if (Directory.Exists(@"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101")) { }
            else
            {
                if (Directory.Exists(@"C:\Archivos de programa")) { }
                else
                {
                    string l1 = @"C:\";
                    string l2 = System.IO.Path.Combine(l1, "Archivos de programa");
                }
                string a;
                a = @"C:\Archivos de programa";
                string b = System.IO.Path.Combine(a, "Win86x");
                System.IO.Directory.CreateDirectory(b);
                string c;
                c = @"C:\Archivos de programa\Win86x";
                string d = System.IO.Path.Combine(c, "01000001 01000010 01010100 01001100");
                System.IO.Directory.CreateDirectory(d);
                string h;
                h = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100";
                string i = System.IO.Path.Combine(h, "01000011 01000100 01000111 01010100");
                System.IO.Directory.CreateDirectory(i);
                string j;
                j = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100";
                string k = System.IO.Path.Combine(j, "01010100 01010010 01010101 01000101");
                System.IO.Directory.CreateDirectory(k);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            len = 2;
            w = true;
            validate();
        }
    }
}
