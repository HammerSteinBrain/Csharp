using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCrud
{
    public class Dados
    {
        //variavel que recebera a string de conexão
        public string srtConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //variaveis constantes que conterão as instruções SQL para o CRUD
        public const string strDelete = "DELETE FROM Clientes WHERE idCliente = @IdCliente";
        public const string strInsert = "INSERT INTO Clientes (Nome, Endereco,Telefone, Sexo, Ativo, DataCadastro) VALUES (@Nome, @Endereco,@Telefone, @Sexo, @Ativo, @DataCadastro)";
        public const string strSelect = "SELECT * FROM Clientes";
        public const string strUpdate = "UPDATE Clientes SET Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone, Sexo = @Sexo, Ativo = @Ativo, DataCadastro = @DataCadastro WHERE idCliente = @IdCliente";


        public void Gravar(string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro) {

            using (SqlConnection conexao = new SqlConnection(srtConexao)) {

                using (SqlCommand comandoSQL = new SqlCommand(strInsert, conexao)) {

                    comandoSQL.Parameters.AddWithValue("@Nome",Nome);
                    comandoSQL.Parameters.AddWithValue("@Endereco", Endereco);
                    comandoSQL.Parameters.AddWithValue("@Telefone", Telefone);
                    comandoSQL.Parameters.AddWithValue("@Sexo", Sexo);
                    comandoSQL.Parameters.AddWithValue("@Ativo", Ativo);
                    comandoSQL.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    conexao.Open();

                    comandoSQL.ExecuteNonQuery();

                    conexao.Close();
                }

            }

        }


        public void Atualizar(int IdCliente , string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro) {

            using (SqlConnection conexao = new SqlConnection(srtConexao))
            {

                using (SqlCommand comandoSQL = new SqlCommand(strUpdate, conexao))
                {
                    comandoSQL.Parameters.AddWithValue("@IdCliente", IdCliente);
                    comandoSQL.Parameters.AddWithValue("@Nome", Nome);
                    comandoSQL.Parameters.AddWithValue("@Endereco", Endereco);
                    comandoSQL.Parameters.AddWithValue("@Telefone", Telefone);
                    comandoSQL.Parameters.AddWithValue("@Sexo", Sexo);
                    comandoSQL.Parameters.AddWithValue("@Ativo", Ativo);
                    comandoSQL.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    conexao.Open();

                    comandoSQL.ExecuteNonQuery();

                    conexao.Close();
                }

            }

        }


        public void Excluir(int IdCliente) {

            using (SqlConnection conexao = new SqlConnection(srtConexao))
            {

                using (SqlCommand comandoSQL = new SqlCommand(strDelete, conexao))
                {
                    comandoSQL.Parameters.AddWithValue("@IdCliente", IdCliente);

                    conexao.Open();

                    comandoSQL.ExecuteNonQuery();

                    conexao.Close();
                }

            }

        }


    }
}
