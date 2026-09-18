using System;
using System.IO;
using System.Globalization;
using System.CodeDom.Compiler;
using System.Text;
using Microsoft.CSharp;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace CodeGenCS
{    
    public class Win32
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();
    }

    class Programa
    {
        public static string code, dir, comp, jl;
        public static void consol()
        {
            Console.Title = "Code Generator Pseudocodic-Console";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            string a;
            code = "";
            dir = code;
            comp = dir;
            Console.WriteLine("INGRESA LOS COMANDOS QUE DESEAS EJECUTAR");
            do
            {
                a = Console.ReadLine();
                doit(a);
            } while (!a.ToUpper().Contains("SALIR"));
            draw();
            System.Threading.Thread.Sleep(2000);
        }

        static void clear()
        {
            Console.Clear();
            Console.WriteLine("INGRESA LOS COMANDOS QUE DESEAS EJECUTAR");
        }
        static void doit(string s)
        {
            string l = "";
            string[] a = s.Split(' ');
            int b = a.Length;
            if (b > 2)
            {
                for (int c = 1; c < b; c++)
                {
                    l += " " + a[c];
                }
                action(a[0].ToUpper(), l);
            }
            else if (b == 1)
            {
                action(a[0].ToUpper(), "");
            }
            else
            {
                action(a[0].ToUpper(), a[1]);
            }
        }
        static void draw()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                          ");
            Console.WriteLine("                 ░▒▓▓▓▓▓▒░    ");
            Console.WriteLine("                ░▒▓▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("              ░▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("             ░▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("            ░▒▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("           ░▒▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("          ░▒▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("         ░▒▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("        ░▒▓▓▓▓▓▓▓▒░");
            Console.WriteLine("        ▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("        ▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("        ▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("        ▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("        ▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("        ░▒▓▓▓▓▓▓▓▒░");
            Console.WriteLine("         ░▒▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("          ░▒▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("           ░▒▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("            ░▒▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("             ░▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("              ░▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("                ░▒▓▓▓▓▓▓▓▓▓▓▒░");
            Console.WriteLine("                 ░▒▓▓▓▓▓▒░    ");
            Console.WriteLine("                          ");
            Console.WriteLine(" SSS SSS S   SSS S  S SSS SSS  SS  SSS SSS");
            Console.WriteLine(" S   S   S   S   S  S S   S   S  S S    S ");
            Console.WriteLine(" SSS SS  S   SS  SS S SS  SSS S  S SS   S ");
            Console.WriteLine("   S S   S   S   S SS S   S   S  S S    S ");
            Console.WriteLine(" SSS SSS SSS SSS S  S SSS S    SS  S    S ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Code Generator Console v2.0");
            Console.WriteLine("Version adaptada para su uso en Code Generator \"Visual\"");
            Console.WriteLine("Desarrollador: Néstor Rodríguez");
            Console.WriteLine("Ultima compilacion: 28 de Abril del 2014");
            Console.WriteLine("SeleneSoft ©2014");
            Console.WriteLine("Gracias por elegir nuestros productos");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("www.facebook.com/selenesoft");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("selenesoftware.blogspot.mx");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void action(string a, string b)
        {
            if (a == "IMPRIMIR")
            {
                code += "Console.Write(" + b + ");";
            }
            else if (a == "SI")
            {
                code += "if(" + b + ")\r\n{";
            }
            else if (a == "MIENTRAS")
            {
                code += "while(" + b + ")\r\n{";
            }
            else if (a == "H-MIENTRAS")
            {
                code += "}while(" + b + ");";
            }
            else if (a == "EN")
            {
                code += "for(" + b + ")\r\n";
            }
            else if (a == "PAUSA")
            {
                code += "Console.ReadKey(true);";
            }
            else if (a == "INICIO")
            {
                code += "using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\nnamespace ConsoleApp\r\n{\r\nclass Program\r\n{\r\nstatic void Main(string[] args)\r\n{";
            }
            else if (a == "FIN")
            {
                code += "\r\n}\r\n}\r\n}";
            }
            else if (a == "NO")
            {
                code += "else\r\n{";
            }
            else if (a == "HACER")
            {
                code += "do{";
            }
            else if (a == "PEDIR")
            {
                code += b + " = Console.ReadLine();";
            }
            else if (a == "LIMPIAR")
            {
                if (b == "PANTALLA")
                {
                    clear();
                }
                else
                {
                    code += "Console.CLEAR();";
                }
            }
            else if (a == "GUARDAR")
            {
                string f = System.IO.Directory.GetCurrentDirectory();
                Console.WriteLine("Guardar como: \r\n1.-Codigo Fuente (.cs)\r\n2.-Archivo de Texto (.txt)");
                int n = int.Parse(Console.ReadLine());
                int h=0;
                switch (n)
                {
                    case 1:
                        if (System.IO.File.Exists(f + @"\" + b + ".cs"))
                        {
                            do
                            {
                                h++;
                            } while (System.IO.File.Exists(f + @"\" + b + "_" + h + ".cs"));
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(f + @"\" + b + ".cs", true))
                            {
                                file.Write(code);
                            }
                            dir = f + @"\" + b + "_" + h + ".cs";
                            Console.WriteLine("ARCHIVO GUARDADO EN " + dir);
                        }
                        else
                        {
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(f + @"\" + b + ".cs", true))
                            {
                                file.Write(code);
                            }
                            dir = f + @"\" + b + ".cs";
                            Console.WriteLine("ARCHIVO GUARDADO EN " + dir);
                        }
                        break;
                    case 2:
                        if (System.IO.File.Exists(f + @"\" + b + ".txt"))
                        {
                            do
                            {
                                h++;
                            } while (System.IO.File.Exists(f + @"\" + b + "_" + h + ".txt"));
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(f + @"\" + b + ".txt", true))
                            {
                                file.Write(code);
                            }
                            dir = f + @"\" + b + "_" + h + ".txt";
                            Console.WriteLine("ARCHIVO GUARDADO EN " + dir);
                        }
                        else
                        {
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(f + @"\" + b + ".txt", true))
                            {
                                file.Write(code);
                            }
                            dir = f + @"\" + b + ".txt";
                            Console.WriteLine("ARCHIVO GUARDADO EN " + dir);
                        }
                        break;
                }
                jl = f + @"\" + b;
            }
            else if (a == "VER")
            {
                Console.WriteLine(code);
            }
            else if (a == "AYUDA")
            {
                Console.WriteLine("INICIO : ABRE EL PROGRAMA");
                Console.WriteLine("IMPRIMIR \"TEXTO A IMPRIMIR\" : ESCRIBE EL CODIGO PARA IMPRIMIR UN TEXTO");
                Console.WriteLine("SALTO : AGREGA UN SALTO DE LINEA");
                Console.WriteLine("SI \"CONDICION\" : ESCRIBE EL CODIGO PARA UNA ESTRUCTURA DE CONTROL SENCILLA");
                Console.WriteLine("NO : ES PARTE DE LA ESTRUCTURA \"SI\", ES PARA PONER UNA ACCION SI LA CONDICION NO SE CUMPLE");
                Console.WriteLine("MIENTRAS \"CONDICION\" : ESCRIBE EL CODIGO PARA EL CICLO \"WHILE\"");
                Console.WriteLine("HACER : ABRE EL CICLO \"DO-WHILE\"");
                Console.WriteLine("H-MIENTRAS \"CONDICION\" : CIERRA EL CICLO \"DO-WHILE\"");
                Console.WriteLine("EN \"CONDICION\": ABRE EL CICLO \"FOR\" NOTA: CADA PARTE DEL \"EN\" SE DIVIDE CON \";\" EXCEPTO LA ULTIMA, EJEMPLO: EN A=1;A<=10;A++");
                Console.WriteLine("PAUSA : ESCRIBE EL CODIGO PARA UNA PAUSA");
                Console.WriteLine("PEDIR \"NOMBRE DE LA VARIABLE\" : ESCRIBE EL CODIGO PARA PEDIR UNA VARIABLE");
                Console.WriteLine("LIMPIAR : ESCRIBE EL CODIGO PARA LIMPIAR LA PANTALLLA");
                Console.WriteLine("CERRAR: FINALIZA UNA ESTRUCTURA DE CONTROL O CICLO");
                Console.WriteLine("ROMPER : ESCRIBE EL CODIGO PARA CERRAR UN CASO O UN CICLO");
                Console.WriteLine("SEGUN \"VARIABLE A COMPARAR\" : ESCRIBE EL CODIGO DE UNA ESTRUCTURA DE CONTROL MULTIPLE");
                Console.WriteLine("CASO \"VALOR DEL CASO\" : ABRE UN CASO PARA UN \"SEGUN\", NOTA: SI SE TRATA DE UN CARACTER SE TIENE QUE PONER ENTRE DOS '");
                Console.WriteLine("ESPERAR \"TIEMPO EN NUMERO\" : ESCRIBE EL CODIGO PARA UNA PAUSA DE DETERMINADO TIEMPO EN CENTESIMAS");
                Console.WriteLine("USAR \"NOMBRE DE LA VARIABLE\" : DECLARA UNA VARIABLE PARA SU FUTURO USO");
                Console.WriteLine("USAR \"NOMBRE DE LA VARIABLE\" COMO \"TIPO DE DATO\" : DECLARA UNA VARIABLE PARA SU FUTURO USO Y EL TIPO DE DATO QUE ALMACENARA");
                Console.WriteLine("//TIPOS DE DATOS: ");
                Console.WriteLine("//ENTERO: ALMACENA NUMERO SIN SIGNO");
                Console.WriteLine("//DOBLE: ALMACENA NUMERO CON SIGNO");
                Console.WriteLine("//CADENA: ALMACENA UNA CADENA DE CARACTERES");
                Console.WriteLine("//CARACTER: ALMACENA UN CARACTER");
                Console.WriteLine("DECLARAR \"NOMBRE DE LA VARIABLE Y SU VALOR\" : SIRVE PARA DECLARAR EL VALOR DE UNA VARIABLE");
                Console.WriteLine("FIN : CIERRA EL PROGRAMA");
                Console.WriteLine("LIMPIAR PANTALLA : LIMPIA LA PANTALLA DE \"CODE GENERATOR CONSOLE\"");
                Console.WriteLine("GUARDAR \"NOMBRE DEL ARCHIVO SIN ESPACIOS\": APARECEN OPCIONES PARA GUARDAR EL CODIGO ESCRITO EN UN ARCHIVO");
                Console.WriteLine("VER : APARECE EL CODIGO QUE SE HA GENERADO HASTA EL MOMENTO");
                Console.WriteLine("REINICIAR : BORRA EL CODIGO Y EL CONTENIDO DE LA PANTALLA");
                Console.WriteLine("COMPILAR : COMPILA EL ARCHIVO FUENTE YA GUARDADO");
                Console.WriteLine("ABRIR : ABRE EL EJECUTABLE YA COMPILADO");
                Console.WriteLine("AYUDA : MUESTRA LOS COMANDOS Y LA DESCRIPCION DE CADA UNO");
                Console.WriteLine("ACERCADE : ABRE LA INFORMACION DE \"CODE GENERATOR CONSOLE\"");
                Console.WriteLine("SALIR : CIERRRA \"CODE GENERATOR CONSOLE\"");
                Console.WriteLine("NOTA: SOLO CUANDO SE DESEEN ESCRIBIR TEXTO UTILIZE LAS \", DE LO CONTRARIO NO LAS USE");
            }
            else if (a == "CERRAR")
            {
                code += "\r\n}";
            }
            else if (a == "SALTO")
            {
                code += "Console.WriteLine(\"\"" + " );";
            }
            else if (a == "SEGUN")
            {
                code += "SWITCH(" + b + ")\r\n{";
            }
            else if (a == "CASO")
            {
                code += "case " + b + ":";
            }
            else if (a == "ROMPER")
            {
                code += "break;";
            }
            else if (a == "ACERCADE")
            {
                draw();
            }
            else if (a == "USAR")
            {
                string[] k = b.Split((char)32);
                int v = k.Length;
                if (b.ToUpper().Contains("COMO"))
                {
                    if (b.ToUpper().Contains("ENTERO"))
                        code += "int " + k[1] + ";";
                    else if (b.ToUpper().Contains("DOBLE"))
                        code += "doble " + k[1] + ";";
                    else if (b.ToUpper().Contains("CADENA"))
                        code += "string " + k[1] + ";";
                    else if (b.ToUpper().Contains("CARACTER"))
                        code += "char " + k[1] + ";";
                    else if (b.ToUpper().Contains("FLOTANTE"))
                        code += "float " + k[1] + ";";
                    else
                        code += "var " + k[1] + ";";
                }
                else
                {
                    code += "var " + b + ";";
                }

            }
            else if (a == "DECLARAR")
            {
                code += b + ";";
            }
            else if (a == "ESPERAR")
            {
                code += "System.Threading.Thread.Sleep(" + b + ");";
            }
            else if (a == "REINICIAR")
            {
                Console.Clear();
                code = "";
                Console.WriteLine("INGRESA LOS COMANDOS QUE DESEAS EJECUTAR");
            }
            else if (a == "ABRIR")
            {
                if (dir != "" && comp != "")
                {
                    if (System.IO.File.Exists(jl + "_cs.exe"))
                    {
                        System.Diagnostics.Process.Start(jl + "_cs.exe");
                    }
                    else
                        Console.WriteLine("Programa no encontrado");
                }
                else
                {
                    Console.WriteLine("El codigo aun no se a compilado");
                }
            }
            else if (a == "ENVIAR")
            {
                to.code = code;
                Console.WriteLine("Codigo enviado");
            }
            else if (a == "COMPILAR")
            {
                if (dir != "")
                {
                    to.compile = false;
                    if (System.IO.File.Exists(dir))
                    {
                        compiler.Compile(dir);
                    }
                    comp = "1";
                }
                else
                {
                    Console.WriteLine("Necesitas guardar el codigo primero");
                }
            }
            else if (a == "SALIR") { }
            else
            {
                Console.WriteLine("COMANDO NO RECONOCIDO, ESCRIBA \"AYUDA\" PARA VER LOS COMANDOS");
            }
            code += "\r\n";
        }

    }
    class compiler
    {
        public static string an;
        public static void Compile(string input)
        {
            if (to.compile == true)
            {
                if (CompileExecutable(input))
                {
                    System.Diagnostics.Process.Start(an);
                }
            }
            else
            {
                CompileExecutable(input);
            }
        }

        public static bool CompileExecutable(String sourceName)
        {
            FileInfo sourceFile = new FileInfo(sourceName);
            CodeDomProvider provider = null;
            bool compileOk = false;

            // Select the code provider based on the input file extension.
            if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
            {
                provider = CodeDomProvider.CreateProvider("CSharp");
            }
            else if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".VB")
            {
                provider = CodeDomProvider.CreateProvider("VisualBasic");
            }
            else
            {
                Console.WriteLine("El archivo debe tener extension .cs o .vb");
            }

            if (provider != null)
            {

                // Format the executable file name.
                // Build the output assembly path using the current directory
                // and <source>_cs.exe or <source>_vb.exe.

                String exeName = String.Format(@"{0}\{1}.exe",
                    System.Environment.CurrentDirectory,
                    sourceFile.Name.Replace(".", "_"));
                an = exeName;
                CompilerParameters cp = new CompilerParameters();

                // Generate an executable instead of 
                // a class library.
                cp.GenerateExecutable = true;

                // Specify the assembly file name to generate.
                cp.OutputAssembly = exeName;

                // Save the assembly as a physical file.
                cp.GenerateInMemory = false;

                // Set whether to treat all warnings as errors.
                cp.TreatWarningsAsErrors = false;

                // Invoke compilation of the source file.
                CompilerResults cr = provider.CompileAssemblyFromFile(cp,
                    sourceName);

                if (cr.Errors.Count > 0)
                {
                    // Display compilation errors.
                    Console.WriteLine("Error de ensamblaje {0} en {1}.",
                        sourceName, cr.PathToAssembly);
                    foreach (CompilerError ce in cr.Errors)
                    {
                        Console.WriteLine("  {0}", ce.ToString());
                        Console.WriteLine();
                    }
                }
                else
                {
                    // Display a successful compilation message.
                    Console.WriteLine("Se ha finalizado el ensamblaje de {0} en {1}.",
                        sourceName, cr.PathToAssembly);
                }

                // Return the results of the compilation.
                if (cr.Errors.Count > 0)
                {
                    compileOk = false;
                }
                else
                {
                    compileOk = true;
                }
            }
            return compileOk;
        }
    }
}


