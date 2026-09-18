using Microsoft.Windows.Controls.Ribbon;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;

namespace Compilador_Ñ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public static Color Base = Color.Black, Reserved = Color.Blue, ReservedA = Color.DarkBlue;
        public static bool lol = false;
        public static string IDEFolder;
        public static string ProjectTitle;
        string temp = "";
        public MainWindow()
        {
            if (MessageBox.Show("Esta es solo una versión demostrativa del lenguaje Ñ. Espere las actualizaciones\n¿Deseas iniciar la aplicación de todos modos?", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)            
                InitializeComponent();            
            else
                Application.Current.Shutdown();
        }
    }
}
