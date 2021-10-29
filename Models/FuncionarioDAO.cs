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
    class FuncionarioDAO : IDAO<Funcionario>
    {
        private static Conexao con;

        public FuncionarioDAO()
        {
            con = new Conexao();
        }

        public void Delete(Funcionario t)
        {
            throw new NotImplementedException();
        }

        public Funcionario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Funcionario t)
        {
            try
            {
                var query = con.Query();

                query.CommandText = "INSERT INTO funcionario (nome_func, email_func, cpf_func, rg_func, data_nascimento_func, sexo_func, cargo_func, departamento_func, data_admissao_func, data_demissao_func, vale_alimentacao_func, vale_transporte_func) " +
                    "VALUES (@nome, @email, @cpf, @rg, @data_nascimento, @sexo, @cargo, @departamento, @data_admissao, @data_demissao, @vale_alimentacao, @vale_transporte)";
                
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@cpf", t.CPF);
                query.Parameters.AddWithValue("@rg", t.RG);
                query.Parameters.AddWithValue("@data_nascimento", t.DataNascimento.ToString("yyyy-MM-dd"));
                query.Parameters.AddWithValue("@sexo", t.Sexo);
                query.Parameters.AddWithValue("@cargo", t.Cargo);
                query.Parameters.AddWithValue("@departamento", t.Departamento);
                query.Parameters.AddWithValue("@data_admissao", t.DataAdimissao.ToString("yyyy-MM-dd"));
                query.Parameters.AddWithValue("@data_demissao", t.DataDemissao.ToString("yyyy-MM-dd"));
                query.Parameters.AddWithValue("@vale_alimentacao", t.ValeAlimentacao);
                query.Parameters.AddWithValue("@vale_transporte", t.ValeTransporte);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Não foi possível inserir o funcionário. Verifique e tente novamente");

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

        public List<Funcionario> List()
        {
            try 
            { 
                List<Funcionario> list = new List<Funcionario>(); 
                var Query = con.Query(); 
                Query.CommandText = "SELECT * FROM Funcionario"; 
 
                MySqlDataReader reader = Query.ExecuteReader(); 
 
                while (reader.Read()) 
                { 
                    list.Add(new Funcionario() 
                    { 
                        Id = reader.GetInt32("id"), 
                        Nome = reader.GetString("nome"), 
                        Email = reader.GetString("email"), 
                        CPF = reader.GetString("cpf"), 
                        RG = reader.GetString("rg"), 
                        DataNascimento = reader.GetDateTime("data_nascimento"), 
                        Sexo = reader.GetString("sexo"), 
                        Cargo = reader.GetString("cargo"), 
                        Departamento = reader.GetString("departamento"), 
                        DataAdimissao = reader.GetDateTime("data_admissao"), 
                        DataDemissao = reader.GetDateTime("data_demissao"), 
                        ValeAlimentacao = reader.GetChar("vale_alimentacao"), 
                        ValeTransporte = reader.GetChar("vale_transporte"), 
                        Endereco = reader.GetInt32("endereco_id"), 
                        Salario = reader.GetFloat("salario") 
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

        public void Update(Funcionario t)
        {
            throw new NotImplementedException();
        }
    }
}
