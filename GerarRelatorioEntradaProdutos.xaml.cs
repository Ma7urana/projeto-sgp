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

namespace projeto_sgp_WPFversion
{
    /// <summary>
    /// Interaction logic for GerarRelatorioEntradaProdutos.xaml
    /// </summary>
    public partial class GerarRelatorioEntradaProdutos : Window
    {
        public GerarRelatorioEntradaProdutos()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void tela_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        private void saida(object sender, RoutedEventArgs e)
        {
            GerarRelatorioSaidaProdutos rsaida = new GerarRelatorioSaidaProdutos();
            rsaida.ShowDialog();
        }
    }
}
