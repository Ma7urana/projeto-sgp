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
    /// Lógica interna para Cadastrar_Venda.xaml
    /// </summary>
    public partial class Cadastrar_Venda : Window
    {
        public Cadastrar_Venda()
        {
            InitializeComponent();
            Loaded += VendaListWindow_Loaded;
        }

        private void btn_FinalizarVenda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Venda venda = new Venda();
                venda.Data = (DateTime)dp_data.SelectedDate;
                venda.Funcionario = Convert.ToInt32(txt_IdFuncionario.Text);
                venda.Cliente = Convert.ToInt32(txt_IdCliente.Text);
                venda.SubTotal = Convert.ToDouble(txt_SubTotal.Text);
                venda.Desconto = Convert.ToDouble(txt_Desconto.Text);
                venda.ValorASerPago = Convert.ToDouble(txt_ValorASerPago.Text);
                venda.ValorRecebido = Convert.ToDouble(txt_ValorRecebido.Text);
                venda.Troco = Convert.ToDouble(txt_TrocoDoCliente.Text);

                VendaDAO vendaDAO = new VendaDAO();
                vendaDAO.Insert(venda);

                MessageBox.Show("Venda inserida com sucesso", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information);

                var result = MessageBox.Show("Deseja inserir outra venda?", "Continuar?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                    this.Close();
                else
                    ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi possível realizar a venda.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmar cancelamento?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void ClearInputs()
        {
            dp_data.SelectedDate = null;
            txt_IdFuncionario.Text = "";
            txt_IdCliente.Text = "";
            txt_SubTotal.Text = "";
            txt_Desconto.Text = "";
            txt_ValorASerPago.Text = "";
            txt_ValorRecebido.Text = "";
            txt_TrocoDoCliente.Text = "";
        }

        private void VendaListWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadListVendaProduto();
        }

        private void btn_EscolherProdutos_Click(object sender, RoutedEventArgs e)
        {
            EscolherProdutosWindow escolherProdutosWindow = new EscolherProdutosWindow();
            escolherProdutosWindow.ShowDialog();
        }

        private void LoadListVendaProduto()
        {
            try
            {
                var daoVendaProduto = new VendaDAO();

                dg_VendaProdutos.ItemsSource = daoVendaProduto.ListVendaProd();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
