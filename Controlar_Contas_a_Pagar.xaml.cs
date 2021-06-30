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
    /// Lógica interna para Controlar_Contas_a_Pagar.xaml
    /// </summary>
    public partial class Controlar_Contas_a_Pagar : Window
    {
        public Controlar_Contas_a_Pagar()
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

        private void btnEmissaodeFichas_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Emissão_de_fichas emissão_De_Fichas = new Emissão_de_fichas();
            emissão_De_Fichas.ShowDialog();

        }

        private void btnResumoporfornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Resumo_por_fornecedor resumo_Por_Fornecedor = new Resumo_por_fornecedor();
            resumo_Por_Fornecedor.ShowDialog();
        }

        private void btnTitulospordatadelançamento_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Titulos_por_data_de_lancamento titulos_Por_Data_De_Lancamento = new Titulos_por_data_de_lancamento();
            titulos_Por_Data_De_Lancamento.ShowDialog();

        }

        private void btnTituloseresumosportipodegasto_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Titulos_e_resumos_por_tipo_de_gasto titulos_E_Resumos_Por_Tipo_De_Gasto = new Titulos_e_resumos_por_tipo_de_gasto();
            titulos_E_Resumos_Por_Tipo_De_Gasto.ShowDialog();
        }

        private void Titulospagospordatadepagamento_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Titulos_por_data_de_pagamento titulos_Por_Data_De_Pagamento = new Titulos_por_data_de_pagamento();
            titulos_Por_Data_De_Pagamento.ShowDialog();
        }
    }
}
