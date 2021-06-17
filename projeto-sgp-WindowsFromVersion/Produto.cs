using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO
{
    class Produto
    {
        public String id { get; set; }
        public String nome { get; set; }
        public String marca { get; set; }
        public String fornecedor { get; set; }
        public int unidade { get; set; }
        public DateTime data { get; set; }
        public double precoCompra { get; set; }
        public double precoVenda { get; set; }

        public Produto() { }
        public Produto(String id, String nome, String marca, String fornecedor, int unidade, DateTime data, double precoCompra, double precoVenda)
        {
            this.id = id;
            this.nome = nome;
            this.marca = marca;
            this.fornecedor = fornecedor;
            this.unidade = unidade;
            this.data = data;
            this.precoCompra = precoCompra;
            this.precoVenda = precoVenda;
        }
    }
}
