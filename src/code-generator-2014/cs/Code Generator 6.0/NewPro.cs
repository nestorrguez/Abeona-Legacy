using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CodeGenCS
{  
    public partial class NewPro : Form
    {
        public static bool yes;
        public NewPro()
        {
            yes = false;
            InitializeComponent();
            textBox2.Text = @"C:\Users\" + SystemInformation.UserName + @"\Documents\Mis Codigos\";                  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = @"C:\Users\" + SystemInformation.UserName + @"\Documents\Mis Codigos\" + textBox1.Text;
            textBox3.Text = @"Code Generator hara un proyecto para C# y lo guardara en: C:\Users\" + SystemInformation.UserName + @"\Documents\Mis Codigos\" + textBox1.Text + "\r\nPara ver el codigo y el ejecutable: " + @"C:\Users\" + SystemInformation.UserName + @"\Documents\Mis Codigos\" + textBox1.Text + @"\CS"  ;
            if (textBox1.Text == "")
                textBox4.Text = "No se puede dejar el cuadro de nombre vacio";
            else
                textBox4.Text = "";

            if (System.IO.File.Exists(@"C:\Users\" + SystemInformation.UserName + @"\Documents\Mis Codigos\" + textBox1.Text))
                textBox4.Text = "Ya existe un proyecto con este nombre: " + textBox1.Text;
            else
                textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(textBox2.Text);
            System.IO.Directory.CreateDirectory(textBox2.Text + @"\Data");
            System.IO.Directory.CreateDirectory(textBox2.Text + @"\Propierties");
            System.IO.Directory.CreateDirectory(textBox2.Text + @"\CS");
            System.IO.File.Create(textBox2.Text + @"\Data\" + textBox1.Text + ".cgc");
            System.IO.File.Create(textBox2.Text + @"\Data\" + textBox1.Text + "_vars.cgv");
            System.IO.File.Create(textBox2.Text + @"\Data\" + textBox1.Text + "_class.cgv");
            using (StreamWriter wr = new StreamWriter(textBox2.Text + @"\" + textBox1.Text + ".cgp", true))
            {
                wr.WriteLine(textBox1.Text); 
            }
            yes = true;
            Proyect.name = textBox1.Text;
            Proyect.code = textBox2.Text + @"\Data\" + textBox1.Text + ".cgc";
            Proyect.vars = textBox2.Text + @"\Data\" + textBox1.Text + "_vars.cgv";
            Proyect.clas = textBox2.Text + @"\Data\" + textBox1.Text + "_class.cgv";
            Proyect.expt = textBox2.Text + @"\CS\";
            Close();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewPro_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
