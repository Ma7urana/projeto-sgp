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
    /// Lógica interna para Titulos_por_data_de_pagamento.xaml
    /// </summary>
    public partial class Titulos_por_data_de_pagamento : Window
    {
        public Titulos_por_data_de_pagamento()
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
        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            Controlar_Contas_a_Pagar controlar_Contas_A_Pagar = new Controlar_Contas_a_Pagar();
            controlar_Contas_A_Pagar.ShowDialog();

        }
    }
}
