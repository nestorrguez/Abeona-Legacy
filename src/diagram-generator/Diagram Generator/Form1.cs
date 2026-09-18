using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagram_Generator
{
    public partial class Form1 : Form
    {       
        int s, x, y;
        static string w = System.IO.Directory.GetCurrentDirectory() + @"\res\";
        string z = w;
        string e = @"C:\Archivos de programa\Selene Software\Abeona Tools\Diagram Generator\";
        public Form1()
        {
            InitializeComponent();   
            s = 0;
            x = 382;
            y = 5;            
        }

        void rush()
        {
            s++;
            var imgPictureBox = new PictureBox();
            imgPictureBox.Location = new System.Drawing.Point(x, y);
            imgPictureBox.Size = new System.Drawing.Size(20, 20);
            imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox.Image = Image.FromFile(z + "rush.png");
            panel1.Controls.Add(imgPictureBox);
            imgPictureBox.Name = "shape" + s;
            imgPictureBox.Visible = true;
            imgPictureBox.BringToFront();
            y += 25;            
        }

        private void abrirProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            s++;
            var imgPictureBox = new PictureBox();
            imgPictureBox.Location = new System.Drawing.Point(x-(140/2), y);
            imgPictureBox.Size = new System.Drawing.Size(140, 30);
            imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox.Image = Image.FromFile(z + "body.png");
            panel1.Controls.Add(imgPictureBox);
            imgPictureBox.TabIndex = 13;
            imgPictureBox.Name = "shape" + s;
            imgPictureBox.Visible = true;
            imgPictureBox.BringToFront();
            s++;
            //textbox
            var textBox1 = new System.Windows.Forms.TextBox();
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            textBox1.ForeColor = System.Drawing.Color.Black;
            textBox1.Location = new System.Drawing.Point(x - (140 / 2) + 10, y + 10);
            textBox1.Name = "shape" + s;
            textBox1.Size = new System.Drawing.Size(120, 13);
            textBox1.TabIndex = 14;
            textBox1.Text = "Inicio";
            textBox1.ReadOnly = true;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            panel1.Controls.Add(textBox1);
            y += 35;
            textBox1.BringToFront();
            rush(); 
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            s++;
            var imgPictureBox = new PictureBox();
            imgPictureBox.Location = new System.Drawing.Point(x-(140/2), y);
            imgPictureBox.Size = new System.Drawing.Size(140, 30);
            imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox.Image = Image.FromFile(z + "body.png");
            panel1.Controls.Add(imgPictureBox);
            imgPictureBox.TabIndex = 13;
            imgPictureBox.Name = "shape" + s;
            imgPictureBox.Visible = true;
            imgPictureBox.BringToFront();
            //textbox
            s++;
            var textBox1 = new System.Windows.Forms.TextBox();
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            textBox1.ForeColor = System.Drawing.Color.Black;
            textBox1.Location = new System.Drawing.Point(x - (140 / 2) +10, y + 10);
            textBox1.Name = "shape" + s;
            textBox1.Size = new System.Drawing.Size(120, 13);
            textBox1.TabIndex = 14;
            textBox1.Text = "Fin";
            textBox1.ReadOnly = true;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            panel1.Controls.Add(textBox1);
            y += 35;
            textBox1.BringToFront();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.write("Imprimir Texto", "Escribe el texto que deseas imprimir: ", true);
            open.code = 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {           
            switch (open.code)
            {
                case 1:
                    s++;
                    var imgPictureBox = new PictureBox();
                    imgPictureBox.Location = new System.Drawing.Point(x - (130 / 2), y);
                    imgPictureBox.Size = new System.Drawing.Size(130, 80);
                    imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgPictureBox.Image = Image.FromFile(z + "out.png");
                    panel1.Controls.Add(imgPictureBox);
                    imgPictureBox.TabIndex = 13;
                    imgPictureBox.Visible = true;
                    imgPictureBox.Name = "shape" + s;
                    imgPictureBox.BringToFront();
                    //textbox
                    s++;
                    var textBox1 = new System.Windows.Forms.TextBox();
                    textBox1.BackColor = System.Drawing.Color.White;
                    textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
                    textBox1.ForeColor = System.Drawing.Color.Black;
                    textBox1.Location = new System.Drawing.Point(x - (130 / 2) + 10, y + 10);
                    textBox1.Name = "shape" + s;
                    textBox1.Size = new System.Drawing.Size(110, 50);
                    textBox1.TabIndex = 14;
                    textBox1.Text = open.messenger;
                    textBox1.ReadOnly = true;
                    textBox1.Multiline = true;
                    textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    panel1.Controls.Add(textBox1);
                    y += 85;
                    textBox1.BringToFront();
                    rush();
                    break;
                case 2:
                    s++;
                    var imgPictureBox1 = new PictureBox();
                    imgPictureBox1.Location = new System.Drawing.Point(x - (130 / 2), y);
                    imgPictureBox1.Size = new System.Drawing.Size(130, 30);
                    imgPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgPictureBox1.Image = Image.FromFile(z + "in.png");
                    panel1.Controls.Add(imgPictureBox1);
                    imgPictureBox1.TabIndex = 13;
                    imgPictureBox1.Visible = true;
                    imgPictureBox1.Name = "shape" + s;
                    imgPictureBox1.BringToFront();
                    //textbox
                    s++;
                    var textBox11 = new System.Windows.Forms.TextBox();
                    textBox11.BackColor = System.Drawing.Color.White;
                    textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    textBox11.Cursor = System.Windows.Forms.Cursors.Arrow;
                    textBox11.ForeColor = System.Drawing.Color.Black;
                    textBox11.Location = new System.Drawing.Point(x - (130 / 2) + 10, y + 10);
                    textBox11.Name = "shape" + s;
                    textBox11.Size = new System.Drawing.Size(110, 13);
                    textBox11.TabIndex = 14;
                    textBox11.Text = open.messenger;
                    textBox11.ReadOnly = true;
                    textBox11.Multiline = false;
                    textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    panel1.Controls.Add(textBox11);
                    y += 35;
                    textBox11.BringToFront();
                    rush();
                    break;
                case 3:
                    var imgPictureBox11 = new PictureBox();
                    imgPictureBox11.Location = new System.Drawing.Point(x - (130 / 2), y);
                    imgPictureBox11.Size = new System.Drawing.Size(130, 30);
                    imgPictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgPictureBox11.Image = Image.FromFile(z + "value.png");
                    panel1.Controls.Add(imgPictureBox11);
                    imgPictureBox11.TabIndex = 13;
                    imgPictureBox11.Name = "shape" + s;
                    imgPictureBox11.Visible = true;
                    imgPictureBox11.BringToFront();
                    //textbox
                    s++;
                    var textBox111 = new System.Windows.Forms.TextBox();
                    textBox111.BackColor = System.Drawing.Color.White;
                    textBox111.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    textBox111.Cursor = System.Windows.Forms.Cursors.Arrow;
                    textBox111.ForeColor = System.Drawing.Color.Black;
                    textBox111.Location = new System.Drawing.Point(x - (130 / 2) + 10, y + 10);
                    textBox111.Name = "shape" + s;
                    textBox111.Size = new System.Drawing.Size(110, 13);
                    textBox111.TabIndex = 14;
                    textBox111.Text = open.messenger;
                    textBox111.ReadOnly = true;
                    textBox111.Multiline = false;
                    textBox111.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    panel1.Controls.Add(textBox111);
                    y += 35;
                    textBox111.BringToFront();
                    rush();
                    break;
            }
            open.code = 0;
           
        }

        private void pedirVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.write("Pedir Variable","Escribe el nombre de la variable a pedir:",false);
            open.code = 2;
        }

        private void declararConstanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.write("Declarar Valor", "Escribe el nombre de la variable y el valor que esta tomara: ", false);
            open.code = 3;
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s++;
            var imgPictureBox11 = new PictureBox();
            imgPictureBox11.Location = new System.Drawing.Point(x, y);
            imgPictureBox11.Size = new System.Drawing.Size(20, 20);
            imgPictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox11.Image = Image.FromFile(z + "ball_black.png");
            panel1.Controls.Add(imgPictureBox11);
            imgPictureBox11.TabIndex = 13;
            imgPictureBox11.Name = "shape" + s;
            imgPictureBox11.Visible = true;
            imgPictureBox11.BringToFront();
            y += 25;
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }   
}
