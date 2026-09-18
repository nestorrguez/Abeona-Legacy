using System;
using System.IO;
using System.Globalization;
using System.CodeDom.Compiler;
using System.Text;
using Microsoft.CSharp;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace CodeGenCS
{
    public partial class debugger : Form
    {
        public static string s = "\r\n", wrong;
        public debugger()
        {
            InitializeComponent();
            wrongs.ReadOnly = true;
            start(Form1.b);
            wrongs.Clear();
            wrongs.Text = wrong;
        }
        public void start(string input)
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
                wrong += s + "El archivo debe tener extension .cs o .vb";
            }

            if (provider != null)
            {

                // Format the executable file name.
                // Build the output assembly path using the current directory
                // and <source>_cs.exe or <source>_vb.exe.

                String exeName = String.Format(@"{0}\{1}.exe",
                    Proyect.expt,
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
                    wrong += s + "Error de ensamblaje " + sourceName + " en " + cr.PathToAssembly + ".";
                    foreach (CompilerError ce in cr.Errors)
                    {
                        wrong += s + ce.ToString();                        
                    }
                }
                else
                {
                    // Display a successful compilation message.
                    wrong += s + "Se ha finalizado el ensamblaje de " + sourceName + " en " + cr.PathToAssembly + ".";
                         
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
