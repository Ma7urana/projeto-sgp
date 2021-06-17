using Cadastrar_Usuário;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePOO
{
    public partial class Exibir_Menu : Form
    {
        public Exibir_Menu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CadastroUsuário cadUser = new CadastroUsuário();
            this.Hide();
            cadUser.ShowDialog();
            this.Close();
        }

        private void Controle_Cadastro_Gerais_Click(object sender, EventArgs e)
        {
            Controle_Geral_Cadastro ctrlCad = new Controle_Geral_Cadastro();
            this.Hide();
            ctrlCad.ShowDialog();
            this.Close();
        }
    }
}
