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

namespace projeto_sgp_WPFversion
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
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

        private void btnControleGeralDeCadastros_Click(object sender, RoutedEventArgs e)
        {
            ControleGeralDeCadastros controleGeralDeCadastros = new ControleGeralDeCadastros();
            controleGeralDeCadastros.ShowDialog();
        }

        private void btnCaixaVenda_Click(object sender, RoutedEventArgs e)
        {
            Venda caixaVenda = new Venda();
            caixaVenda.ShowDialog();
        }

        private void btnControleGeralDeRelatorios_Click(object sender, RoutedEventArgs e)
        {
            ControleGeralDeRelatorios controleGeralDeRelatorios = new ControleGeralDeRelatorios();
            controleGeralDeRelatorios.ShowDialog();
        }

        private void btnDashboardDeFluxoDeCaixa_Click(object sender, RoutedEventArgs e)
        {
            DashboardDeFluxoDeCaixa dashboardDeFluxoDeCaixa = new DashboardDeFluxoDeCaixa();
            dashboardDeFluxoDeCaixa.ShowDialog();
        }

        private void btnControleDeContasAPagar_Click(object sender, RoutedEventArgs e)
        {
            Controlar_Contas_a_Pagar controlar_Contas_A_Pagar = new Controlar_Contas_a_Pagar();
            controlar_Contas_A_Pagar.ShowDialog();
        }

        private void btnControleDeEstoqueEVendas_Click(object sender, RoutedEventArgs e)
        {
            Controlar_Estoque_e_Vendas controlar_Estoque_E_Vendas = new Controlar_Estoque_e_Vendas();
            controlar_Estoque_E_Vendas.ShowDialog();
        }

        private void btnControleDeCaixaSebrae_Click(object sender, RoutedEventArgs e)
        {

            //System.Diagnostics.Process.Start(@"D:\Projetos .NET\projeto-sgp\Fluxo_de_Caixa_planilha.xlsx");
            MessageBox.Show("Arquivo indisponível no momento!", "ARQUIVO INDISPONÍVEL", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnControleDeCompras_Click(object sender, RoutedEventArgs e)
        {
            Controlar_Compras controlar_Compras = new Controlar_Compras();
            controlar_Compras.ShowDialog();
        }
    }
}
