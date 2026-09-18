using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = @"C:\Program Files\SeleneSoft\Abeona Tools\Code Generator";
            if (System.IO.File.Exists(@"C:\Program Files\SeleneSoft\Abeona Tools\Code Generator" + @"\all.cg"))
            {
                Console.WriteLine("Ya se han instalado " + x);
            }
            else
            {
                try
                {
                    FileAssociation.Associate(".cgp", "cgp.CGProjectFile", "Achivo de Proyecto de Code Generator", x + @"\project.ico", x + @"\CodeGen.exe");
                    FileAssociation.Associate(".cgv", "cgv.CGVariablesFile", "Achivo de Variables para proyecto de Code Generator", x + @"\variables.ico", x + @"\CodeGeneratorViewer.exe");
                    FileAssociation.Associate(".cgc", "cgc.CGCodeFile", "Achivo de Codigo para proyecto de Code Generator",x + @"\code.ico", x + @"\CodeGeneratorViewer.exe");
                    FileAssociation.Associate(".cg", "cg.CGConfigurationFile", "Achivo de Configuracion de Code Generator", x + @"\config.ico", x + @"\CodeGeneratorViewer.exe");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.ToString());
                }
                System.IO.File.Create(x + @"\all.cg");
                Console.WriteLine("Listo: " + System.IO.Directory.GetCurrentDirectory());
            }            
            System.Threading.Thread.Sleep(100);
        }
    }
    public class FileAssociation
    {
        // Associate file extension with progID, description, icon and application
        public static void Associate(string extension, string progID, string description, string icon, string application)
        {
            Registry.ClassesRoot.CreateSubKey(extension).SetValue("", progID);
            if (progID != null && progID.Length > 0)
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progID))
                {
                    if (description != null)
                        key.SetValue("", description);
                    if (icon != null)
                        key.CreateSubKey("DefaultIcon").SetValue("", ToShortPathName(icon));
                    if (application != null)
                        key.CreateSubKey(@"Shell\Open\Command").SetValue("",
                                    ToShortPathName(application) + " \"%1\"");
                }

        }

        // Return true if extension already associated in registry
        public static bool IsAssociated(string extension)
        {
            return (Registry.ClassesRoot.OpenSubKey(extension, false) != null);
        }

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath,
            [Out] StringBuilder lpszShortPath, uint cchBuffer);

        // Return short path format of a file name
        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            uint iRet = GetShortPathName(longName, s, iSize);
            return s.ToString();
        }
    }
}
