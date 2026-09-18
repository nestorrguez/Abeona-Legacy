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
    public partial class colors : Form
    {
        string f, l, b, t;
        public colors()
        {
            InitializeComponent();
            f = l = b = t = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            f = "0";
            b = "Black";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f = "1";
            b = "DarkBlue";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f = "2";
            b = "DarkGreen";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            f = "3";
            b = "DarkCyan";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            f = "4";
            b = "DarkRed";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            f = "5";
            b = "DarkMagenta";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            f = "6";
            b = "DarkYellow";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            f = "7";
            b = "Gray";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            f = "8";
            b = "DarkGray";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            f = "9";
            b = "Blue";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

            f = "A";
            b = "Green";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            f = "B";
            b = "Cyan";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            f = "C";
            b = "Red";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            f = "D";
            b = "Magenta";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            f = "E";
            b = "Yellow";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            f = "F";
            b = "White";
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            l = "0";
            t = "Black";
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            l = "1";
            t = "DarkBlue";
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            l = "2";
            t = "DarkGreen";
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            l = "3";
            t = "DarkCyan";
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            l = "4";
            t = "DarkRed";
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            l = "5";
            t = "DarkMagenta";
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            l = "6";
            t = "DarkYellow";
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            l = "8";
            t = "DarkGray";
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            l = "7";
            t = "Gray";
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            l = "9";
            t = "Blue";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            l = "A";
            t = "Green";
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            l = "B";
            t = "Cyan";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            l = "C";
            t = "Red";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            l = "D";
            t = "Magenta";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            l = "E";
            t = "Yellow";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            l = "F";
            t = "White";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (to.lenprog)
            {
                case 1:
                    {
                        to.code = "system(" + (char)34 + "COLOR " + f + l + (char)34 + ");";
                    } break;
                case 2:
                    {
                        if (b != "" && t != "")
                        {
                            to.code = "Console.ForegroundColor = ConsoleColor." + t + ";" + "\r\n" + "Console.BackgroundColor = ConsoleColor." + b + ";";
                        }
                        else if (t != "")
                        {
                            to.code = "Console.ForegroundColor = ConsoleColor." + t + ";";
                        }
                        else if (b != "")
                        {
                            to.code = "Console.BackgroundColor = ConsoleColor." + b + ";";
                        }
                    } break;
            }
            Close();
        }
    }
}
