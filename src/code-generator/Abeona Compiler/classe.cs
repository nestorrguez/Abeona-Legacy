using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class classe : Form
    {
        int b=0;
        public classe()
        {
            InitializeComponent();           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Box.Clear();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Box.Focus();
            Box.SelectAll();
            Box.Copy();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            open.comentary();
        }

        private void cerrarCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Text = "}";
            cerrarCicloToolStripMenuItem.Enabled = false;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            open.about();
        }

        private void nuevaVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c;
            for (c = 1; c < key.cn; c++)
            {
                string a="public static class " + key.clas[c,0];
                if (Box.Text.Contains(a))
                {
                    break;                    
                }
            }
            key.v = c;
            var form = new var();
            form.Show();
        }

        private void nuevaFuncionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c;
            for (c = 1; c < key.cn; c++)
            {
                string a = "public static class " + key.clas[c, 0];
                if (Box.Text.Contains(a))
                {
                    break;
                }
            }
            key.v = c;
            funt form = new funt();
            form.Show();
        }
    }
}
