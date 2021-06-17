using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AtividadePOO
{
    class Pessoa
    {
        public String nome { get; set; }
        public String cpf { get; private set; }
        public DateTime idade { get; set; }
        public String rg { get; set; }
        public Endereco endereco { get; set; }

        public Pessoa() { }
        public Pessoa(String nome, String cpf, DateTime idade, String rg, Endereco endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.rg = rg;
            this.endereco = endereco;
        }
    }
}
