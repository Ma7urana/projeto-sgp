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
    /// Lógica interna para Alerta_Cadast_Funcionario.xaml
    /// </summary>
    public partial class Alerta_Cadast_Funcionario : Window
    {
        public Alerta_Cadast_Funcionario()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void No_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
