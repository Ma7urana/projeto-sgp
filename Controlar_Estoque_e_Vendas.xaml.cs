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
    /// Lógica interna para Controlar_Estoque_e_Vendas.xaml
    /// </summary>
    public partial class Controlar_Estoque_e_Vendas : Window
    {
        public Controlar_Estoque_e_Vendas()
        {
            InitializeComponent();
        }
        private void tela_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
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

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Tela_cancel tela_Cancel = new Tela_cancel();
            tela_Cancel.ShowDialog();

        }

        private void btnReadVendas_Click(object sender, RoutedEventArgs e)
        {
            this.fr_EstoqueVendas.NavigationService.Navigate(new ReadVendas());
        }

        private void btnReadProdutos_Click(object sender, RoutedEventArgs e)
        {
            this.fr_EstoqueVendas.NavigationService.Navigate(new ReadProdutos());
        }
    }
}
