using AtividadePOO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrar_Usuário
{
    public partial class CadastroUsuário : Form
    {
        Cliente cliente = new Cliente();
        public CadastroUsuário()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cliente.nome = txtNomeDeUsuario.Text;
            cliente.senha = txtSenhaUsuario.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exibir_Menu menu = new Exibir_Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
