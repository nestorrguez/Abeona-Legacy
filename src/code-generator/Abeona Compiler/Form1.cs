using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] last_do = new string[1500];
        int k;
        string txtdireccion, license, lan,len,last;
        string f, g, jk;
        bool opened;
        public Form1()
        {
            read();
            config();
            if (opened)
            {
                InitializeComponent();
                initialize();                
            }
            else
            {
                alerta();           
                Application.Exit();
            }   
        }
        

        void alerta()
        {
            alert form = new alert();
            form.Show();
        }

        void read()
        {
            //license
            txtdireccion = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\licence.txt";
            System.IO.StreamReader sr = new System.IO.StreamReader(@txtdireccion, System.Text.Encoding.Default);
            license = sr.ReadToEnd();
            sr.Close();
            //name
            txtdireccion = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\name.txt";
            System.IO.StreamReader nm = new System.IO.StreamReader(@txtdireccion, System.Text.Encoding.Default);
            key.name = nm.ReadToEnd();
            sr.Close();
            //languaje
            txtdireccion = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\languaje.txt";
            System.IO.StreamReader txt = new System.IO.StreamReader(@txtdireccion, System.Text.Encoding.Default);
            lan = txt.ReadToEnd();
            sr.Close();
            //lenguaje
            txtdireccion = @"C:\Archivos de programa\Win86x\01000001 01000010 01010100 01001100\01000011 01000100 01000111 01010100\01010100 01010010 01010101 01000101\lenguaje.txt";
            System.IO.StreamReader pr = new System.IO.StreamReader(@txtdireccion, System.Text.Encoding.Default);
            len = pr.ReadToEnd();
            sr.Close();

        }

        void config()
        {
            //license
            if (license == "1")
            {
                opened = true;
            }
            else
            {
                opened = false;
            }

            //languaje            
            key.languaje = int.Parse(lan);

            //lenguaje
            key.lengprog = int.Parse(len);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.body();
        }

        private void languaje_Click(object sender, EventArgs e)
        {
            open.funtions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open.comentary();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            open.printxt();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            open.variable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            open.condition();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            open.cicles();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initialize();
            switch (key.lengprog)
            {
                case 1:
                    {
                        code.Text = "//Tu Codigo en C++" + "\r\n" + "//Librerias" + "\r\n" + "#include <iostream>" + "\r\n" + "#include <cstdlib>" + "\r\n" + "#include <windows.h>" + "\r\n" + "using namespace std;" + "\r\n" + "//Declara aqui tus variables"; libt();
                    } break;
                case 2:
                    {
                        code.Text = "//Tu Codigo en C#" + "\r\n" + "//Librerias" + "\r\n" + "using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Linq;" + "\r\n" + "using System.Text;" + "\r\n" + "namespace cs_program;" + "\r\n" + "{" + "\r\n" + "class Program" + "\r\n" + "{" + "\r\n" + "static void Main(string[] args)" + "\r\n{";
                        maint();
                    } break;
            }
            tl3.Text = "Lineas de Codigo: " + code.Lines.Length.ToString();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
            switch (key.lengprog)
            {
                case 1:
                    {
                        Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cpp*)|*.cpp|Todos los archivos(*.*)|*.*";
                    } break;

                case 2:
                    {
                        Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cs*)|*.cpp|Todos los archivos(*.*)|*.*";
                    } break;
      
            }
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                //este codigo se utiliza para guardar el archivo de nuestro editor
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(code.Text);
                myStreamWriter.Flush();   
                jk=Save.FileName;
            }
            catch (Exception) { }
            this.Text = "Code Generator [" + jk + "]";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            code.Focus();
            code.SelectAll();
            code.Copy();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            code.Focus();
            code.Clear();
            initialize();
            key.code = "";
            anal();
        }        

        private void toolStripButton6_Click(object sender, EventArgs e)
        {            
            write();            
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            open.about(); 
        }
       
        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            write();
        }        

        private void eliminarTodoElCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Focus();
            code.Clear();
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se crea un objeto de tipo colordialog que servira para cabiar color del rich textbox
            ColorDialog fondo = new ColorDialog();
            //se hace la condicion para cambiar el tipo de color del rich textbox al presionar el boton ok
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                code.BackColor = fondo.Color;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se crea un objeto de tipo colordialog que servira para cabiar color de la fuente 
            ColorDialog color = new ColorDialog();
            //se hace la condicion para cambiar el color de la fuente al presionar el boton ok 
            if (color.ShowDialog() == DialogResult.OK)
            {
                code.ForeColor = color.Color;
            }
        }       

        private void seleneSoftwareOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "www.selenesoftware.blogspot.mx"); 
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.about();
        }

        private void lenguajeDeProgramacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.lenprog();
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.languaje();
        }

        void write()
        {
            if (key.code == "")
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                code.Text = code.Text + "\r\n" + key.code;
                key.num = key.num + 1;
                last_do[key.num] = code.Text;
                key.code = "";
                k = key.num;
                anal();
                tl3.Text = "";
                tl3.Text = "Lineas de Codigo: " + code.Lines.Length.ToString();
            }            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            k = k - 1;
            if (k < 0)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {               
                code.Text = last_do[k];
                tl3.Text = "";
                tl3.Text = "Lineas de Codigo: " + code.Lines.Length.ToString();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > key.num)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {                
                code.Text = last_do[k];
                tl3.Text = "";
                tl3.Text = "Lineas de Codigo: " + code.Lines.Length.ToString();
            }            
        }

        void initialize()
        {
            
            key.num = 0;
            key.n = 0;
            switch (key.lengprog)
            {
                case 1: f = " C++"; break;
                case 2: f = " C#"; break;
            }
            switch (key.languaje)
            {
                case 1: g = " Español"; break;
                case 2: g = " English"; break;
            }
            tl1.Text="Lenguaje de Programacion: "+f;
            tl2.Text = "Idioma: " + g;
            tl3.Text ="Lineas de Codigo: " + code.Lines.Length.ToString();
            key.libut = true;
            key.main = true;
            last_do[0] = " ";
            code.Text = " ";
            start();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            code.Focus();
            code.SelectAll();
            code.Copy();
        }
        
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter a = new System.IO.StreamWriter(@"C:\open.txt")) { }
            string save;
            save = @"C:\open.txt";
            System.IO.StreamWriter myStreamWriter = null;
            myStreamWriter = System.IO.File.AppendText(save);
            myStreamWriter.Write(code.Text);
            myStreamWriter.Flush();
            string  txtdireccionb;
            using (System.IO.StreamWriter c = new System.IO.StreamWriter(@"C:\open_code.txt")) { }
            txtdireccionb = @"C:\open_code.txt";
            System.IO.StreamWriter myStreamWritert = null;
            myStreamWritert = System.IO.File.AppendText(txtdireccionb);
            myStreamWritert.Write("1");
            myStreamWritert.Flush();
            System.Diagnostics.Process.Start(@"C:\Archivos de programa\Selene Software\Tot Tools\Text\Tot Text.exe"); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k = k - 1;
            if (k < 0)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                code.Text = last_do[k];
            }
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > key.num)
            {
                key.title = "Advertencia";
                key.info = "No se a ingresado una accion";
                key.does = true;
                open.error();
            }
            else
            {
                code.Text = last_do[k];
            } 
        }

        private void seleccionarTodoElCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Focus();
            code.SelectAll();
        }

        private void copiarCodigoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            code.Copy();
        }

        private void comandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comand form = new comand();
            form.Show();
        }

        void start()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            key.main = true;
            key.libut = true;
        }

        void maint()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            key.main = false;
        }

        void libt()
        {
            button1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            key.libut = false;
        }

        void endt()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            key.end = false;
        }

        void anal()
        {
            if (code.Text.Contains("#include <iostream> \r\n#include <cstdlib> \r\n#include <windows.h> \r\nusing namespace std;") || key.libut == false)
            {
                libt();
            }

            switch (key.lengprog)
            {
                case 1:
                    {
                        if (code.Text.Contains("\r\nmain() \r\n{") || key.main == false)
                        {
                            maint();
                        }
                    } break;
                case 2:
                    {
                        if (code.Text.Contains("using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Linq;" + "\r\n" + "using System.Text;" + "\r\n" + "namespace cs_program;" + "\r\n" + "{" + "\r\n" + "class Program" + "\r\n" + "{" + "\r\n" + "static void Main(string[] args)" + "\r\n{") || key.main==false)
                        {
                            maint();
                        }
                    } break;
            }
        }

        private void asistenteDeConstantesYCondicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void unPaseoPorCodeGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.wizzard();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            open.wizzard();
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //este codigo se utiliza para guardar el archivo de nuestro editor
            myStreamWriter = System.IO.File.AppendText(jk);
            myStreamWriter.Write(code.Text);
            myStreamWriter.Flush();    
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void Form1_Close(object sender, EventArgs e)
        {
            if (last != code.Text)
            {
 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            open.body();
        }
                                
    }
}
