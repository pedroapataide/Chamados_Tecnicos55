using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //ADD.net
using System.Data.SqlClient; // ADD para SQL SERVER 

namespace Data
{
    public class ClientesDao
    {
        private string _conexao;

        // Metodo Construtor => inicializa Objto Buscando Conxão
        public ClientesDao(string conexao)
        {
            // RECEBA conexão
            _conexao = conexao;
        }
        // Inserir cliente Vulgo XUXAR
        public void IncluiCliente(Clientes cliente)
        {
            using(SqlConnection conexaobd = new SqlConnection(_conexao))
            {
                string sql = "insert into Clientes (nome, profissao, sertor, obs) values (@nome, @profissao, @setor, @obs)";

                using(SqlCommand comando = new SqlCommand(sql, conexaobd))
                {
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@profissao", cliente.Profissao);
                    comando.Parameters.AddWithValue("@Setor", cliente.Setor);
                    comando.Parameters.AddWithValue("@obs", cliente.Obs);

                    try
                    {
                        conexaobd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao incluir Cliente:" + ex.Message);
                    }
                }
            }
        }
    }
}
