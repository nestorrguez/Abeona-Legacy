using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGenCPP
{
    public partial class objets : Form
    {
        public objets()
        {
            InitializeComponent();
            if (open.lib == true && open.close == false)
                button2.Enabled = true;
            else
                button2.Enabled = false;
            
            System.Object[] ItemObject = new System.Object[440];
            for (int g = 1; g <= claz.numclass; g++)
            {
                if (claz.variables[0, g].Contains("()"))
                {
                    ItemObject[g] = claz.variables[0, g];
                    comboBox1.Items.Add(ItemObject[g]);
                }
            }
         }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }       

        private void button6_Click(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            funt form = new funt();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        { }
        

        private void button1_Click(object sender, EventArgs e)
        { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                to.code = comboBox1.Text;
                Close();
            }
            else
            {
                open.window("Atencion", "Debes elegir un metodo primero", true);
            }
        }
    }
}
