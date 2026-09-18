using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using Microsoft.Win32;
using Microsoft.Runtime;

namespace CompÑ
{
    public partial class Ñ : Form
    {
        public static string texto,name;
        SaveFileDialog Guardar = new SaveFileDialog();
        OpenFileDialog Abrir = new OpenFileDialog();
        string temp = "";
        string temp1 = "";
        public  string lineas_de_prueba = "";
        string dir = "";
        public static Ñ Formulario;
        public Ñ()
        {
            InitializeComponent();
            Texto.Text = texto;
        }
        private void GuardarArchivo()
        {
            if (dir == "")
            {
                bool bb = true;
                Guardar.Title = "Guardar como...";
                Guardar.Filter = "Archivo de código fuente[Ñ] (*.ñ)|*.ñ";
                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    string d = "", n="";
                    try
                    {
                        string nombre = "\\" + Path.GetFileNameWithoutExtension(Guardar.FileName);
                        string direccion = Path.GetDirectoryName(Guardar.FileName);
                        Directory.CreateDirectory(direccion + nombre);
                        using (StreamWriter sw = new StreamWriter(direccion + nombre + nombre + ".ñ", false))
                        {
                            d = direccion + nombre;
                            n = nombre;
                            string[] lineas = Texto.Text.Split('\n');
                            for (int i = 0; i < lineas.Length; i++)
                                sw.WriteLine(lineas[i]);
                            sw.Close();
                        }
                    }
                    catch (Exception E)
                    {
                        bb = false;
                        MessageBox.Show(E.ToString(), "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (bb)
                    {
                        name = n;
                        dir = d;
                        this.Text = "Compilador Ñ - " + name;
                    }
                }
            }
            else
            {
                try
                {
                    string nombre = "\\" + Path.GetFileNameWithoutExtension(dir);
                    string direccion = Path.GetDirectoryName(dir);
                    using (StreamWriter sw = new StreamWriter(dir + nombre + ".ñ", false))
                    {
                        string[] lineas = Texto.Text.Split('\n');
                        for (int i = 0; i < lineas.Length; i++)
                            sw.WriteLine(lineas[i]);
                        sw.Close();
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString(), "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private static string Reemplazar(string texto, string texto_para_reemplazar, string texto_para_sustituir)
        {
            bool b = false;
            int posicion = 0;
            string reemplazo = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (i + texto_para_reemplazar.Length - 1 < texto.Length)
                {
                    string prueba = "";
                    for (int j = 0; j < texto_para_reemplazar.Length; j++)
                    {
                        prueba += texto[i + j];
                    }
                    if (prueba == texto_para_reemplazar)
                    {
                        posicion = i;
                        b = true;
                        break;
                    }
                }
                reemplazo += texto[i];
            }
            if (b)
            {
                reemplazo += texto_para_sustituir;
                for (int i = posicion + texto_para_reemplazar.Length; i < texto.Length; i++)
                {
                    reemplazo += texto[i];
                }
            }
            return reemplazo;
        }
        private void Convertir_a_C_Sharp()
        {
            lineas_de_prueba = Texto.Text;
            string[] lineas = lineas_de_prueba.Split('\n');
            lineas_de_prueba = "";
            string temp2;
            string[] variables;
            for (int i = 0; i < lineas.GetLength(0); i++)
            {
                if (!lineas[i].TrimStart(' ').StartsWith("\\" + "\\"))
                {
                    if (lineas[i].Contains("imprimir") & !lineas[i].Contains("cadena"))
                    {
                        string linea = lineas[i];
                        int posicion = 0;
                        string nueva_linea = "";
                        for (int j = 0; j < linea.Length; j++)
                        {
                            if (j + 7 < linea.Length)
                            {
                                if (linea[j] == 'i' & linea[j + 1] == 'm' & linea[j + 2] == 'p' & linea[j + 3] == 'r' & linea[j + 4] == 'i' & linea[j + 5] == 'm' & linea[j + 6] == 'i' & linea[j + 7] == 'r')
                                {
                                    posicion = j;
                                    break;
                                }
                            }
                            nueva_linea += linea[j];
                        }
                        nueva_linea += "Console.Write(";
                        for (int j = posicion + 8; j < linea.Length; j++)
                        {
                            nueva_linea += linea[j];
                        }
                        lineas[i] = nueva_linea;
                    }
                    if (!lineas[i].Contains("Console.Write(") & !lineas[i].Contains("cadena"))
                    {

                        lineas[i] = Reemplazar(lineas[i], "para", "for(");
                        lineas[i] = lineas[i].Replace(".Pot", ".Pow");
                        lineas[i] = lineas[i].Replace("Titulo", "Console.Title = ");
                        lineas[i] = Reemplazar(lineas[i], "h-mientras", "hwhile(");
                        lineas[i] = Reemplazar(lineas[i], "mientras", "while(");
                        lineas[i] = Reemplazar(lineas[i], "hacer", "do");
                        if (!lineas[i].Contains("Console.CursorVisible"))
                        {
                            lineas[i] = lineas[i].Replace("no", "else");
                            lineas[i] = lineas[i].Replace("si", "if(");
                        }
                        lineas[i] = lineas[i].Replace("limpiar", "            Console.Clear();");
                        lineas[i] = lineas[i].Replace("pausa", "            Console.ReadKey();");
                        lineas[i] = lineas[i].Replace("esperar", "           System.Threading.Thread.Sleep(");
                        if (lineas[i].ToUpper().Contains("INICIO"))
                        {
                            string s = lineas[i];
                            lineas[i] = lineas[i].Replace(s, "using System;\n\nnamespace ConsoleApplication1\n{\n    class Program\n    {\n        static void Main(string[] args)\n        {");
                        }
                        if (lineas[i].ToUpper().Contains("FIN"))
                        {
                            string s = lineas[i];
                            lineas[i] = lineas[i].Replace(s, "        }\n    }\n}");
                        }
                    }
                    lineas[i] = lineas[i].Replace("Sonido", "Console.Beep(");
                    lineas[i] = lineas[i].Replace(".Acadena", ".ToString()");
                    lineas[i] = lineas[i].Replace(".Longitud", ".Length");
                    lineas[i] = lineas[i].Replace(".Mayuscula", ".ToUpper()");
                    lineas[i] = lineas[i].Replace(".Minuscula", ".ToLower()");
                    lineas[i] = lineas[i].Replace("Mate", "Math");
                    if (lineas[i].Contains("pantalla azul oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla azul oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.DarkBlue;");
                    }
                    else if (lineas[i].Contains("pantalla azul") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla azul";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Blue;");
                    }
                    else if (lineas[i].Contains("pantalla verde oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla verde oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.DarkGreen;");
                    }
                    else if (lineas[i].Contains("pantalla rosa") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla rosa";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Magenta;");
                    }
                    else if (lineas[i].Contains("pantalla morada") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla morada";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.DarkMagenta;");
                    }
                    else if (lineas[i].Contains("pantalla amarillo oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla amarillo oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.DarkYellow;");
                    }
                    else if (lineas[i].Contains("pantalla rojo oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla rojo oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.DarkRed;");
                    }
                    else if (lineas[i].Contains("pantalla aguamarina") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla aguamarina";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Cyan;");
                    }
                    else if (lineas[i].Contains("pantalla verde azulado") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla verde azulado";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.DarkCyan;");
                    }
                    else if (lineas[i].Contains("pantalla gris") & !lineas[i].Contains("Console.Write"))
                    {
                        temp2 = "pantalla gris";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Gray;");
                    }
                    else if (lineas[i].Contains("pantalla gris oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla gris oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.DarkGray;");
                    }
                    else if (lineas[i].Contains("pantalla blanca") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla blanca";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.White;");
                    }
                    else if (lineas[i].Contains("pantalla negra") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla negra";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Black;");
                    }
                    else if (lineas[i].Contains("pantalla amarilla") & !lineas[i].Contains("Console.Write"))
                    {
                        temp2 = "pantalla amarilla";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Yellow;");
                    }
                    else if (lineas[i].Contains("pantalla roja") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla roja";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Red;");
                    }
                    else if (lineas[i].Contains("pantalla verde") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "pantalla verde";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.BackgroundColor = ConsoleColor.Green;");
                    }
                    if (lineas[i].Contains("letra azul oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra azul oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.DarkBlue;");
                    }
                    else if (lineas[i].Contains("letra aguamarina") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra aguamarina";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.Cyan;");
                    }
                    else if (lineas[i].Contains("letra verde azulado") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra verde azulado";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.DarkCyan;");
                    }
                    else if (lineas[i].Contains("letra amarillo oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra amarillo oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.DarkYellow;");
                    }
                    else if (lineas[i].Contains("letra rojo oscuro") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra rojo oscuro";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.DarkRed;");
                    }
                    else if (lineas[i].Contains("letra negra") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra negra";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.Black;");
                    }
                    else if (lineas[i].Contains("letra blanca") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra blanca";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.White;");
                    }
                    else if (lineas[i].Contains("letra gris") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra gris";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.Gray;");
                    }
                    else if (lineas[i].Contains("letra roja") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra roja";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.Red;");
                    }
                    else if (lineas[i].Contains("letra verde") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra verde";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.Green;");
                    }
                    else if (lineas[i].Contains("letra morada") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra morada";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.DarkMagenta;");
                    }
                    else if (lineas[i].Contains("letra rosa") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra rosa";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.Magenta;");
                    }
                    else if (lineas[i].Contains("letra amarilla") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "letra amarilla";
                        lineas[i] = lineas[i].Replace(temp2, "            Console.ForegroundColor = ConsoleColor.Yellow;");
                    }

                    if (lineas[i].Contains("pedir entero") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = lineas[i];
                        string temp3 = temp2.Replace("pedir entero", "");
                        variables = temp2.Split(' ');
                        int ultima_palabra = variables.Count() - 1;
                        if (temp3.Contains("entero"))
                        {
                            temp2 = "            entero ";
                        }
                        else
                        {
                            temp2 = "            ";
                        }
                        temp2 += variables[ultima_palabra];
                        temp2 += " = Convert.ToInt32(Console.ReadLine());";
                        lineas[i] = temp2;
                    }
                    else if (lineas[i].Contains("pedir cadena") & !lineas[i].Contains("Console.Write"))
                    {
                        temp2 = lineas[i];
                        string temp3 = temp2.Replace("pedir cadena", "");
                        variables = temp2.Split(' ');
                        int ultima_palabra = variables.Count() - 1;
                        if (temp3.Contains("cadena"))
                        {
                            temp2 = "            cadena ";
                        }
                        else
                        {
                            temp2 = "            ";
                        }
                        temp2 += variables[ultima_palabra];
                        temp2 += " = Convert.ToString(Console.ReadLine());";
                        lineas[i] = temp2;
                    }
                    else if (lineas[i].Contains("pedir caracter") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = lineas[i];
                        string temp3 = temp2.Replace("pedir caracter", "");
                        variables = temp2.Split(' ');
                        int ultima_palabra = variables.Count() - 1;
                        if (temp3.Contains("caracter"))
                        {
                            temp2 = "            caracter ";
                        }
                        else
                        {
                            temp2 = "            ";
                        }
                        temp2 += variables[ultima_palabra];
                        temp2 += " = Convert.ToChar(Console.ReadLine());";
                        lineas[i] = temp2;
                    }
                    else if (lineas[i].Contains("pedir doble") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = lineas[i];
                        string temp3 = temp2.Replace("pedir doble", "");
                        variables = temp2.Split(' ');
                        int ultima_palabra = variables.Count() - 1;
                        if (temp3.Contains("doble"))
                        {
                            temp2 = "            doble ";
                        }
                        else
                        {
                            temp2 = "            ";
                        }
                        temp2 += variables[ultima_palabra];
                        temp2 += " = Convert.ToDouble(Console.ReadLine());";
                        lineas[i] = temp2;
                    }
                    if (lineas[i].Contains("nuevo") & !lineas[i].Contains("cadena") & !lineas[i].Contains("Console.Write"))
                    {
                        lineas[i] = lineas[i].Replace("nuevo", "new");
                    }
                    if (lineas[i].Contains("cadena") & !lineas[i].Contains("Console.Write"))
                    {
                        temp2 = "cadena";
                        if (lineas[i].Contains(" = Convert.ToString(Console.ReadLine());"))
                        {
                            lineas[i] = lineas[i].Replace(temp2, "            string");
                        }
                        else
                        {
                            if (!lineas[i].Contains("for("))
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            string") + ";";
                            }
                            else
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            string");
                            }
                        }
                    }
                    else if (lineas[i].Contains("entero") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "entero";
                        if (lineas[i].Contains(" = Convert.ToInt32(Console.ReadLine());"))
                        {
                            lineas[i] = lineas[i].Replace(temp2, "            int");
                        }
                        else
                        {
                            if (!lineas[i].Contains("for("))
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            int") + ";";
                            }
                            else
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            int");
                            }
                        }
                    }
                    else if (lineas[i].Contains("logico") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "logico";
                        lineas[i] = lineas[i].Replace(temp2, "            bool");

                    }
                    else if (lineas[i].Contains("caracter") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "caracter";
                        if (lineas[i].Contains(" = Convert.ToChar(Console.ReadLine());"))
                        {
                            lineas[i] = lineas[i].Replace(temp2, "            char");
                        }
                        else
                        {
                            if (!lineas[i].Contains("for("))
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            char") + ";";
                            }
                            else
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            char");
                            }
                        }
                    }
                    else if (lineas[i].Contains("doble") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        temp2 = "doble";
                        if (lineas[i].Contains(" = Convert.ToDouble(Console.ReadLine());"))
                        {
                            lineas[i] = lineas[i].Replace(temp2, "            double");
                        }
                        else
                        {
                            if (!lineas[i].Contains("for("))
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            double") + ";";
                            }
                            else
                            {
                                lineas[i] = lineas[i].Replace(temp2, "            double");
                            }
                        }
                    }
                    if (lineas[i].Contains("Console.WriteLine") | lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        lineas[i] += ");";
                    }
                    if (lineas[i].Contains("if(") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("Console.CursorVisible") & !lineas[i].Contains("cadena"))
                    {
                        lineas[i] += ")";
                        lineas[i] = lineas[i].Replace("yy", "&");
                        lineas[i] = lineas[i].Replace('ó', '|');
                    }
                    if (lineas[i].Contains("System.Threading.Thread.Sleep(") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        lineas[i] += ");";
                    }
                    if (lineas[i].Contains("for(") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        lineas[i] += ")";
                        lineas[i] = lineas[i].Replace("yy", "&");
                        lineas[i] = lineas[i].Replace('ó', '|');
                    }
                    if (lineas[i].Contains("while(") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        lineas[i] += ")";
                        lineas[i] = lineas[i].Replace("yy", "&");
                        lineas[i] = lineas[i].Replace('ó', '|');
                    }
                    if (lineas[i].Contains("Console.Title") & !lineas[i].Contains("Console.Write") & !lineas[i].Contains("cadena"))
                    {
                        lineas[i] += ";";
                    }
                    if (!lineas[i].Contains("for(") & !lineas[i].Contains("while("))
                    {
                        if (lineas[i].Contains("++") | lineas[i].Contains("--") & !lineas[i].Contains("Console.Write"))
                        {
                            lineas[i] += ";";
                        }
                    }
                    if (lineas[i].Contains("hwhile(") & !lineas[i].Contains("Console.Write"))
                    {
                        lineas[i] = lineas[i].Replace("hwhile(", "while(");
                        lineas[i] += ";";
                        lineas[i] = lineas[i].Replace("yy", "&");
                        lineas[i] = lineas[i].Replace('ó', '|');
                    }
                    if (lineas[i].Contains("Console.Beep(") & !lineas.Contains("Console.Write"))
                    {
                        lineas[i] += ");";
                    }
                }
                lineas_de_prueba += lineas[i] + "\n";
            }
        }
        private void Guardar_Como()
        {
            Guardar.Filter = "Archivo de Codigo Fuente [Ñ]|*.cs";
            Guardar.Title = "Guardar como...";
            Convertir_a_C_Sharp();
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo carpeta = Directory.CreateDirectory(Path.GetDirectoryName(Guardar.FileName) + "\\" + Path.GetFileNameWithoutExtension(Guardar.FileName));
                string ruta = carpeta.FullName + "\\" + Path.GetFileNameWithoutExtension(Guardar.FileName) + ".cs";
                using (StreamWriter Escribir = new StreamWriter(ruta))
                {
                    Escribir.Write(lineas_de_prueba);
                }
                string archivo_txt = carpeta.FullName + "\\" + Path.GetFileNameWithoutExtension(Guardar.FileName) + ".ñ";
                using (StreamWriter Escribir = new StreamWriter(archivo_txt))
                {
                    string[] texto = Texto.Text.Split('\n');
                    for (int i = 0; i < texto.GetLength(0); i++)
                    {
                        Escribir.WriteLine(texto[i]);
                    }
                }
                Text = "Compilador Ñ - " + Path.GetFileNameWithoutExtension(Guardar.FileName);
                temp = ruta;
                Guardar.FileName = "";
                CodeDomProvider provider = null;
                FileInfo sourceFile = new FileInfo(temp);
                String exeName = String.Format(@"{0}\{1}.exe", (Path.GetDirectoryName(temp)), sourceFile.Name.Replace(".", "_"));
                provider = CodeDomProvider.CreateProvider("CSharp");
                CompilerParameters cp = new CompilerParameters();
                //cp.ReferencedAssemblies.Add("System.Linq.dll");
                //cp.ReferencedAssemblies.Add("System.Threading.dll");
                //cp.ReferencedAssemblies.Add("System.Drawing.dll");
                //cp.ReferencedAssemblies.Add("System.Globalization.dll");
                //cp.ReferencedAssemblies.Add("System.IO.dll");
                //cp.ReferencedAssemblies.Add("System.Net.dll");
                //cp.ReferencedAssemblies.Add("System.Web.dll");
                cp.GenerateExecutable = true;
                cp.OutputAssembly = exeName;
                cp.GenerateInMemory = false;
                cp.TreatWarningsAsErrors = false;
                CompilerResults cr = provider.CompileAssemblyFromFile(cp, temp);
                if (cr.Errors.Count > 0)
                {
                    MessageBox.Show("Errores contenidos  " + Path.GetFileNameWithoutExtension(temp) + " en " + cr.PathToAssembly, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                temp1 = exeName;
            }
        }
        private void Ñ_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            Text = "Compilador Ñ - Sín título";
            Ñ.Formulario = this;
            List<string> Rutas = Environment.GetCommandLineArgs().ToList();
            for (int i = 0; i < Rutas.Count; i++)
            {
                if (Path.GetExtension(Rutas[i]) == ".ñ")
                {
                    temp = Rutas[i];
                    CompilerResults cr = null;
                    string archivo_txt = Path.GetDirectoryName(temp) + "\\" + Path.GetFileNameWithoutExtension(temp) + ".ñ";
                    if (File.Exists(archivo_txt))
                    {
                        using (StreamReader Leer = new StreamReader(archivo_txt))
                        {
                            Texto.Text = Leer.ReadToEnd();
                        }
                        temp = Path.GetDirectoryName(temp) + "\\" + Path.GetFileNameWithoutExtension(temp) + ".cs";
                        Text = "Compilador Ñ - " + Path.GetFileNameWithoutExtension(temp);
                        CodeDomProvider provider = null;
                        FileInfo sourceFile = new FileInfo(temp);
                        String exeName = String.Format(@"{0}\{1}.exe", (Path.GetDirectoryName(temp)), sourceFile.Name.Replace(".", "_"));
                        provider = CodeDomProvider.CreateProvider("CSharp");
                        CompilerParameters cp = new CompilerParameters();
                        //cp.ReferencedAssemblies.Add("System.Linq.dll");
                        //cp.ReferencedAssemblies.Add("System.Threading.dll");
                        //cp.ReferencedAssemblies.Add("System.Drawing.dll");
                        //cp.ReferencedAssemblies.Add("System.Globalization.dll");
                        //cp.ReferencedAssemblies.Add("System.IO.dll");
                        //cp.ReferencedAssemblies.Add("System.Net.dll");
                        //cp.ReferencedAssemblies.Add("System.Web.dll");
                        cp.GenerateExecutable = true;
                        cp.OutputAssembly = exeName;
                        cp.GenerateInMemory = false;
                        cp.TreatWarningsAsErrors = false;
                        cr = provider.CompileAssemblyFromFile(cp, temp);
                        if (cr.Errors.Count > 0)
                        {

                        }
                        temp1 = exeName;
                    }
                    else
                    {
                        MessageBox.Show("No existe archivo CÑ del proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Cursor = Cursors.Arrow;
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar_Como();
        }       
        private void depurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generar();
        }
        private void Generar()
        {
            GuardarArchivo();

            Convertir_a_C_Sharp();
            string direccion = dir + "\\Ejecutable";
            if (!Directory.Exists(direccion))
            {
                Directory.CreateDirectory(direccion);
            }
            using (StreamWriter sw = new StreamWriter(direccion + "\\" + name + ".cs", false))
            {
                sw.Write(lineas_de_prueba);
                sw.Close();
            }
            CodeDomProvider provider = null;
            temp = direccion + "\\" + name + ".cs";
            FileInfo sourceFile = new FileInfo(direccion + "\\" + name + ".cs");
            String exeName = String.Format(@"{0}\{1}.exe", (Path.GetDirectoryName(temp)), sourceFile.Name.Replace(".cs", ""));
            provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters cp = new CompilerParameters();
            cp.GenerateExecutable = true;
            cp.OutputAssembly = exeName;
            cp.GenerateInMemory = false;
            cp.TreatWarningsAsErrors = false;
            CompilerResults cr = provider.CompileAssemblyFromFile(cp, temp);
            if (cr.Errors.Count > 0)
            {
                MessageBox.Show("Errores contenidos de  " + Path.GetFileNameWithoutExtension(temp) + " en " + cr.PathToAssembly, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.Delete(direccion + "\\" + name + ".cs");
                temp1 = exeName;
                MessageBox.Show("Archivo " + Path.GetFileNameWithoutExtension(temp) + " se ha compilado en " + cr.PathToAssembly + "satisfactoriamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(temp1);
            }
            temp1 = exeName;
        }

        private void Ñ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Generar();
            }
            else if (e.KeyCode == Keys.F2)
            {
                ByR b = new ByR();
                b.Show();
            }
            else if (e.KeyCode == Keys.F1)
            {
                Comentario();
            }
            else if (e.Control & e.KeyCode == Keys.N)
            {
                Texto.ForeColor = Color.Black;
                temp = null;
                temp1 = null;
                Text = "Compilador Ñ - Sín título";
                Texto.Text = "INICIO\nFIN";
            }
            else if (e.Control & e.KeyCode == Keys.G)
            {
                GuardarArchivo();
            }
            else if (e.Control & e.KeyCode == Keys.T)
            {
                Guardar_Como();
            }
            else if (e.Control & e.KeyCode == Keys.O)
            {
                AbrirArchivo();
            }
            else if (e.Control & e.KeyCode == Keys.J)
            {
                Guardar.Filter = "Archivo de Ñ|*.ñ|Archivo de texto|*.txt";
                Guardar.Title = "Guardar como...";
                Convertir_a_C_Sharp();
                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter Escribir = new StreamWriter(Guardar.FileName))
                    {
                        string[] texto = Texto.Text.Split('\n');
                        for (int i = 0; i < texto.GetLength(0); i++)
                        {
                            Escribir.WriteLine(texto[i]);
                        }
                    }
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                Coloreando();
            }
            else if (e.KeyCode == Keys.F4)
            {
                Dar_Formato();
            }
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.Copy();
        }
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.Cut();
        }
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.Paste();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.SelectedText = "";
        }
        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.Focus();
            Texto.SelectAll();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Black;
            temp = null;
            temp1 = null;
            Text = "Compilador Ñ - Sín título";
            Texto.Text = "INICIO\nFIN";
            dir = name = "";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void AbrirArchivo()
        {
            Abrir.Filter = "Archivo de Ñ|*.ñ";
            Abrir.Title = "Abrir...";           
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                string nombre = "\\" + Path.GetFileNameWithoutExtension(Abrir.FileName);
                string direccion = Path.GetDirectoryName(Abrir.FileName);
                dir = direccion;
                name = nombre;
                this.Text = "Compilador Ñ - " + name;
                using (StreamReader Leer = new StreamReader(dir + name + ".ñ"))
                {
                    Texto.Text = Leer.ReadToEnd();
                }                
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Guardar.Filter = "Archivo de CÑ|*.ñ|Archivo de texto|*.txt";
            Guardar.Title = "Guardar como...";
            Convertir_a_C_Sharp();
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter Escribir = new StreamWriter(Guardar.FileName))
                {
                    string[] texto = Texto.Text.Split('\n');
                    for (int i = 0; i < texto.GetLength(0); i++)
                    {
                        Escribir.WriteLine(texto[i]);
                    }
                }
            }
        }
        private void buscarYReemplazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ByR B = new ByR();
            B.Show();
        }
        private void comentarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comentario();
        }
        private void Comentario()
        {
            string Contenido = Texto.SelectedText;
            string[] lines = Contenido.Split('\n');
            Contenido = "";
            char Caracter = ' ';
            bool espacio = false;
            for (int i = 0; i < lines.GetLength(0); i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    Caracter = lines[i][j];
                    if (Caracter != ' ' & !espacio)
                    {
                        Contenido += "\\" + "\\";
                        espacio = true;
                    }
                    Contenido += Caracter;
                }
                if (i < lines.Length - 1)
                {
                    Contenido += "\n";
                }
                espacio = false;
            }
            Texto.SelectionColor = Color.Green;
            Texto.SelectedText = Contenido;
        }
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.Undo();
        }
        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.Redo();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void Dar_Formato()
        {
            string prueba = Texto.Text;
            string nuevo_texto = "", espacios = "";
            int contador = 0, cont_espacios = 0;
            string[] lines = prueba.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].TrimStart(' ');
            }
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains('{') & !lines[i].Contains("imprimir") & !lines[i].Contains("cadena") & !lines[i].Contains("caracter"))
                {
                    nuevo_texto += espacios + lines[i] + "\n";
                    contador = i + 1;
                    espacios = "";
                    cont_espacios++;
                    for (int j = 0; j < cont_espacios; j++)
                    {
                        espacios += "   ";
                    }
                    do
                    {
                        nuevo_texto += espacios + lines[contador] + "\n";
                        contador++;
                    }
                    while (!lines[contador].Contains('{') & !lines[contador].Contains('}'));
                    i = i + (contador - i - 1);
                }
                else if (lines[i].Contains('}') & !lines[i].Contains("imprimir") & !lines[i].Contains("cadena") & !lines[i].Contains("caracter"))
                {
                    cont_espacios--;
                    contador = i;
                    espacios = "";
                    for (int j = 0; j < cont_espacios; j++)
                    {
                        espacios += "   ";
                    }
                    do
                    {
                        nuevo_texto += espacios + lines[contador] + "\n";
                        contador++;
                    }
                    while (!lines[contador].Contains('}') & !lines[contador].Contains('{') & lines[contador].ToUpper() != "FIN");
                    i = i + (contador - i - 1);
                }
                else
                {
                    nuevo_texto += lines[i] + "\n";
                }
            }
            nuevo_texto = nuevo_texto.TrimEnd('\n');
            Texto.Text = nuevo_texto;
            Coloreando();
        }
        public void Coloreando()
        {
            Texto.ForeColor = Color.Black;
            Texto.Select(Texto.TextLength, 0);
            string tokens = "(INICIO|FIN)";
            Regex rex = new Regex(tokens);
            MatchCollection mc = rex.Matches(Texto.Text);
            int StartCursorPosition = Texto.SelectionStart;
            foreach (Match m in mc)
            {
                int startIndex = m.Index;
                int StopIndex = m.Length;
                if (startIndex > 0 || Texto.Text.Substring(0, 1) == "I")
                {
                    if (!(startIndex - 1 < 0))
                    {
                        Texto.Select(startIndex, StopIndex);
                        Texto.SelectionColor = Color.Black;
                        Texto.SelectionStart = StartCursorPosition;
                        Texto.SelectionColor = Texto.ForeColor;
                    }
                    else
                    {
                        Texto.Select(startIndex, StopIndex);
                        Texto.SelectionColor = Color.Black;
                        Texto.SelectionStart = StartCursorPosition;
                        Texto.SelectionColor = Texto.ForeColor;
                    }
                }
            }
            tokens = "(entero|cadena|caracter|logico|doble|para|mientras|hacer|h-mientras|si|no)";
            rex = new Regex(tokens);
            mc = rex.Matches(Texto.Text);
            StartCursorPosition = Texto.SelectionStart;
            foreach (Match m in mc)
            {
                int startIndex = m.Index;
                int StopIndex = m.Length;
                if (startIndex > 0 || Texto.Text.Substring(0, 1) == "I")
                {
                    if (!(startIndex - 1 < 0))
                    {
                        Texto.Select(startIndex, StopIndex);
                        Texto.SelectionColor = Color.Blue;
                        Texto.SelectionStart = StartCursorPosition;
                        Texto.SelectionColor = Texto.ForeColor;
                    }
                    else
                    {
                        Texto.Select(startIndex, StopIndex);
                        Texto.SelectionColor = Color.Blue;
                        Texto.SelectionStart = StartCursorPosition;
                        Texto.SelectionColor = Texto.ForeColor;
                    }
                }
            }
            tokens = "(limpiar|Sonido|pausa|esperar|imprimir|pantalla|letra|Titulo|pedir)";
            rex = new Regex(tokens);
            mc = rex.Matches(Texto.Text);
            StartCursorPosition = Texto.SelectionStart;
            foreach (Match m in mc)
            {
                int startIndex = m.Index;
                int StopIndex = m.Length;
                if (startIndex > 0 || Texto.Text.Substring(0, 1) == "I")
                {
                    if (!(startIndex - 1 < 0))
                    {
                        Texto.Select(startIndex, StopIndex);
                        Texto.SelectionColor = Color.Brown;
                        Texto.SelectionStart = StartCursorPosition;
                        Texto.SelectionColor = Texto.ForeColor;
                    }
                    else
                    {
                        Texto.Select(startIndex, StopIndex);
                        Texto.SelectionColor = Color.Brown;
                        Texto.SelectionStart = StartCursorPosition;
                        Texto.SelectionColor = Texto.ForeColor;
                    }
                }
            }
        }
        private void colorearF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coloreando();
        }
        private void darFormatoF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dar_Formato();
        }
        private void Texto_TextChanged(object sender, EventArgs e)
        {
            Caracteres.Text = "Caracteres: " + Texto.TextLength;
            Lineas.Text = "Lineas: " + Texto.Lines.Count();
            MatchCollection Contar_Palabras = Regex.Matches(Texto.Text, @"[\W]+");
            Palabras.Text = "Palabras: " + Contar_Palabras.Count.ToString();
            if (Texto.TextLength > 0)
            {
                if (Texto.Text.Substring(0, 1) != " " && Texto.Text.Substring(Texto.TextLength - 1, 1) != " ")
                {
                    Palabras.Text = "Palabras: " + (Contar_Palabras.Count + 1);
                }
            }
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Black;
            temp = null;
            temp1 = null;
            Text = "Compilador Ñ - Sín título";
            Texto.Text = "INICIO\nFIN";
            name = dir = "";
        }
        private void AbrirButton_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }
        private void Guardar_ComoButton_Click(object sender, EventArgs e)
        {
            Guardar.Filter = "Archivo de código fuente[Ñ] (*.ñ)|*.ñ";
            Guardar.Title = "Guardar como...";
            Convertir_a_C_Sharp();
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter Escribir = new StreamWriter(Guardar.FileName))
                {
                    string[] texto = Texto.Text.Split('\n');
                    for (int i = 0; i < texto.GetLength(0); i++)
                    {
                        Escribir.WriteLine(texto[i]);
                    }
                }
            }
        }
        private void Guardar_TodoButton_Click(object sender, EventArgs e)
        {
            bool bb = true;
            Guardar.Title = "Guardar como...";
            Guardar.Filter = "Archivo de código fuente[Ñ] (*.ñ)|*.ñ";
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                string d = "",n ="";
                try
                {
                    string nombre = "\\" + Path.GetFileNameWithoutExtension(Guardar.FileName);
                    string direccion = Path.GetDirectoryName(Guardar.FileName);
                    Directory.CreateDirectory(direccion + nombre);
                    using (StreamWriter sw = new StreamWriter(direccion + nombre + nombre + ".ñ", false))
                    {
                        d = direccion + nombre;
                        n = nombre;
                        string[] lineas = Texto.Text.Split('\n');
                        for (int i = 0; i < lineas.Length; i++)
                            sw.WriteLine(lineas[i]);
                        sw.Close();
                    }
                }
                catch (Exception E)
                {
                    bb = false;
                    MessageBox.Show(E.ToString(), "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                if (bb)
                {
                    name = n;
                    dir = d;
                    this.Text = "Compilador Ñ - " + name;
                }
            }
        }

        private void Cortar_Button_Click(object sender, EventArgs e)
        {
            Texto.Cut();
        }
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Texto.Copy();
        }
        private void Pegar_Button_Click(object sender, EventArgs e)
        {
            Texto.Paste();
        }
        private void Deshacer_Button_Click(object sender, EventArgs e)
        {
            Texto.Undo();
        }
        private void Rehacer_Button_Click(object sender, EventArgs e)
        {
            Texto.Redo();
        }
        private void Depurar_Button_Click(object sender, EventArgs e)
        {
            Generar();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Comentario();
        }
        private void Formato_Button_Click(object sender, EventArgs e)
        {
            Dar_Formato();
        }
        private void Colorear_Button_Click(object sender, EventArgs e)
        {
            Coloreando();
        }
        private void Cortar(object sender, EventArgs e)
        {
            Texto.Cut();
        }
        private void Copiar(object sender, EventArgs e)
        {
            Texto.Copy();
        }
        private void Pegar(object sender, EventArgs e)
        {
            Texto.Paste();
        }
        private void Seleccionar(object sender, EventArgs e)
        {
            Texto.SelectAll();
        }
        private void Texto_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Windows.Forms.ContextMenu Menu_Texto = new System.Windows.Forms.ContextMenu();
                System.Windows.Forms.MenuItem Item = new System.Windows.Forms.MenuItem("Cortar");
                Item.Click += new EventHandler(Cortar);
                Menu_Texto.MenuItems.Add(Item);
                Item = new System.Windows.Forms.MenuItem("Copiar");
                Item.Click += new EventHandler(Copiar);
                Menu_Texto.MenuItems.Add(Item);
                Item = new System.Windows.Forms.MenuItem("Pegar");
                Item.Click += new EventHandler(Pegar);
                Menu_Texto.MenuItems.Add(Item);
                Item = new System.Windows.Forms.MenuItem("Seleccionar todo");
                Item.Click += new EventHandler(Seleccionar);
                Menu_Texto.MenuItems.Add(Item);
                Texto.ContextMenu = Menu_Texto;
            }
        }
        private void Texto_SelectionChanged_1(object sender, EventArgs e)
        {
            Posicion_Linea.Text = "Linea, " + (Texto.GetLineFromCharIndex(Texto.SelectionStart) + 1);
        }
        private void acercaDeÑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Información I = new Información();
            I.Show();
        }
        private void holaMundoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
        private void declaraciónDeVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Declaración de Variables";
            ej.Texto_Ejemplo.Text = "Para declarar una variable es muy sencillo.\n\nLo único que se tiene que saber son unas cuantas reglas, el tipo de dato y como se asigna valor.\n\nExisten 5 tipos de datos:\n═cadena - Almacena una gran cantidad de caracteres Unicode.\n═entero - Almacena hasta 10 digitos enteros.\n═doble - Almacena números con o sin punto\n═caracter - Almacena un caracter.\n═logico - Almacena valor true o false.\n\nPor ejemplo, un entero se declar así:\n\nentero i\nPara declarar con valor es así:\nentero i = 1\nPara declarar varios objetos del mismo tipo es así:\nentero j, i = 1\n\nPara declarar a un tipo de dato doble es así:\n\ndoble n = 5 (para usar decimales es así doble n1 = 5.5)\n\nPara asignar valor a un tipo de dato cadena es así:\n\ncadena p = \"Hola Mundo\\n\" (Se usan comillas dobles y dentro el valor)\n\nPara declarar un tipo de dato caracter es así:\n\ncaracter g = 'a'\n\nPara declarar un tipo de dato logico es así:\n\nlogico b = true\n\nReglas.\n\n1.-No se pueden declarar variables con caracteres especiales (*,/,[,},etc)\n2.-No se pueden declarar mas de una variable con el mismo nombre\n3.-No se pueden declarar varios tipos de datos en una linea (cadena j, entero i)\na menos que se use punto y coma en cada tipo de dato diferente\n\"entero i = 0; doble z = 5.5; cadena j\"";
        }
        private void másAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:\\Program Files\\Ñ\\Leeme Ñ.txt");
            }
            catch
            {
                MessageBox.Show("Borraste el archivo o no instalaste bien el programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void holaMundoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Hola Mundo";
            ej.Texto_Ejemplo.Text = "INICIO\nimprimir\"Hola Mundo\"\npausa\nFIN";
        }
        private void sumaDe2NúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Suma de 2 números";
            ej.Texto_Ejemplo.Text = "INICIO\ndoble a, b, c\nimprimir\"Ingresa número 1: \"\npedir doble a\nimprimir\"Ingresa número 2: \"\npedir doble b\nc = a + b;\nimprimir\"\\nLa suma de los 2 números es: \" + c\npausa\nFIN";
        }
        private void areaYPerimetroDeUnCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Area y Perimetro del Cuadrado";
            ej.Texto_Ejemplo.Text = "INICIO\ndoble lado, perimetro, area\nimprimir\"Ingresa el valor de un lado del cuadrado: \"\npedir doble lado\nperimetro = lado * 4;\narea = Mate.Pot(lado, 2);\nimprimir\"\\nEl perimetro del cuadrado es: \" + perimetro\nimprimir\"\\nEl área del cuadrado es: \" + area + \"\\n\"\npausa\nFIN";
        }
        private void colorDePantallaYLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Color de Pantalla y Letra";
            ej.Texto_Ejemplo.Text = "INICIO\npantalla blanca\nlimpiar\nletra negra\nimprimir\"Estoy en blanco y negro :v\\n\"\npantalla negra\nletra roja\nimprimir\"Presione una tecla para salir...\\n\"\nimprimir\"\\nNota* Si no se usa limpiar debajo de pantalla no se extenderá el color por\\ntoda la pantalla\"\npausa\nFIN";
        }
        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Colores definidos para Ñ";
            ej.Texto_Ejemplo.Text = "Para propiedades de pantalla y letra existen estos colores:\n\nverde\nverde oscuro\nrosa\nmorada\nazul\nazul oscuro\nnegra\naguamarina\nverde azulado\ngris\nblanca\namarilla\namarillo oscuro\nroja\ngris oscuro\nrojo oscuro\n\nSe usa así: pantalla/letra color, donde color puede ser cualquiera de los colores anteriores";
        }
        private void dibujarDiamanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Dibujar Diamante";
            ej.Texto_Ejemplo.Text = "INICIO\nTitulo \"Diamante\"\nentero tamaño\nimprimir\"Ingresa el tamaño del diamante: \"\npedir entero tamaño\nsi tamaño % 2 == 0\n{\n   tamaño++\n}\nentero contador = 1\npara entero i = 1; i <= tamaño;i++\n{\n   para entero j = 0;j < (tamaño - contador) / 2; j++\n   {\n      imprimir\" \"\n   }\n   para entero j = 0; j < contador; j++\n   {\n      imprimir\"*\"\n   }\n   si i < tamaño / 2 +1\n   {\n      contador+=2;\n   }\n   no\n   {\n      contador-=2;\n   }\n   imprimir   \"\\n\"\n}\npausa\nFIN";
        }
        private void pedirDatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos ej = new Ejemplos();
            ej.Show();
            ej.Text = "Pedir Datos";
            ej.Texto_Ejemplo.Text = "\"INICIO\nentero n\nimprimir\"Ingresa un número: \"\npedir entero n\nentero cuadrado = Mate.Pot(n, 2);\nimprimir\"\\nEl cuadrado del número es: \" + cuadrado\npausa\nFIN\"\n\nEse es un ejemplo el que se pide un dato.\nPara pedir de otro tipo de dato, solamente se sustituye entero por otro tipo de dato en la declaracion y en la\nlectura del dato.";
        }
    }
}
