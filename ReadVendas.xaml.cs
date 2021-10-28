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
    /// Interação lógica para ReadVendas.xam
    /// </summary>
    public partial class ReadVendas : Page
    {
        public ReadVendas()
        {
            InitializeComponent();
            Loaded += ReadVendaListWindow_Loaded;
        }

        private void ReadVendaListWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadListReadVenda();
        }

        private void LoadListReadVenda()
        {
            try
            {
                var daoReadVendas = new VendaDAO();

                dg_ReadVendas.ItemsSource = daoReadVendas.List();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
