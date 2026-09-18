using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;
using System.CodeDom.Compiler;
using System.Text;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Compilador_Ñ
{
    public class Compiler
    {

        static string ErrorTranslator(string issue)
        {
            string[] s = issue.Split('|');
            string e = "";
            for (int c = 1; c < s.Length; c++)            
                e += sub(s[c]) + "\n";            
            return e;
        }

        static string sub(string issue)
        {
            if (issue != "")
            {
                int a = 0, b = 0;
                string[] ls = issue.Split(':');
                for (int c = 0; c < issue.Length; c++)
                {
                    if (issue[c] == '(')
                        a = c + 1;
                    else if (issue[c] == ')')
                        b = c;
                }
                string[] n = issue.Substring(a, b - a).Split(',');
                int l = int.Parse(n[0]) - 7;
                return "Error en la linea " + l + ": " + ls[ls.Length - 1].Replace("}","un cierre");
            }
            else
                return "";
        }

        public static void CompileExecutable(string Code, string Dir, string name, string Ext)
        {
            bool lel = true;
            String exeName = "";
            try
            {
                lel = true;
                string sourceName = Dir + "\\" + name + Ext;
                string Issues = "";
                int IssuesCount = 0;
                using (System.IO.StreamWriter SW = new StreamWriter(sourceName))
                {
                    SW.Write(Code);
                    SW.Close();
                }
                FileInfo sourceFile = new FileInfo(sourceName);
                CodeDomProvider provider = null;
                // Select the code provider based on the input file extension.                
                if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
                {
                    provider = CodeDomProvider.CreateProvider("CSharp");
                    exeName = String.Format(@"{0}\{1}.exe", Dir + "\\", sourceFile.Name.Replace(".cs", ""));

                }
                else if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".VB")
                {
                    provider = CodeDomProvider.CreateProvider("VisualBasic");
                    exeName = String.Format(@"{0}\{1}.exe", Dir + "\\", sourceFile.Name.Replace(".vb", ""));
                }
                else
                {
                    MessageBox.Show("Source file must have a .cs or .vb extension");
                }
                if (provider != null)
                {
                    // Format the executable file name.
                    // Build the output assembly path using the current directory
                    // and <source>_cs.exe or <source>_vb.exe.
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
                    CompilerResults cr = provider.CompileAssemblyFromFile(cp, sourceName);
                    IssuesCount = cr.Errors.Count;
                    if (cr.Errors.Count > 0)
                    {
                        // Display compilation errors.
                        //Console.WriteLine("Errors building {0} into {1}", sourceName, cr.PathToAssembly);
                        foreach (CompilerError ce in cr.Errors)
                        {
                            MessageBox.Show(ce.ToString());
                            Issues += "|" + ce.ToString();
                        }
                        lel = false;
                        MessageBox.Show("Hubo un error al momento de generar el ejecutable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ErrorTranslator(Issues), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Programa compilado sin errores", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var result = MessageBox.Show("¿Deseas ejecutarlo?", name + ".exe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(exeName);
                        }
                    }
                }
            }
            catch (Exception E)
            {
                lel = false;
                MessageBox.Show("Hubo un error al momento de generar el ejecutable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(E.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}