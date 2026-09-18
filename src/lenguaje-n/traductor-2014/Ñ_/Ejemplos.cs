using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompÑ
{
    public partial class Ejemplos : Form
    {
        public Ejemplos()
        {
            InitializeComponent();
        }
        private void Copiar_Click(object sender, EventArgs e)
        {
            Texto_Ejemplo.SelectAll();
            Texto_Ejemplo.Copy();
            Texto_Ejemplo.DeselectAll();
        }
    }
}
