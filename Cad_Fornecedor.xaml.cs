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
using projeto_sgp_WPFversion.DataBase;
using projeto_sgp_WPFversion.Interface;


namespace projeto_sgp_WPFversion
{
    /// <summary>
    /// Lógica interna para Cad_Fornecedor.xaml
    /// </summary>
    public partial class Cad_Fornecedor : Window
    {
        public Cad_Fornecedor()
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Btnconclui(object sender, RoutedEventArgs e)
        {
            Tela_cad_concluido conc = new Tela_cad_concluido();


            try
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Nome = Txt_Nome.Text;
                fornecedor.Nomefan = Txt_NomeFan.Text;
                fornecedor.RazaoSocial_Nome = Txt_Razaosocial.Text;
                fornecedor.cpf_cnpj = Txt_cpf.Text;
                fornecedor.pessoaT = "V";
                fornecedor.Inscrição_Munipal = Txt_Municipal.Text;
                fornecedor.Inscrição_Estadual = Txt_Estadual.Text;
                fornecedor.Contato_Representante = Txt_Representante.Text;
                fornecedor.Tipo_forn = "V";
                fornecedor.Tipo_contribuinte = Txt_contribuinte.Text;
                fornecedor.Telefone = Txt_Telefone.Text;
                fornecedor.Fax = Txt_FAX.Text;
                fornecedor.Email = Txt_Email.Text;
                fornecedor.Observacao = Txt_Observacao.Text;



                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                fornecedorDAO.Insert(fornecedor);

                conc.ShowDialog();
                var result = MessageBox.Show("Deseja continuar no cadastro?", "Continuar?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                    clearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            Tela_cancel Cancelar = new Tela_cancel();
            Cancelar.ShowDialog();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        private void clearInput()
        {

            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = " ";
            fornecedor.Nomefan = " ";
            fornecedor.RazaoSocial_Nome = " ";
            fornecedor.cpf_cnpj = " ";
            fornecedor.pessoaT = "V";
            fornecedor.Inscrição_Munipal = " ";
            fornecedor.Inscrição_Estadual = " ";
            fornecedor.Contato_Representante = " ";
            fornecedor.Tipo_forn = "V";
            fornecedor.Tipo_contribuinte = " ";
            fornecedor.Telefone = " ";
            fornecedor.Fax = " ";
            fornecedor.Email = " ";
            fornecedor.Observacao = " ";

        }

        private void Txt_contribuinte_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}