using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiagramGen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    static class Type
    {
        public static string Startend = "startend";
        public static string Out = "output";
        public static string Square = "square";
        public static string In = "input";
        public static string Condition = "condition";
        public static string For = "for";
    }
}
