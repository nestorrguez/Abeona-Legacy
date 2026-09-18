using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagramGen
{
    public partial class Form1 : Form
    {
        object obj,sent;
        int s,f,px,py,X,Y,txtX,txtY;
        string typeS,Code="";
        string[,] simbol = new string[4000,2];
        bool multi;

        Point mousePos;
        Size txtSize;
        PictureBox p;
        HorizontalAlignment h;

        bool draw;
        Pen Lapiz = new Pen(Color.Black, 2);
        Boolean Dibujar = false;
        Graphics Graph;
        Rectangle Rectangulo = new Rectangle();
        public Form1()
        {
            draw = false;
            InitializeComponent();
            s = 0;
            f = 0;
            X = (panel2.Size.Width / 2);
            toolStripComboBox1.Text = "inicio";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            draw = false;            
            typeS = Type.Startend;
            toolStripTextBox1.Visible = false;
            toolStripComboBox1.Visible = true;
            menuStrip1.Visible = true;
            p = pictureBox1;
            txtSize = new Size(100,20);
            h = HorizontalAlignment.Center;
            multi= false;
            txtX = 25;
            txtY = 17;
        }

        public void addControl(string a)
        {
            s++;
            PictureBox pic;
            TextBox text;
            var imgPictureBox = new PictureBox();
            imgPictureBox.Location = new System.Drawing.Point(X, Y);
            imgPictureBox.Size = p.Size;
            imgPictureBox.SizeMode = p.SizeMode;
            imgPictureBox.Image = p.Image;
            this.panel2.Controls.Add(imgPictureBox);
            imgPictureBox.Visible = true;
            imgPictureBox.Name = "shape" + s;
            imgPictureBox.BringToFront();
            imgPictureBox.Cursor = Cursors.SizeAll;
            imgPictureBox.ContextMenuStrip = contextMenuStrip1;
            pic = imgPictureBox;
            imgPictureBox.MouseDown += new MouseEventHandler(Something_MouseDown);
            imgPictureBox.MouseMove += new MouseEventHandler(Something_MouseMove);            
            var txtTextBox = new TextBox();
            txtTextBox.Location = new Point(txtX, txtY);
            txtTextBox.TextAlign = h;
            txtTextBox.Size = txtSize;
            txtTextBox.Name = "txt" + s;
            txtTextBox.Text = a;
            txtTextBox.BorderStyle = BorderStyle.None;
            txtTextBox.Multiline = multi;
            imgPictureBox.Controls.Add(txtTextBox);
            txtTextBox.BringToFront();
            toolStripTextBox1.Clear();
            Code += s + "Ø" + typeS + "Ø" + a + "Ø" + pic.Location.X + "Ø" + pic.Location.Y + "Ø" + pic.Size.Width + "Ø" + pic.Size.Height + "Ħ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            draw = false;
            typeS = Type.Out;
            toolStripTextBox1.Visible = true;
            toolStripComboBox1.Visible = false;            
            toolStripTextBox1.Size = new Size(200, 23);
            menuStrip1.Visible = true;
            p = pictureBox2;
            txtSize = new Size(140, 70);
            h = HorizontalAlignment.Left;
            multi = true;
            txtX = 5;
            txtY = 7;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            draw = false;
            typeS = Type.Square;
            toolStripTextBox1.Visible = true;
            toolStripComboBox1.Visible = false;
            toolStripTextBox1.Size = new Size(75, 23);
            menuStrip1.Visible = true;
            p = pictureBox3;
            txtSize = new Size(100, 20);
            h = HorizontalAlignment.Center;
            multi = false;
            txtX = 25;
            txtY = 17;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            draw = false;
            typeS = Type.In;
            toolStripTextBox1.Visible = true;
            toolStripComboBox1.Visible = false;
            toolStripTextBox1.Size = new Size(50, 23);
            menuStrip1.Visible = true;
            p = pictureBox4;
            txtSize = new Size(100, 20);
            h = HorizontalAlignment.Center;
            multi = false;
            txtX = 25;
            txtY = 17;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            draw = false;
            typeS = Type.Condition;
            toolStripTextBox1.Visible = true;
            toolStripComboBox1.Visible = false;
            toolStripTextBox1.Size = new Size(50, 23);
            menuStrip1.Visible = true;
            p = pictureBox5;
            txtSize = new Size(100, 20);
            h = HorizontalAlignment.Center;
            multi = false;
            txtX = 25;
            txtY = 65;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            draw = false;
            typeS = Type.For;
            toolStripTextBox1.Visible = true;
            toolStripComboBox1.Visible = false;
            toolStripTextBox1.Size = new Size(75, 23);
            menuStrip1.Visible = true;
            p = pictureBox6;
            //Aa
        }

        private void Something_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
            sent = sender;
        }

        private void Something_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;            
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                picture.Location = new Point(picture.Left + dx, picture.Top + dy);
            }
        }      

        private void listoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Visible)            
                addControl(toolStripTextBox1.Text);
            else
                addControl(toolStripComboBox1.Text);
            menuStrip1.Visible = false;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control b = sent as Control;
            panel2.Controls.Remove(b);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && draw == true)
            {
                Rectangulo.X = e.Location.X;
                Rectangulo.Y = e.Location.Y;
                Rectangulo.Width = 0;
                Rectangulo.Height = 0;
                Dibujar = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            draw = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            int dx = e.X - mousePos.X;
            int dy = e.Y - mousePos.Y;
            if ((Dibujar == true) && (e.Button == MouseButtons.Left) && draw == true)
            {
                ControlPaint.DrawReversibleFrame(panel2.RectangleToScreen(Rectangulo), Lapiz.Color, FrameStyle.Dashed);
                Rectangulo.Width = e.X - Rectangulo.X;
                Rectangulo.Height = e.Y - Rectangulo.Y;
                ControlPaint.DrawReversibleFrame(this.RectangleToScreen(Rectangulo), Lapiz.Color, FrameStyle.Dashed);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if ((Dibujar == true) && (e.Button == MouseButtons.Left) && draw == true)
            {
                ControlPaint.DrawReversibleFrame(this.RectangleToScreen(Rectangulo), Lapiz.Color, FrameStyle.Dashed);
                Dibujar = false;
                Graph = panel2.CreateGraphics();
                Graph.DrawLine(Lapiz, Rectangulo.X, Rectangulo.Y, Rectangulo.X + Rectangulo.Width, Rectangulo.Y + Rectangulo.Height);
            }
        }    
    }
}
