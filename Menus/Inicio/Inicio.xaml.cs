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

namespace V1P3R.Menus.Inicio
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void videoBackground_Loaded(object sender, RoutedEventArgs e)
        {
            videoBackground.Play();
        }

        private void videoBackground_MediaEnded(object sender, RoutedEventArgs e)
        {
            videoBackground.Position = TimeSpan.FromSeconds(0);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            videoContainer.Source = new Uri("https://502.wtf/ValorScrimMike/resources/homeVideo.mp4", UriKind.Absolute);
        }
    }
}
