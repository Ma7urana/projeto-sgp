using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO
{
    class Endereco
    {
        public String logradouro { get; set; }
        public String numero { get; set; }
        public String bairro { get; set; }
        public String cep { get; set; }
        public String cidade { get; set; }
        public String uf { get; set; }

        public Endereco() { }
        public Endereco(String logradouro, String numero, String bairro, String cep, String cidade, String uf)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
        }
    }
}
