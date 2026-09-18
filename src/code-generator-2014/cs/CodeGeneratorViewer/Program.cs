using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeGeneratorViewer
{
    class Program
    {
        public static string arg;
        static void Main(string[] args)
        {
            arg = Environment.GetCommandLineArgs()[0];
            Console.Title = "Code Generator File Viewer";            
            if(arg.Contains(".exe"))
            {}
            else
            {
                using (StreamReader rd = new StreamReader(arg))
                {
                    Console.Write(rd.ReadToEnd().ToString());
                }
            }
            Console.ReadKey(true);
        }
    }
}
