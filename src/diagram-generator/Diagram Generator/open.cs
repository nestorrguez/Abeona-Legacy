using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagram_Generator
{
    class open
    {
       public static string title;
       public static string text;
       public static bool multi;
       public static int code;
       public static string messenger;

       public static void write(string a,string b, bool c)
       {
           open.title = a;
           open.text = b;
           open.multi = c;
           Form2 form = new Form2();
           form.Show();
       }
    }
}
