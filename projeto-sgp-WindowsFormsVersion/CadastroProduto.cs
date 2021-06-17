using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadePOO
{
    public partial class CadastroProduto : Form
    {
        Produto produto = new Produto();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            produto.id = textCod.Text;
            produto.nome = textName.Text;
            produto.marca = textMarca.Text;
            produto.fornecedor = textForn.Text;
            produto.unidade = int.Parse(textUnit.Text);
            produto.data = DateTime.Parse(textData.Text);
            produto.precoCompra = double.Parse(textPrecoCompra.Text);
            produto.precoVenda = double.Parse(textPrecoVenda.Text);
        }

        double precoCompra, precoVenda;

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Controle_Geral_Cadastro ctrlCad = new Controle_Geral_Cadastro();
            this.Hide();
            ctrlCad.ShowDialog();
            this.Close();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            textData.Text = new DateTime().ToString("dd/mm/yyyy");
        }
    }
}
