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
using projeto_sgp_WPFversion.Models;

namespace projeto_sgp_WPFversion
{
    /// <summary>
    /// Interação lógica para EscolherProdutosWindow.xam
    /// </summary>
    public partial class EscolherProdutosWindow : Window
    {
        public EscolherProdutosWindow()
        {
            InitializeComponent();
            Loaded += EscolherProdutosWindow_Loaded;
        }

        private void EscolherProdutosWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadListEscolherProduto();
        }

        private void btn_Finalizar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadListEscolherProduto()
        {
            try
            {
                var daoEscolherProduto = new VendaDAO();

                dg_EscolherProdutos.ItemsSource = daoEscolherProduto.ListProd();

                //foreach (var vendaProduto in daoVendaProduto.ListProd())
                //{
                //    MessageBox.Show(vendaProduto.Nome + " Preço: " + vendaProduto.PrecoVenda);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_Adicionar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
