using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_sgp_WPFversion.DataBase;
using projeto_sgp_WPFversion.Interface;

namespace projeto_sgp_WPFversion.Models
{
    class CompraDAO : IDAO<Compra>
    {
        private Conexao con;

        public CompraDAO()
        {
            con = new Conexao();
        }
        public void Delete(Compra t)
        {
            throw new NotImplementedException();
        }

        public Compra GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Compra t)
        {
            throw new NotImplementedException();
        }

        public List<Compra> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Compra t)
        {
            throw new NotImplementedException();
        }
    }
}
