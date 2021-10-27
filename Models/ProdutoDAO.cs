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
    class ProdutoDAO : IDAO<Produto>
    {
        private readonly Conexao con;

        public ProdutoDAO()
        {
            con = new Conexao();
        }

        public void Delete(Produto t)
        {
            throw new NotImplementedException();
        }

        public Produto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Produto t)
        {
            try
            {
                var query = con.Query();
                query.CommandText = @"
                    INSERT INTO produtos (nome, preco_compra, preco_venda, quantidade, fornecedor_id)
                    VALUES (@nome, @preco_compra, @preco_venda, @quantidade, @fornecedor_id)
                ";

                query.Parameters.AddWithValue("@nome", t.Nome);


                var result = query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Produto> List()
        {
            try
            {
                List<Produto> produtos = new List<Produto>();

                var query = con.Query();
                query.CommandText = "SELECT * FROM produtos";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    produtos.Add(new Produto
                    {
                        Id = reader.GetUInt32("id"),
                        Nome = reader.GetString("nome"),
                        PrecoCompra = reader.GetFloat("preco_compra"),
                        PrecoVenda = reader.GetFloat("preco_venda"),
                        Quantidade = reader.GetUInt32("quantidade"),
                        FornecedorId = reader.GetUInt32("fornecedor_id")
                    });
                }

                return produtos;
            } 
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(Produto t)
        {
            throw new NotImplementedException();
        }
    }
}
