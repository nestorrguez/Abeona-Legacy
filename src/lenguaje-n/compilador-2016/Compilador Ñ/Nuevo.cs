using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Compilador_Ñ
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:\Proyectos Ñ\"))
                Directory.CreateDirectory(@"C:\Proyectos Ñ\");
            textBox2.Text = @"C:\Proyectos Ñ\";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool asf=true;
            try
            {
                Directory.CreateDirectory(textBox2.Text + "\\" + textBox1.Text);
                Directory.CreateDirectory(textBox2.Text + "\\" + textBox1.Text + "\\exe");
                using (StreamWriter sw = new StreamWriter(textBox2.Text + "\\" + textBox1.Text + "\\" + textBox1.Text + ".ñ"))
                {
                    sw.Close();
                }                
            }
            catch (Exception)
            {
                asf = false;
                MessageBox.Show("Hubo un error durante el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (asf == true)
                {
                    MainWindow.IDEFolder = textBox2.Text + "\\" + textBox1.Text + "\\";
                    MainWindow.ProjectTitle = textBox1.Text;
                    MainWindow.lol = true;
                }
                this.Close();
            }
        }
    }
}
