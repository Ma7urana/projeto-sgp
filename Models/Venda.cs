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

        public float Subtotal { get; set; }

        public float Desconto { get; set; }

        public float Troco { get; set; }

        public float ValorTotal { get; set; }

        public string FormaPagamento { get; set; }

        public int Parcelas { get; set; } 
    }
}
