using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_sgp_WPFversion.Models
{
    class Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public string Cargo { get; set; }

        public string Departamento { get; set; }

        public DateTime DataAdimissao { get; set; }

        public DateTime DataDemissao { get; set; }

        public char ValeAlimentacao { get; set; }

        public char ValeTransporte { get; set; }

        public int Endereco { get; set; }

        public float Salario { get; set; }

        public int Endereco { get; set; } 
 
        public float Salario { get; set; } 
    }
}
