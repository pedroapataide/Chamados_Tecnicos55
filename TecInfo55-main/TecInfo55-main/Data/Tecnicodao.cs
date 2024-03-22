using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //ADD.net
using System.Data.SqlClient; // ADD para SQL SERVER 
using System.Threading.Tasks;

namespace Data
{
    public class Tecnicodao
    {
        private string _conexao;

        // Metodo Construtor => inicializa Objto Buscando Conxão
        public Tecnicodao(string conexao)
        {
            // RECEBA conexão
            _conexao = conexao;
        }
        // Inserir cliente Vulgo XUXAR
        public void IncluiTecnico(Tecnicos tecnicos)
        {
            using (SqlConnection conexaobd = new SqlConnection(_conexao))
            {
                string sql = "insert into Tecnicos (nome, especialidade, email, senha, obs) values (@nome, @especialidade, @email,@senha, @obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaobd))
                {
                    comando.Parameters.AddWithValue("@nome", tecnicos.Nome);
                    comando.Parameters.AddWithValue("@especialidade", tecnicos.Especialidade);
                    comando.Parameters.AddWithValue("@email", tecnicos.Email);
                    comando.Parameters.AddWithValue("@senha", tecnicos.senha);
                    comando.Parameters.AddWithValue("@obs", tecnicos.Obs);

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
