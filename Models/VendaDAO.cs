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
        private static Conexao con;

        public VendaDAO()
        {
            con = new Conexao();
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
            try
            {
                var query = con.Query();

                query.CommandText = "INSERT INTO funcionario (Id_Vend, Data_Vend, Subtotal_Vend, Desconto_Vend, Valor_A_Ser_Pago_Vend, Valor_Recebido_Vend, Troco_Vend, Id_cli_fk, id_func_fk) " +
                    "VALUES (@data_, @subTotal, @desconto, @valor_a_ser_pago, @valor_recebido, @troco, @funcionario, @cliente)";

                query.Parameters.AddWithValue("@data_", t.Data.ToString("yyyy-MM-dd"));
                query.Parameters.AddWithValue("@subTotal", t.SubTotal);
                query.Parameters.AddWithValue("@desconto", t.Desconto);
                query.Parameters.AddWithValue("@valor_a_ser_pago", t.ValorASerPago);
                query.Parameters.AddWithValue("@valor_recebido", t.ValorRecebido);
                query.Parameters.AddWithValue("@troco", t.Troco);
                query.Parameters.AddWithValue("@funcionario", t.Funcionario);
                query.Parameters.AddWithValue("@cliente", t.Cliente);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Não foi possível inserir a venda. Verifique e tente novamente.");

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.close();
            }
        }

        public List<Venda> List()
        {
            try
            {
                List<Venda> vendas = new List<Venda>();

                var query = con.Query();
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
