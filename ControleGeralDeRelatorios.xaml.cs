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
    /// Lógica interna para ControleGeralDeRelatorios.xaml
    /// </summary>
    public partial class ControleGeralDeRelatorios : Window
    {
        public ControleGeralDeRelatorios()
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

        private void btnRelatoriosPorVendedores_Click(object sender, RoutedEventArgs e)
        {
            Relatórios_Vendedores relatórios_Vendedores = new Relatórios_Vendedores();
            relatórios_Vendedores.ShowDialog();
        }

        private void btnRelVendedorValor_Click(object sender, RoutedEventArgs e)
        {
            Relatorio_vendedor_valor relatorio_Vendedor_Valor = new Relatorio_vendedor_valor();
            relatorio_Vendedor_Valor.ShowDialog();
        }

        private void btnRelVendedorProduto_Click(object sender, RoutedEventArgs e)
        {
            Relatorio_vendedor_produto relatorio_Vendedor_Produto = new Relatorio_vendedor_produto();
            relatorio_Vendedor_Produto.ShowDialog();
        }

        private void btnRelDestaqueMes_Click(object sender, RoutedEventArgs e)
        {
            Relatorio_destaque_mes relatorio_Destaque_Mes = new Relatorio_destaque_mes();
            relatorio_Destaque_Mes.ShowDialog();
        }

        private void btnRelDashboardMes_Click(object sender, RoutedEventArgs e)
        {
            Relatorio_dashboard_mes relatorio_Dashboard_Mes = new Relatorio_dashboard_mes();
            relatorio_Dashboard_Mes.ShowDialog();
        }

        private void btnRelatoriosPorVendedores_click(object sender, ContextMenuEventArgs e)
        {
            Relatórios_Vendedores Relatórios_Vendedores = new Relatórios_Vendedores();
            Relatórios_Vendedores.ShowDialog();
        }

        private void btnRelatoriosPorProdutos_Click(object sender, RoutedEventArgs e)
        {
            GerarRelatorioEntradaProdutos gerarRelatorioEntradaProdutos = new GerarRelatorioEntradaProdutos();
            gerarRelatorioEntradaProdutos.ShowDialog();
        }

        private void btnRelatoriosPorClientes_Click(object sender, RoutedEventArgs e)
        {
            GerarRelatorioClientes gerarRelatorioClientes = new GerarRelatorioClientes();
            gerarRelatorioClientes.ShowDialog();
        }
    }
}
