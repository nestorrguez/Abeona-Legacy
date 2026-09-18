using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeleneSoftLib.BD;

namespace Compilador_Ñ
{
    public partial class BugReporter : Form
    {
        public BugReporter()
        {
            InitializeComponent();
            textBox4.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0)
            {
                textBox3.Text = "";
            }
            textBox3.Text = ((AssemblyProductAttribute)attributes[0]).Product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ing = true;
            try
            {
                SeleneSoftLib.BD.MSSQL BD = new SeleneSoftLib.BD.MSSQL("<CADENA DE CONEXIÓN ELIMINADA DEL ARCHIVO HISTÓRICO>");
                BD.Comando("INSERT INTO [<BASE DE DATOS ELIMINADA>].[dbo].[BugReports](Nombre,Correo,Programa,Version,Descripcion,Fecha) VALUES('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "','" + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + "')");
            }
            catch (Exception)
            {
                ing = false;
            }

            if (ing)
                MessageBox.Show("Hemos recibido tu mensaje, muy pronto atenderemos lanzaremos una nueva versión corrigiendo los errores que nos enviaste", "Gracias por tu mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hubo un problema desconocido al enviar el mensaje", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
