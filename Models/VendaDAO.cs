using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_sgp_WPFversion.Interface;
using projeto_sgp_WPFversion.DataBase;
using MySql.Data.MySqlClient;

namespace projeto_sgp_WPFversion.Models
{
    class VendaDAO : IDAO<Venda>
    {
        private static Conexao conn;

        public VendaDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Venda t)
        {
            throw new NotImplementedException();
        }

        public Venda GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Venda t)
        {
            throw new NotImplementedException();
        }

        public List<Venda> List()
        {
            try
            {
                List<Venda> vendas = new List<Venda>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM venda";

                MySqlDataReader reader = query.ExecuteReader();

                while(reader.Read())
                {
                    vendas.Add(new Venda()
                    {
                        Id = reader.GetInt32("Id_vend"),
                        Data = reader.GetDateTime("Data_Vend"),
                        Subtotal = reader.GetFloat("Subtotal_Vend"),
                        Desconto = reader.GetFloat("Desconto_Vend"),
                        Troco = reader.GetFloat("Troco_Vend"),
                        ValorTotal = reader.GetFloat("Valor_Total_Vend"),
                        FormaPagamento = reader.GetString("FormaPag_Vend"),
                        Parcelas = reader.GetInt32("Qtd_parcelas_Vend")
                    });
                }

                return vendas;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.close();
            }
        }

        public void Update(Venda t)
        {
            throw new NotImplementedException();
        }
    }
}
