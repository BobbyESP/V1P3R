using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace V1P3R
{
    /// <summary>
    /// Lógica de interacción para Frame.xaml
    /// </summary>
    public partial class Frame : Window
    {
        static public Frame loaderFrameRef;
        public Frame()
        {
            InitializeComponent();
            loaderFrameRef = loaderFrame;
            loaderFrameRef.Content = new Menus.Carga.Cargando();

            //Cargar Inicio
            loaderFrameRef.Content = new Menus.Inicio.Inicio();
        }
    }
}
