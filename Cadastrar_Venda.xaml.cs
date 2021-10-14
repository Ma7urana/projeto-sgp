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
        }

        private void btn_FinalizarVenda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Venda venda = new Venda();
                venda.Data = (DateTime)dp_data.SelectedDate;
                venda.Funcionario = 1;
                venda.Cliente = 1;
                venda.SubTotal = Convert.ToDouble(txt_SubTotal.Text);
                venda.Desconto = Convert.ToDouble(txt_Desconto.Text);
                venda.ValorASerPago = Convert.ToDouble(txt_ValorASerPago.Text);
                venda.ValorRecebido = Convert.ToDouble(txt_ValorRecebido.Text);
                venda.Troco = Convert.ToDouble(txt_TrocoDoCliente.Text);

                VendaDAO vendaDAO = new VendaDAO();
                vendaDAO.Insert(venda);

                MessageBox.Show("Venda inserida com sucesso", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information);

                var result = MessageBox.Show("Deseja cadastrar outro funcionário?", "Continuar?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                    this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi possível realizar o cadastro.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
