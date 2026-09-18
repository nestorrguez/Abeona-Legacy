using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace CodeGenCS
{
    public partial class Form1 : Form
    {
        public static string a,b,user,arg,cmd;
        int n,k,pp;
        string f, g, sd;
        string[] change = new string[1500];
       
        public Form1()
        {
            read();
            to.tab = "";
            open.lib = true;            
            open.main = true;
            open.close = true;
            open.namezpace = true;
            to.line = 0;
            InitializeComponent();            
            pp = 0;
            organize();
            Proyect.name = " ";
            user = SystemInformation.UserName;            
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
            /*using (StreamReader rr = new StreamReader(@"C:\Users\" + user + @"\Documents\Mis Codigos\view.cg"))
            {
                sd = rr.ReadLine();
            }*/
            sd = "1";
            switch (int.Parse(sd))
            {
                case 1:
                    richTextBox1.ReadOnly = true;
                    richTextBox1.Dock = DockStyle.None;
                    panel1.Visible = false;
                    toolStrip3.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    break;

                case 2:
                    richTextBox1.ReadOnly = true;
                    richTextBox1.Dock = DockStyle.None;
                    panel1.Visible = true;
                    toolStrip3.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    break;


                case 3:
                    richTextBox1.ReadOnly = false;
                    richTextBox1.Dock = DockStyle.Fill;
                    panel1.Visible = false;
                    toolStrip3.Visible = true;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    break;
            }
            b = "";
            open.dir = b;
            to.nm = 0;
            open.lib = true;
            open.main = true;
            open.namezpace = true;
            claz.variables[0, 0] = "Program";
            claz.numclass = 0;
            richTextBox1.Text = "";
            tl1.Text = "Lenguaje de Programacion: " + f;
            tl2.Text = "Idioma: " + g;
            tl3.Text = "Lineas de Codigo: " + richTextBox1.Lines.Length.ToString();
            string[] args = Environment.GetCommandLineArgs();
            for (int c = 0; c < args.Count(); c++)
            {
                arg = args[c];
            }
            string direct = Directory.GetCurrentDirectory();

            richTextBox1.Text += @"C:\" + Environment.SpecialFolder.Programs + @"\SeleneSoft\Abeona Tools\Code Generator\all.cg"; 
            if (System.IO.File.Exists(@"C:\" + Environment.SpecialFolder.Programs + @"\SeleneSoft\Abeona Tools\Code Generator\all.cg"))
            {
                
            }
            else
            {
                //System.Diagnostics.Process.Start(@"C:\Program Files\SeleneSoft\Abeona Tools\Code Generator\Association.exe");
            }
            if (arg.Contains(@"C:\Program Files\SeleneSoft\Abeona Tools\Code Generator") || arg.Contains(".exe"))
            {
            }
            else 
            {
                openp(Path.GetDirectoryName(arg),arg);                
            }
        }
        void add(int a, int b,string c, int d)
        {
            claz.numvar[a]++;
            claz.kindvar[a, b] = d;
            claz.variables[a, b] = c;
        }
        void read()
        {           
            to.lenprog = 2;            
            to.language = 1;          
        }


        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
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

            PrintDocument formulario = new PrintDocument();
            formulario.PrintPage += new PrintPageEventHandler(PRINT);
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = formulario;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                formulario.Print();
            }
            /* PrintDialog printDialog = new PrintDialog();
             PrintDocument documentToPrint = new PrintDocument();
             printDialog.Document = documentToPrint;

             if (printDialog.ShowDialog() == DialogResult.OK)
             {
                 StringReader reader = new StringReader(richTextBox1.Text);
                 documentToPrint.Print();
                 documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);      
             *}*/

        }

        private void PRINT(object obj, PrintPageEventArgs ev)
        {
            Font a = new Font("Consolas",11);
            float pos_x = 10;
            float pos_y = 20;
            ev.Graphics.DrawString(richTextBox1.Text,a , Brushes.Black, pos_x, pos_y, new StringFormat());
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            objets form = new objets();
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            /*switch (to.lenprog)
            {
                case 1:
                    richTextBox1.Text = "//Tu Codigo en C++" + "\r\n" + "//Librerias" + "\r\n" + "#include <iostream>" + "\r\n" + "#include <cstdlib>" + "\r\n" + "#include <windows.h>" + "\r\n" + "using namespace std;";
                    break;
                case 2:
                    richTextBox1.Text = "//Tu Codigo en C#" + "\r\n" + "//Librerias" + "\r\n" + "using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Text;" + "\r\n" + "using System.Threading;" + "\r\n" + "namespace cs_program" + "\r\n" + "{" + "\r\n" + "class Program" + "\r\n" + "{" + "\r\n" + "static void Main(string[] args)" + "\r\n{";
                    break;
            }
            change[0] = richTextBox1.Text;
            open.lib = false;
            open.main = false;
            open.close = true;
            open.namezpace = true;
            claz.variables[0, 0] = "Program";
            claz.numclass = 0;
            organize();*/
            newprog();            
        }
        void newprog()
        {
            NewPro form = new NewPro();
            form.Show();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (b == "")
            {
                save();
            }
            else
            {
                System.IO.Directory.Delete(b);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(b, true))
                {
                    file.Write(richTextBox1.Text);
                }
            }*/
            System.IO.File.Delete(Proyect.code);
            using (StreamWriter wc = new StreamWriter(Proyect.code,true))
            {
                wc.Write(richTextBox1.Text);
                wc.Close();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(Proyect.code);
            using (StreamWriter wc = new StreamWriter(Proyect.code, true))
            {
                wc.Write(richTextBox1.Text);
                wc.Close();
            }
            System.IO.File.Delete(Proyect.vars);
            using (StreamWriter wc = new StreamWriter(Proyect.vars, true))
            {
                for (int c = 0; c < to.line; c++)
                {
                    wc.WriteLine(to.varinfo[c, 0] + "," + to.varinfo[c, 1] + "," + to.varinfo[c, 2] + "," + to.varinfo[c, 3] + ",");
                }
                wc.Close();
            }
            System.IO.File.Delete(Proyect.clas);
            using (StreamWriter l = new StreamWriter(Proyect.clas, true))
            {
                l.Write(claz.numclass);
            }
            //save();
        }

        void save()
        {
           /* //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
            switch (to.lenprog)
            {
               
                case 2:
                    {
                        Save.Filter = "Codigo Fuente(*.cs*)|*.cs|Texto (*.txt)|*.txt|Todos los archivos(*.*)|*.*";
                    } break;

            }
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.FileName = @"C:\Users\" + user + @"\Documents\Mis Codigos\";
            Save.ShowDialog(this);
            try
            {
                //este codigo se utiliza para guardar el archivo de nuestro editor
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
                b = Save.FileName;
                open.dir = b;
                myStreamWriter.Close();                
            }
            catch (Exception) { }
            this.Text = "Code Generator [" + System.IO.Path.GetFileNameWithoutExtension(b) + "]";*/
            using (StreamWriter wc = new StreamWriter(Proyect.code,true))
            {
                wc.Write(richTextBox1.Text);
                wc.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*if (b == "")
            {
                save();
            }
            else
            {
                System.IO.Directory.Delete(b);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(b, true))
                {
                    file.Write(richTextBox1.Text);
                }
            }*/
            System.IO.File.Delete(Proyect.code);
            using (StreamWriter wc = new StreamWriter(Proyect.code, true))
            {
                wc.Write(richTextBox1.Text);
                wc.Close();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*switch (to.lenprog)
            {
                case 1:
                    richTextBox1.Text = "//Tu Codigo en C++" + "\r\n" + "//Librerias" + "\r\n" + "#include <iostream>" + "\r\n" + "#include <cstdlib>" + "\r\n" + "#include <windows.h>" + "\r\n" + "using namespace std;";
                    break;
                case 2:
                    richTextBox1.Text = "//Tu Codigo en C#" + "\r\n" + "//Librerias" + "\r\n" + "using System;" + "\r\n" + "using System.Collections.Generic;" + "\r\n" + "using System.Text;" + "\r\n" + "using System.Threading;" + "\r\n" + "namespace cs_program;" + "\r\n" + "{";
                    break;
            }
            change[0] = richTextBox1.Text;
            claz.variables[0, 0] = "Program";
            claz.numclass = 0; */
            NewPro form = new NewPro();
            form.Show();
            this.Text = "Code Generator [" + Proyect.name + "]";
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Text = "Code Generator [" + Proyect.name + "]";
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
                //organize();
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
            claz.variables[0, 0] = "Program";
            claz.numclass = 0;
            richTextBox1.Text = "";
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
 
            }
            else
            {
 
            }
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            string s = "\r\n";
            open.window("Variables", "open.lib="+open.lib+s+"open.main="+open.main+s+"open.close="+open.close+s+"open.namezpace="+open.namezpace, true);
        }

        private void asistenteDeConstantesYCondicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            System.IO.File.Delete(Proyect.code);
            using (StreamWriter wc = new StreamWriter(Proyect.code, true))
            {
                wc.Write(richTextBox1.Text);
                wc.Close();
            }
            System.IO.File.Delete(Proyect.vars);
            using (StreamWriter wc = new StreamWriter(Proyect.vars, true))
            {
                for (int c = 0; c < to.line; c++)
                {
                    wc.WriteLine(to.varinfo[c, 0] + "," + to.varinfo[c, 1] + "," + to.varinfo[c, 2] + "," + to.varinfo[c, 3] + ",");
                }
                wc.Close();
            }
            System.IO.File.Delete(Proyect.clas);
            using (StreamWriter l = new StreamWriter(Proyect.clas, true))
            {
                l.Write(claz.numclass);
            }
            System.IO.File.Delete(Proyect.expt + Proyect.name + ".cs");            
            using (StreamWriter wr = new StreamWriter(Proyect.expt + Proyect.name + ".cs", true))
            {
                wr.Write(richTextBox1.Text);
            }
            b = Proyect.expt + Proyect.name + ".cs";
            to.compile = true;
            debugger form = new debugger();
            form.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clasicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox1.Dock = DockStyle.None;
            panel1.Visible = false;
            toolStrip3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            System.IO.File.Delete(@"C:\Users\" + user + @"\Documents\Mis Codigos\view.cg");
            using (StreamWriter sr = new StreamWriter(@"C:\Users\" + user + @"\Documents\Mis Codigos\view.cg", true))
            {
                sr.WriteLine("1");
            }            
        }

        private void principianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox1.Dock = DockStyle.None;
            panel1.Visible = true;
            toolStrip3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            System.IO.File.Delete(@"C:\Users\" + user + @"\Documents\Mis Codigos\view.cg");
            using (StreamWriter sr = new StreamWriter(@"C:\Users\" + user + @"\Documents\Mis Codigos\view.cg", true))
            {
                sr.WriteLine("2");
            }                
        }

        private void experimentadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.Dock = DockStyle.Fill;
            panel1.Visible = false;
            toolStrip3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            System.IO.File.Delete(@"C:\Users\" + user + @"\Documents\Mis Codigos\view.cg");
            using (StreamWriter sr = new StreamWriter(@"C:\Users\" + user + @"\Documents\Mis Codigos\view.cg", true))
            {
                sr.WriteLine("3");
            }   
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void copiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void seleccionarTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void generarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Text = "Code Generator [" + Proyect.name + "]";
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
                //organize();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\nnamespace program_cs\r\n{" + "\r\nclass Program\r\n{\r\nstatic void Main(string[] args)\r\n{"; ;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            open.printf(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\nnamespace program_cs\r\n{" + "\r\nclass Program\r\n{\r\nstatic void Main(string[] args)\r\n{"; ;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            open.printf(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            open.variable(0, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            open.variable(0, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            open.estc();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            open.estc();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cic form = new cic();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\nConsole.ReadKey(true);\r\n}\r\n}\r\n}";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cic form = new cic();
            form.Show();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\nConsole.ReadKey(true);\r\n}\r\n}\r\n}";
        }

        private void agregarLibreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nnamespace program_cs\r\n{";
        }

        private void agregarMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\nclass Program\r\n{\r\nstatic void Main(string[] args)\r\n{";

        }

        private void cerrarCuerpoPrincipalDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}\r\n}";

        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n}";

        }

        private void insertarComentarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\n//" + toolStripTextBox1.Text;
            toolStripTextBox1.Clear();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                richTextBox1.Text += "\r\n//" + toolStripTextBox1.Text;
                toolStripTextBox2.Clear();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            open.variable(0, 0);
        }

        private void opcionesAvansadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.printf(0);
        }

        private void imprimirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\nConsole.Write(\"" + toolStripTextBox2.Text + "\");";
            toolStripTextBox2.Clear();
        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                richTextBox1.Text += "\r\nConsole.Write(\"" + toolStripTextBox2.Text + "\");";
                toolStripTextBox2.Clear();
            }
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.color();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\nConsole.ReadKey(true);";
        }

        private void retrasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.delayt();
        }

        private void ifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.ifw(0);
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.switchw(0);
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.whilew(0);
        }

        private void doWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.do_whilew(0);
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.forw(0);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            objets form = new objets();
            form.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.help(0);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            open.boty();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            open.coment();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            open.variable(0, 0);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            open.printf(0);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            open.prefuntion();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            open.estc();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            cic frm = new cic();
            frm.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            objets frm = new objets();
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                pp++;
                if (pp > 1)
                { }
                else
                {
                    const string message = "¿Desea guardar los cambios hechos al proyecto?";
                    const string caption = "Code Generator";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // If the no button was pressed ...
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                        e.Cancel = false;
                    }
                    else
                    {
                        /*if (open.dir == "")
                        {
                            //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
                            SaveFileDialog Save = new SaveFileDialog();
                            System.IO.StreamWriter myStreamWriter = null;
                            //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
                            switch (to.lenprog)
                            {
                                case 1:
                                    Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cpp*)|*.cpp|Todos los archivos(*.*)|*.*";
                                    break;

                                case 2:
                                    Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cs*)|*.cs|Todos los archivos(*.*)|*.*";
                                    break;

                            }
                            Save.CheckPathExists = true;
                            Save.Title = "Guardar como";
                            Save.ShowDialog(this);
                            try
                            {
                                //este codigo se utiliza para guardar el archivo de nuestro editor
                                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                                myStreamWriter.Write(open.dire);
                                myStreamWriter.Flush();
                            }
                            catch (Exception) { }
                            Application.Exit();
                        }
                        else
                        {
                            System.IO.StreamWriter myStreamWriter = null;
                            myStreamWriter = System.IO.File.AppendText(open.dir);
                            myStreamWriter.Write(open.dire);
                            myStreamWriter.Flush();
                            Application.Exit();
                        }
                        //e.Cancel = false;*/
                        System.IO.File.Delete(Proyect.code);
                        using (StreamWriter wc = new StreamWriter(Proyect.code))
                        {
                            wc.Write(richTextBox1.Text);
                            wc.Close();
                        }
                        System.IO.File.Delete(Proyect.vars);
                        using (StreamWriter wc = new StreamWriter(Proyect.vars))
                        {
                            for (int c = 0; c < to.line; c++)
                            {
                                wc.WriteLine(to.varinfo[c, 0] + "," + to.varinfo[c, 1] + "," + to.varinfo[c, 2] + "," + to.varinfo[c, 3] + ",");
                            }
                            wc.Close();
                        }
                        System.IO.File.Delete(Proyect.clas);
                        using (StreamWriter l = new StreamWriter(Proyect.clas))
                        {
                            l.Write(claz.numclass);
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void codeGeneratorConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win32.AllocConsole();
            Programa.consol(); 
            Win32.FreeConsole();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Console.Clear()";
        }

        private void toolStripSplitButton12_ButtonClick(object sender, EventArgs e)
        {
            cic form = new cic();
            form.Show();
        }

        private void toolStripSplitButton11_ButtonClick(object sender, EventArgs e)
        {
            est form = new est();
            form.Show();
        }

        private void toolStripSplitButton10_ButtonClick(object sender, EventArgs e)
        {
            open.prefuntion();
        }

        private void toolStripSplitButton9_ButtonClick(object sender, EventArgs e)
        {
            open.printf(0);
        }

        private void toolStripSplitButton8_ButtonClick(object sender, EventArgs e)
        {
            open.coment();
        }

        private void toolStripSplitButton7_ButtonClick(object sender, EventArgs e)
        {
            open.boty();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            prefuntions form = new prefuntions();
            form.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            prefuntions form = new prefuntions();
            form.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e){ }

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPro form = new NewPro();
            form.Show();
        }

        private void abrirProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
              //se crea un objeto de openfiledialogo que nos servira para abrir archivos
            OpenFileDialog Open = new OpenFileDialog();
            //se especifica que tipos de archivos se podran abrir y se verifica si existe
            Open.Filter = "Proyecto de Code Generator [*.cgp*]|*.cgp";
            Open.CheckFileExists = true;
            Open.Title = "Abrir Proyecto";
            Open.InitialDirectory = @"C:\Users\" + SystemInformation.UserName + @"\Documents\Mis Codigos\"; 
            Open.ShowDialog(this);
            try
            {
                openp(Path.GetDirectoryName(Open.FileName), Open.FileName);
            }
            catch (Exception) { }
        }

        void openp(string direct,string ar)
        {
            using (StreamReader rd = new StreamReader(ar, System.Text.Encoding.Default))
            {
                cmd = rd.ReadLine().ToString();
                rd.Close();
            }
            Proyect.name = cmd;
            Proyect.code = direct + @"\Data\" +  Proyect.name + ".cgc";
            Proyect.vars = direct + @"\Data\" + Proyect.name + "_vars.cgv";
            Proyect.clas = direct + @"\Data\" + Proyect.name + "_class.cgv";
            Proyect.expt = direct + @"\CS\";
            
            using (StreamReader rsc = new StreamReader(Proyect.code, System.Text.Encoding.Default))
            {
                string all = rsc.ReadToEnd().ToString();
                richTextBox1.Text = all;
                rsc.Close();
            }

            using (StreamReader clazz = new StreamReader(Proyect.clas, System.Text.Encoding.Default))
            {
                string cn = clazz.ReadLine().ToString();
                claz.numclass = int.Parse(cn);
            }
            using (StreamReader srvs = new StreamReader(Proyect.vars, System.Text.Encoding.Default))
            {
                string line;
                do
                {
                    line = srvs.ReadLine().ToString();
                    if (line != null)
                    {
                        string[] com = line.Split(',');
                        add(int.Parse(com[0]), int.Parse(com[1]), com[2], int.Parse(com[3]));
                    }
                } while (line != null);
            }
            tl1.Text = "Lenguaje de Programacion: " + f;
            tl2.Text = "Idioma: " + g;
            tl3.Text = "Lineas de Codigo: " + richTextBox1.Lines.Length.ToString();
            this.Text = Proyect.name;
        }
    }
}