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
    class FornecedorDAO : IDAO<Fornecedor>
    {
        private static Conexao con;

        public FornecedorDAO() { con = new Conexao(); }

        public void Delete(Fornecedor t)
        {
            try
            {
                var query = con.Query();
                query.CommandText = "DELETE FROM Fornecedor where Id = @id";

                query.Parameters.AddWithValue("@id", t.Id);
             

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O registro não excluido. Verifique e tente novamente");

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
    

        public Fornecedor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Fornecedor t)
        {
            try
            {
                var query = con.Query();
                query.CommandText = "INSERT INTO Fornecedor (nome, nomefan_forn, RazaoSocial_Nome_forn, Cpf_cnpj_forn, pessoa_forn,  email ,fax, telefone,  inscricao_estadual, inscricao_municipal, Contato_Representante_Forn , tipo_fornecedor, Tipo_contribuinte_Forn, Observacao_Forn)" +
                "Values (@nome, @nomefan ,@RazaoSocial, @cpf_cnpj, @pessoa, @email, @Telefone, @fax, @Inscrição_Munipal,  @Inscrição_Estadua, @Contato_Representante, @tipo_fornecedor,@Tipo_contribuinte, @Observacao)";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@nomefan", t.Nomefan);
                query.Parameters.AddWithValue("@RazaoSocial", t.RazaoSocial_Nome);
                query.Parameters.AddWithValue("@cpf_cnpj", t.cpf_cnpj);
                query.Parameters.AddWithValue("@pessoa", t.pessoaT);
                query.Parameters.AddWithValue("@Inscrição_Munipal", t.Inscrição_Munipal);
                query.Parameters.AddWithValue("@Inscricao_Estadual", t.Inscrição_Estadual);
                query.Parameters.AddWithValue("@Contato_Representante", t.Contato_Representante);
                query.Parameters.AddWithValue("@tipo_fornecedor", t.Tipo_forn);
                query.Parameters.AddWithValue("@Tipo_contribuinte", t.Tipo_contribuinte);
                query.Parameters.AddWithValue("@telefone", t.Telefone);
                query.Parameters.AddWithValue("@Fax", t.Fax);
                query.Parameters.AddWithValue("@Email", t.Email);
                query.Parameters.AddWithValue("@Observacao", t.Observacao);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O registro não foi inserido. Verifique e tente novamente");

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

        public List<Fornecedor> List()
        {
            try
            {
                List<Fornecedor> list = new List<Fornecedor>();
                var Query = con.Query();
                Query.CommandText = "SELECT * FROM Fornecedor";

                MySqlDataReader reader = Query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Fornecedor()
                    {
                        Id = reader.GetInt32("Id"),
                        Nome = reader.GetString("nome"),
                        Nomefan = reader.GetString("nomefan_forn"),
                        RazaoSocial_Nome = reader.GetString("RazaoSocial_Nome_forn"),
                        cpf_cnpj = reader.GetString("Cpf_cnpj_forn"),
                        pessoaT = reader.GetString("pessoa_forn"),
                        Email = reader.GetString("email"),
                        Fax = reader.GetString("fax"),
                        Telefone = reader.GetString("telefone"),
                        Inscrição_Estadual = reader.GetString("inscricao_estadual"),
                        Inscrição_Munipal = reader.GetString("inscricao_municipal"),
                        Contato_Representante = reader.GetString("Contato_Representante_Forn"),
                        Tipo_forn = reader.GetString("tipo_fornecedor"),
                        Tipo_contribuinte = reader.GetString("Tipo_contribuinte_Forn"),
                        Observacao = reader.GetString("Observacao_Forn")
                    });
                }
                return list;

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

        public void Update(Fornecedor t)
        {
            throw new NotImplementedException();
        }

    }
}

