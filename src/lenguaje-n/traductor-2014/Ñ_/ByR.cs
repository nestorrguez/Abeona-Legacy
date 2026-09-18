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
    public partial class ByR : Form
    {
        public ByR()
        {
            InitializeComponent();
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            string s = Ñ.Formulario.Texto.Text;
            if (s != null & s != "")
            {
                if (s.Contains(Search.Text) & Replace.TextLength > 0 & Search.Text != null & Search.Text != "")
                {
                    s = s.Replace(Search.Text, Replace.Text);
                    Ñ.Formulario.Texto.Text = s;
                }
            }
            this.Close();
        }
    }
}
