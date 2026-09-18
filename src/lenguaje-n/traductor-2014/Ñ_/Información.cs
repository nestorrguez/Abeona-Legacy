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
    public partial class Información : Form
    {
        public Información()
        {
            InitializeComponent();
        }
        private void Información_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wwww.facebook.com/selenesoft");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\"+Environment.SpecialFolder.ProgramFilesX86+@"\SeleneSoft\Abeona Studio\Compiler\Ñ"))
            {
                System.Diagnostics.Process.Start(@"C:\" + Environment.SpecialFolder.ProgramFilesX86 + @"\SeleneSoft\Abeona Studio\Compiler\Ñ\leeme.txt");
            }
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(@"C:\" + Environment.SpecialFolder.ProgramFiles + @"\SeleneSoft\Abeona Studio\Compiler\Ñ\leeme.txt");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontro archivo leeme.txt");
                }
            }
        }
    }
}
