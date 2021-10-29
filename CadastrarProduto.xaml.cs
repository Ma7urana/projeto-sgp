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
using projeto_sgp_WPFversion.Models;

namespace projeto_sgp_WPFversion
{
    /// <summary>
    /// Interaction logic for CadastrarProduto.xaml
    /// </summary>
    public partial class CadastrarProduto : Window
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void tela_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ControleGeralDeCadastros ctrlGeral = new ControleGeralDeCadastros();
            this.Close();
        }

        private void salvar(object sender, RoutedEventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();

            Produto produto = new Produto
            {
                Nome = txtNome.Text,
                DataInclusao = txtData.SelectedDate.Value,
                Marca = txtMarca.Text,
                PrecoCompra = float.Parse(txtPrecoCompra.Text),
                PrecoVenda = float.Parse(txtPrecoVenda.Text),
                Quantidade = uint.Parse(txtQuantidade.Text),
                FornecedorId = uint.Parse(txtFornecedor.Text),
            };

            dao.Insert(produto);
        }
    }
}
