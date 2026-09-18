using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenCS
{
    class to
    {
        public static string code;
        public static int lenprog;
        public static int language;
        public static int nm;
        public static int line;
        public static string paste;
        public static string tab;
        public static bool compile;
        public static string[,] varinfo = new string[440, 4];
        public static void addvar(string a, string b, string c, string d)
        {
            varinfo[line, 0] = a;
            varinfo[line, 1] = b;
            varinfo[line, 2] = c;
            varinfo[line, 3] = d;
            line++;
        }
    }
}
