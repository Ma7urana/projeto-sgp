using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_sgp_WPFversion.Models
{
    class Venda
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public int Funcionario { get; set; }

        public int Cliente { get; set; }

        public int TelefoneCliente { get; set; }

        public double SubTotal { get; set; }

        public double Desconto { get; set; }

        public double ValorASerPago { get; set; }

        public double ValorRecebido { get; set; }

        public double Troco { get; set; }
    }
}
