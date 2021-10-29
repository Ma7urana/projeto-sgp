using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto_sgp_WPFversion.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string cpf_cnpj { get; set; }
        public string pessoaT { get; set; }
        public string Nome { get; set; }
        public string Nomefan { get; set; }
        public string RazaoSocial_Nome { get; set; }
        public string Fax { get; set; }
        public string Telefone { get; set; }
        public string Inscrição_Estadual { get; set; }
        public string Inscrição_Munipal { get; set; }
        public string Contato_Representante { get; set; }
        public string Tipo_contribuinte { get; set; }
        public string Observacao { get; set; }

        public string Tipo_forn { get; set; }
    }
}
