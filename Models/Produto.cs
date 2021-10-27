using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_sgp_WPFversion.Models
{
    class Produto
    {
        public uint Id { get; set; }
        public string Nome { get; set; }
        public float PrecoCompra { get; set; }
        public float PrecoVenda { get; set; }
        public uint Quantidade { get; set; }
        public uint FornecedorId { get; set; }
    }
}
