using System;

public class ÑL
{
    public static string toCS(string line)
    {
        string a, b, code="";
        string[] div = line.Split(' ');
        if (div.Length < 2)
        {
            a = div[0];
            b = "";
        }
        else if (div.Length == 2)
        {
            a = div[0];
            b = div[1];
        }
        else
        {
            string lol = "";
            for (int c = 1; c < div.Length; c++)
            {
                lol += div[c];
            }
            a = div[0];
            b = lol;
        }
    
        if (a == "IMPRIMIR")
        {
            code = "Console.Write(" + b + ");\r\n";
        }
        else if (a == "SI")
        {
            code = "if(" + b + ")\r\n{\r\n";
        }
        else if (a == "MIENTRAS")
        {
            code = "while(" + b + ")\r\n{\r\n";
        }
        else if (a == "H-MIENTRAS")
        {
            code = "}while(" + b + ");\r\n";
        }
        else if (a == "EN")
        {
            code = "for(" + b + ")\r\n{\r\n";
        }
        else if (a == "PAUSA")
        {
            code = "Console.ReadKey(true);\r\n";
        }
        else if (a == "INICIO")
        {
            code = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\nnamespace ConsoleApp\r\n{\r\nclass Program\r\n{\r\nstatic void Main(string[] args)\r\n{\r\n";
        }
        else if (a == "FIN")
        {
            code = "\r\n}\r\n}\r\n}\r\n";
        }
        else if (a == "NO")
        {
            code = "else\r\n{\r\n";
        }
        else if (a == "HACER")
        {
            code = "do{\r\n";
        }
        else if (a == "PEDIR")
        {
            code = b + " = Console.ReadLine();\r\n";
        }
        else if (a == "LIMPIAR")
        {
            code = "Console.CLEAR();\r\n";
        }
        else if (a == "CERRAR")
        {
            code = "\r\n}\r\n";
        }
        else if (a == "SALTO")
        {
            code = "Console.WriteLine(\"\"" + " );\r\n";
        }
        else if (a == "SEGUN")
        {
            code = "SWITCH(" + b + ")\r\n{\r\n";
        }
        else if (a == "CASO")
        {
            code = "case " + b + ":\r\n";
        }
        else if (a == "ROMPER")
        {
            code = "break;\r\n";
        }
        else if (a.ToUpper() == "CONVERTIR")
        {
            string a1, a2, a3;
            //Convertir a en cadena guardar b
            string[] l = b.Split(' ');
            a1 = l[1];
            a2 = l[3];
            a3 = l[5];
            if (a2.ToUpper() == "ENTERO")
            {
                code = a3 + " = Convert.ToInt32(" + a1 + ");\r\n";
            }
            else if (a2.ToUpper() == "DOBLE")
            {
                code = a3 + " = Convert.ToDouble(" + a1 + ");\r\n";
            }
            else if (a2.ToUpper() == "CADENA")
            {
                code = a3 + " = " + a1 + ".ToString();\r\n";
            }
        }
        else if (a.ToUpper() == "FONDOC")
        {
            switch (b.ToUpper())
            {
                case "NEGRO":
                    code = "Console.BackgroundColor = ConsoleColor.Black;\r\n";
                    break;
                case "AZUL":
                    code = "Console.BackgroundColor = ConsoleColor.Blue;\r\n";
                    break;
                case "CIAN":
                    code = "Console.BackgroundColor = ConsoleColor.Cyan;\r\n";
                    break;
                case "AZULOSCURO":
                    code = "Console.BackgroundColor = ConsoleColor.DarkBlue;\r\n";
                    break;
                case "CIANOSCURO":
                    code = "Console.BackgroundColor = ConsoleColor.DarkCyan;\r\n";
                    break;
                case "GRISOSCURO":
                    code = "Console.BackgroundColor = ConsoleColor.DarkGray;\r\n";
                    break;
                case "VERDEOSCURO":
                    code = "Console.BackgroundColor = ConsoleColor.DarkGreen;\r\n";
                    break;
                case "MAGENTAOSCURO":
                    code = "Console.BackgroundColor = ConsoleColor.DarkMagenta;\r\n";
                    break;
                case "ROJOOSCURO":
                    code = "Console.BackgroundColor = ConsoleColor.DarkRed;\r\n";
                    break;
                case "AMARILLOOSCURO":
                    code = "Console.BackgroundColor = ConsoleColor.DarkYellow;\r\n";
                    break;
                case "GRIS":
                    code = "Console.BackgroundColor = ConsoleColor.Gray;\r\n";
                    break;
                case "VERDE":
                    code = "Console.BackgroundColor = ConsoleColor.Green;\r\n";
                    break;
                case "MAGENTA":
                    code = "Console.BackgroundColor = ConsoleColor.Magenta;\r\n";
                    break;
                case "ROJO":
                    code = "Console.BackgroundColor = ConsoleColor.Red;\r\n";
                    break;
                case "BLANCO":
                    code = "Console.BackgroundColor = ConsoleColor.White;\r\n";
                    break;
                case "AMARILLO":
                    code = "Console.BackgroundColor = ConsoleColor.Yellow;\r\n";
                    break;
            }
        }
        else if (a.ToUpper() == "LETRAC")
        {
            switch (b.ToUpper())
            {
                case "NEGRO":
                    code = "Console.ForegroundColor = ConsoleColor.Black;\r\n";
                    break;
                case "AZUL":
                    code = "Console.ForegroundColor = ConsoleColor.Blue;\r\n";
                    break;
                case "CIAN":
                    code = "Console.ForegroundColor = ConsoleColor.Cyan;\r\n";
                    break;
                case "AZULOSCURO":
                    code = "Console.ForegroundColor = ConsoleColor.DarkBlue;\r\n";
                    break;
                case "CIANOSCURO":
                    code = "Console.ForegroundColor = ConsoleColor.DarkCyan;\r\n";
                    break;
                case "GRISOSCURO":
                    code = "Console.ForegroundColor = ConsoleColor.DarkGray;\r\n";
                    break;
                case "VERDEOSCURO":
                    code = "Console.ForegroundColor = ConsoleColor.DarkGreen;\r\n";
                    break;
                case "MAGENTAOSCURO":
                    code = "Console.ForegroundColor = ConsoleColor.DarkMagenta;\r\n";
                    break;
                case "ROJOOSCURO":
                    code = "Console.ForegroundColor = ConsoleColor.DarkRed;\r\n";
                    break;
                case "AMARILLOOSCURO":
                    code = "Console.ForegroundColor = ConsoleColor.DarkYellow;\r\n";
                    break;
                case "GRIS":
                    code = "Console.ForegroundColor = ConsoleColor.Gray;\r\n";
                    break;
                case "VERDE":
                    code = "Console.ForegroundColor = ConsoleColor.Green;\r\n";
                    break;
                case "MAGENTA":
                    code = "Console.ForegroundColor = ConsoleColor.Magenta;\r\n";
                    break;
                case "ROJO":
                    code = "Console.ForegroundColor = ConsoleColor.Red;\r\n";
                    break;
                case "BLANCO":
                    code = "Console.ForegroundColor = ConsoleColor.White;\r\n";
                    break;
                case "AMARILLO":
                    code = "Console.ForegroundColor = ConsoleColor.Yellow;\r\n";
                    break;
            }
        }
        else if (a == "USAR")
        {
            string[] k = b.Split((char)32);
            if (b.ToUpper().Contains("COMO"))
            {
                if (b.ToUpper().Contains("ENTERO"))
                    code = "int " + k[1] + ";\r\n";
                else if (b.ToUpper().Contains("DOBLE"))
                    code = "double " + k[1] + ";\r\n";
                else if (b.ToUpper().Contains("CADENA"))
                    code = "string " + k[1] + ";\r\n";
                else if (b.ToUpper().Contains("CARACTER"))
                    code = "char " + k[1] + ";\r\n";
                else if (b.ToUpper().Contains("FLOTANTE"))
                    code = "float " + k[1] + ";\r\n";
                else if (b.ToUpper().Contains("DECIMAL"))
                    code = "decimal " + k[1] + ";\r\n";
                else if (b.ToUpper().Contains("BOOL") || b.ToUpper().Contains("BOOLEANO") || b.ToUpper().Contains("LOGICO"))
                    code = "bool " + k[1] + ";\r\n";
                else
                {
                    code = "var " + k[1] + ";\r\n";
                }
            }
            else
            {
                code = "var " + b + ";\r\n";
            }
        }
        else if (a == "DECLARAR")
        {
            code = b + ";\r\n";
        }
        else if (a == "ESPERAR")
        {
            code = "System.Threading.Thread.Sleep(" + b + ");\r\n";
        }
        else if (a == "CÑ: ")
        {
            code = "//" + b + "\r\n";
        }
        return code;
    }
}
