using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace CodeGenCPP
{
    public partial class Form1 : Form
    {
        public string a,b;
        int n,k;
        string f, g;
        string[] change = new string[1500];
        public Form1()
        {
            read();
            open.lib = true;            
            open.main = true;
            open.close = true;
            open.namezpace = true;
            InitializeComponent();
            organize();
            switch (to.lenprog)
            {
                case 1: f = " C++"; break;
                case 2: f = " C#"; break;
            }
            switch (to.language)
            {
                case 1: g = " Español"; break;
                case 2: g = " English"; break;
            }
            tl1.Text = "Lenguaje de Programacion: " + f;
            tl2.Text = "Idioma: " + g;
            tl3.Text = "Lineas de Codigo: " + richTextBox1.Lines.Length.ToString();           
            b = "";
            to.nm=0;
            open.lib = true;
            open.main = true;
            open.namezpace = true;
        }

        void read()
        {           
            to.lenprog = 1;         
            to.language = 1;           
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open.variable(0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            open.prefuntion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.boty();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open.coment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            open.printf(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            est form = new est();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cic form = new cic();
            form.Show();
        }       

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(richTextBox1.Text);
                documentToPrint.Print();
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
            }
        }

        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(richTextBox1.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.richTextBox1.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            objets form = new objets();
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    richTextBox1.Text = "//Tu Codigo en C++" + "\r\n" + "//Librerias" + "\r\n" + "#include <iostream>" + "\r\n" + "#include <cstdlib>" + "\r\n" + "#include <windows.h>" + "\r\n" + "using namespace std;";
                    break;
                case 2:
                    richTextBox1.Text = "//Tu Codigo en C#" + "\r\n" + "//Librerias" + "\r\n" + "using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Linq;" + "\r\n" + "using System.Text;" + "\r\n" + "using System.Threading;" + "\r\n" + "namespace cs_program;" + "\r\n" + "{" + "\r\n" + "class Program" + "\r\n" + "{" + "\r\n" + "static void Main(string[] args)" + "\r\n{";
                    break;
            }
            change[0] = richTextBox1.Text;
        }
       
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == "")
            {
                save();
            }
            else
            {               
                System.IO.StreamWriter myStreamWriter = null;
                myStreamWriter = System.IO.File.AppendText(b);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        void save()
        {
            //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
            switch (to.lenprog)
            {
                case 1:
                    {
                        Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cpp*)|*.cpp|Todos los archivos(*.*)|*.*";
                    } break;

                case 2:
                    {
                        Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cs*)|*.cs|Todos los archivos(*.*)|*.*";
                    } break;

            }
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                //este codigo se utiliza para guardar el archivo de nuestro editor
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
                b = Save.FileName;
            }
            catch (Exception) { }
            this.Text = "Code Generator [" + b + "]";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (b == "")
            {
                save();
            }
            else
            {
                System.IO.StreamWriter myStreamWriter = null;
                myStreamWriter = System.IO.File.AppendText(b);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    richTextBox1.Text = "//Tu Codigo en C++" + "\r\n" + "//Librerias" + "\r\n" + "#include <iostream>" + "\r\n" + "#include <cstdlib>" + "\r\n" + "#include <windows.h>" + "\r\n" + "using namespace std;";
                    break;
                case 2:
                    richTextBox1.Text = "//Tu Codigo en C#" + "\r\n" + "//Librerias" + "\r\n" + "using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Linq;" + "\r\n" + "using System.Text;" + "\r\n" + "using System.Threading;" + "\r\n" + "namespace cs_program;" + "\r\n" + "{";
                    break;
            }
            change[0] = richTextBox1.Text;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (to.code == "")
            {

                open.window("Advertencia", "No se a ingresado una accion", true);
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "\r\n" + to.code;
                to.nm++;
                change[to.nm] = richTextBox1.Text;
                to.code = "";
                k = to.nm;                
                tl3.Text = "";
                tl3.Text = "Lineas de Codigo: " + richTextBox1.Lines.Length.ToString();
                organize();
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se crea un objeto de tipo colordialog que servira para cabiar color del rich textbox
            ColorDialog fondo = new ColorDialog();
            //se hace la condicion para cambiar el tipo de color del rich textbox al presionar el boton ok
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fondo.Color;
            }
        }

        private void colorDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se crea un objeto de tipo colordialog que servira para cabiar color de la fuente 
            ColorDialog color = new ColorDialog();
            //se hace la condicion para cambiar el color de la fuente al presionar el boton ok 
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            k = k - 1;
            if (k < 0)
            {
                open.window("Advertencia", "No se a ingresado una accion", true);
            }
            else
            {
                richTextBox1.Text = change[k];
                tl3.Text = "";
                tl3.Text = "Lineas de Codigo: " + richTextBox1.Lines.Length.ToString();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > to.nm)
            {                
                open.window("Advertencia","No se a ingresado una accion",true);
            }
            else
            {
                richTextBox1.Text = change[k];
                tl3.Text = "";
                tl3.Text = "Lineas de Codigo: " + richTextBox1.Lines.Length.ToString();
            }   
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void seleneSoftwareOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web form = new web();
            form.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {}

        private void hidding_Click(object sender, EventArgs e)
        {
            called form = new called();
            form.Show();
        }

        private void Form1_Close(object sender, EventArgs e)
        {
            open.dir = b;
            open.dire = richTextBox1.Text;
            Form6 form = new Form6();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            open.boty();
        }

        private void organize()
        {                     

            if (open.lib == false)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;                
                button8.Enabled = false;
            }

            if (open.main == false)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;                
                button8.Enabled = true;
            }

            if (open.close == false)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;                
                button8.Enabled = true;
            }

            if (open.namezpace == false)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;              
                button8.Enabled = false;
            }
        }

        private void asistenteDeConstantesYCondicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
  
      
    

