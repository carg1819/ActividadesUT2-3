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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ActividadesUT2_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked_OpA(object sender, RoutedEventArgs e)
        {    
            imgImagen.Opacity = 1;      
        }

        private void RadioButton_Checked2_OpM(object sender, RoutedEventArgs e)
        {
            imgImagen.Opacity = 0.6;
        }

        private void RadioButton_Checked3_OpB(object sender, RoutedEventArgs e)
        {
            imgImagen.Opacity = 0.3;
        }

        private void RadioButton_Checked_Fill(object sender, RoutedEventArgs e)
        {

            imgImagen.Stretch = Stretch.Fill;

        }

        private void RadioButton_Checked_Uniform(object sender, RoutedEventArgs e)
        {
            imgImagen.Stretch = Stretch.Uniform;
        }

        private void RadioButton_Checked_UniformToFill(object sender, RoutedEventArgs e)
        {
            imgImagen.Stretch = Stretch.UniformToFill;
        }

        private void RadioButton_Checked_None(object sender, RoutedEventArgs e)
        {
            imgImagen.Stretch = Stretch.None;
        }
    }
}
