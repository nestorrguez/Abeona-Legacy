using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGenCS
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (open.dir == "")
            {
                //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
                SaveFileDialog Save = new SaveFileDialog();
                System.IO.StreamWriter myStreamWriter = null;
                //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
                switch (to.lenprog)
                {
                    case 1:                      
                            Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cpp*)|*.cpp|Todos los archivos(*.*)|*.*";
                         break;

                    case 2:                        
                            Save.Filter = "Texto (*.txt)|*.txt|Codigo Fuente(*.cs*)|*.cs|Todos los archivos(*.*)|*.*";
                        break;

                }
                Save.CheckPathExists = true;
                Save.Title = "Guardar como";
                Save.ShowDialog(this);
                try
                {
                    //este codigo se utiliza para guardar el archivo de nuestro editor
                    myStreamWriter = System.IO.File.AppendText(Save.FileName);
                    myStreamWriter.Write(open.dire);
                    myStreamWriter.Flush();                   
                }
                catch (Exception) { }
                Application.Exit();
            }
            else
            {
                System.IO.StreamWriter myStreamWriter = null;
                myStreamWriter = System.IO.File.AppendText(open.dir);
                myStreamWriter.Write(open.dire);
                myStreamWriter.Flush();
            }
        }
    }
}
