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
    /// Lógica interna para Cadastrar_funcionario.xaml
    /// </summary>
    public partial class Cadastrar_funcionario : Window
    {
        public Cadastrar_funcionario()
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

        private void btn_Salvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txt_Nome.Text;
                funcionario.Email = txt_Email.Text;
                funcionario.CPF = txt_CPF.Text;
                funcionario.RG = txt_RG.Text;
                funcionario.DataNascimento = (DateTime)dp_dtNascimento.SelectedDate;
                funcionario.Sexo = cbb_Sexo.Text;
                funcionario.Cargo = cbb_Cargo.Text;
                funcionario.Departamento = cbb_Departamento.Text;
                funcionario.DataAdimissao = (DateTime)dp_dtAdmissao.SelectedDate;
                funcionario.DataDemissao = (DateTime)dp_dtDemissao.SelectedDate;
                funcionario.ValeAlimentacao = 'v';
                funcionario.ValeTransporte = 'v';

                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                funcionarioDAO.Insert(funcionario);

                Confirmacao_Cadast_Funcionario conc = new Confirmacao_Cadast_Funcionario();
                conc.ShowDialog();

                var result = MessageBox.Show("Deseja cadastrar outro funcionário?", "Continuar?",MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                    this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi possível realizar o cadastro.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_Excluir_Click(object sender, RoutedEventArgs e)
        {
            Alerta_Cadast_Funcionario cancelar = new Alerta_Cadast_Funcionario();
            cancelar.ShowDialog();
        }

        private void ClearInputs()
        {
            txt_Nome.Text = "";
            txt_Email.Text = "";
            txt_CPF.Text = "";
            txt_RG.Text = "";
            dp_dtNascimento.SelectedDate = null;
            cbb_Sexo.Text = "";
            cbb_Cargo.Text = "";
            cbb_Departamento.Text = "";
            dp_dtAdmissao.SelectedDate = null;
            dp_dtDemissao.SelectedDate = null;
            rbtn_Sim_Val_Alim.IsChecked = false;
            rbtn_Sim_Val_Transp.IsChecked = false;
            rbtn_Nao_Val_Alim.IsChecked = false;
            rbtn_Nao_Val_Transp.IsChecked = false;
        }
    }
}
