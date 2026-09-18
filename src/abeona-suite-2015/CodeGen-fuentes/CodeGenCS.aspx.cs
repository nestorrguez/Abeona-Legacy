using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeGenerator
{
    public class Clase
    {
        public static List<List<List<string>>> Var = new List<List<List<string>>>();
        public static int ActualClass;
    }

    public partial class CodeGenCS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = true;
            Comentario.Visible = false;
            Variables.Visible = false;
            Imprimir.Visible = false;
            PreFun.Visible = false;
            EstCon.Visible = false;
            Ciclos.Visible = false;
            Clases.Visible = false;
            Herramientas.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = false;
            Comentario.Visible = true;
            Variables.Visible = false;
            Imprimir.Visible = false;
            PreFun.Visible = false;
            EstCon.Visible = false;
            Ciclos.Visible = false;
            Clases.Visible = false;
            Herramientas.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        { 
            CuerpoPrograma.Visible = false;
            Comentario.Visible = false;
            Variables.Visible = true;
            Imprimir.Visible = false;
            PreFun.Visible = false;
            EstCon.Visible = false;
            Ciclos.Visible = false;
            Clases.Visible = false;
            Herramientas.Visible = false;
            Vars1.Items.Clear();
            if (Clase.Var[Clase.ActualClass].Count() > 1)
            {
                for (int c = 1; c < Clase.Var[Clase.ActualClass].Count(); c++)
                {
                    Vars1.Items.Add(Clase.Var[Clase.ActualClass][c][0]);
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = false;
            Comentario.Visible = false;
            Variables.Visible = false;
            Imprimir.Visible = true;
            PreFun.Visible = false;
            EstCon.Visible = false;
            Ciclos.Visible = false;
            Clases.Visible = false;
            Herramientas.Visible = false;
            if (Clase.Var[Clase.ActualClass].Count() > 1)
            {
                for (int c = 1; c < Clase.Var[Clase.ActualClass].Count(); c++)
                {
                    Vars2.Items.Add(Clase.Var[Clase.ActualClass][c][0]);
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = false;
            Comentario.Visible = false;
            Variables.Visible = false;
            Imprimir.Visible = false;
            PreFun.Visible = true;
            EstCon.Visible = false;
            Ciclos.Visible = false;
            Clases.Visible = false;
            Herramientas.Visible = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = false;
            Comentario.Visible = false;
            Variables.Visible = false;
            Imprimir.Visible = false;
            PreFun.Visible = false;
            EstCon.Visible = true;
            Ciclos.Visible = false;
            Clases.Visible = false;
            Herramientas.Visible = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = false;
            Comentario.Visible = false;
            Variables.Visible = false;
            Imprimir.Visible = false;
            PreFun.Visible = false;
            EstCon.Visible = false;
            Ciclos.Visible = true;
            Clases.Visible = false;
            Herramientas.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = false;
            Comentario.Visible = false;
            Variables.Visible = false;
            Imprimir.Visible = false;
            PreFun.Visible = false;
            EstCon.Visible = false;
            Ciclos.Visible = false;
            Clases.Visible = true;
            Herramientas.Visible = false;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != "")
            {
                TextBox1.Text += "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\n";
                TextBox1.Text += "\r\nnamespace " + TextBox2.Text.Replace(' ', '_') + "\r\n{\r\n";
                TextBox1.Text += "public class Program\r\n{\r\nvoid Main(string[] args)\r\n{\r\nConsole.Title = \"" + TextBox2.Text + "\";";
                List<string> temp1 = new List<string>();
                temp1.Add("Program");
                List<List<string>> temp2 = new List<List<string>>();
                temp2.Add(temp1);
                Clase.Var.Add(temp2);
                Clase.ActualClass = 0;
            }
            else
            {
                Response.Write("No se ha escrito el nombre del proyecto");
            }
            CuerpoPrograma.Visible = false;
        }

        protected void close_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "\r\n}\r\n}\r\n}";
            CuerpoPrograma.Visible = false;
        }

        protected void OK1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "\r\n//" + TextBox3.Text;
            Comentario.Visible = false;
        }

        protected void AddVar_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text != "")
            {
                string kind = "", name = "";
                if (_int.Checked)
                {
                    kind = "int";
                    name = TextBox4.Text;
                    TextBox4.Text = "";
                    Var(kind, name);
                }
                else if (_double.Checked)
                {
                    kind = "double";
                    name = TextBox4.Text;
                    TextBox4.Text = "";
                    Var(kind, name);
                }
                else if (_string.Checked)
                {
                    kind = "string";
                    name = TextBox4.Text;
                    TextBox4.Text = "";
                    Var(kind, name);
                }
                else if (_char.Checked)
                {
                    kind = "char";
                    name = TextBox4.Text;
                    TextBox4.Text = "";
                    Var(kind, name);
                }
                else
                {
                    Response.Write("No se ha elegido un tipo de dato");
                }
            }
            else
            {
                Response.Write("No se ha escrito el nombre de la variable");
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            CuerpoPrograma.Visible = false;
            Comentario.Visible = false;
            Variables.Visible = false;
            Imprimir.Visible = false;
            PreFun.Visible = false;
            EstCon.Visible = false;
            Ciclos.Visible = false;
            Clases.Visible = false;
            Herramientas.Visible = true;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            Clase.Var.Clear();
        }

        protected void In_Click(object sender, EventArgs e)
        {
            if (Clase.Var[Clase.ActualClass].Count() > 1)
            {
                for (int c = 1; c < Clase.Var[Clase.ActualClass].Count(); c++)
                {
                    if (Clase.Var[Clase.ActualClass][c][0] == Vars1.Items[Vars1.SelectedIndex].ToString() && Clase.Var[Clase.ActualClass][c][1] == "string")
                    {
                        TextBox1.Text += Vars1.Items[Vars1.SelectedIndex].ToString() + " = Console.WriteLine();";
                    }
                    else
                    {
                        Response.Write("En C# solo se puede usar variables tipo \"string\" para almacenar el dato de una linea");
                    }
                }
            }
        }

        protected void Declare_Click(object sender, EventArgs e)
        {
            string lol = Vars1.Items[Vars1.SelectedIndex].ToString();
            Variables.Visible = false;
            DeclareT.Visible = true;
            Label7.Text = lol;
        }

        protected void ConvertData_Click(object sender, EventArgs e)
        {

        }

        protected void OK2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Label7.Text + " = " + value1.Text + ";";
            value1.Text = "";
            DeclareT.Visible = false;
        }

        protected void OK3_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "Console.WriteLine(" + TextBox6.Text + ");"; 
        }

        protected void add_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text == "")
                TextBox6.Text = '"' + TextBox5.Text + '"';
            else
                TextBox6.Text += " + \"" + TextBox5.Text + "\"";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text == "")
                TextBox6.Text = Vars2.Items[Vars2.SelectedIndex].ToString();
            else
                TextBox6.Text += " + " + Vars2.Items[Vars2.SelectedIndex].ToString();
        }

        protected void Pause_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "\r\nConsole.ReadKey();";
            PreFun.Visible = false;
        }

        protected void Clear_Click1(object sender, EventArgs e)
        {
            TextBox1.Text += "\r\nConsole.Clear();";
            PreFun.Visible = false;
        }

        protected void Colors_Click(object sender, EventArgs e)
        {

        }

        protected void Sleep_Click(object sender, EventArgs e)
        {

        }

        void Var(string kind, string name)
        {
            List<string> level1 = new List<string>();
            if (name.Contains(","))
            {
                string[] arg = name.Split(',');
                for (int c = 0; c < arg.Count(); c++)
                {
                    level1.Add(arg[c]);
                    level1.Add(kind);
                    Clase.Var[Clase.ActualClass].Add(level1);
                }
                TextBox1.Text += "\r\n" + kind + " " + name + ";";
            }
            else
            {
                level1.Add(name);
                level1.Add(kind);
                Clase.Var[Clase.ActualClass].Add(level1);
                TextBox1.Text += "\r\n" + kind + " " + name + ";";
            }
        }
    }
}