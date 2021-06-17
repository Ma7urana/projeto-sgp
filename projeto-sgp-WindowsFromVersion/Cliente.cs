using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadePOO
{
    class Cliente : Pessoa
    {
        public String email { get; set; }
        public String senha { get; set; }

        public Cliente() { }
        public Cliente(String email, String senha)
        {
            this.email = email;
            this.senha = senha;
        }
    }
}
