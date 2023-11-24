using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBeg.Vet
{
    internal class Medico

    {
        public class Funcionarios
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            DataTable dadosTabela = new DataTable();

            //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
            public void Salvar(string nome,
                               string endereco,
                               string experiencia,
                               string area,
                               string DP,
                               string telefone,
                               string Cpf)
            {
                try //Estrutura try, a qual tenta realizar o que está dentro de suas chaves.
                {
                    //Estabelece a conexão com o banco através da string de conexão.
                    using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                    {
                        conexao.Open(); //Abre a conexão com o banco de dados.

                        //Comando SQL para a inserção de valores nos respectivos campos da tabela Funcionário.
                        sql.Append("INSERT INTO Medico (NOME_MEDICO, ENDERECO_MEDICO, EXPERIENCIA_MEDICO  ");
                        sql.Append("AREA_MEDICO, DISPONIBILIDADE_MEDICO, TELEFONE_MEDICO, CPF_MEDICO, CPF_MEDICO) ");

                        sql.Append(" VALUES (@nome, @endereco, @experiencia, @area, @DP, @telefone, @Cpf)");

                        //Relaciona cada valor com seu respectivo parâmetro.
                        comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                        comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                        comandoSql.Parameters.Add(new SqlParameter("@experiencia", experiencia));
                        comandoSql.Parameters.Add(new SqlParameter("@area", area));
                        comandoSql.Parameters.Add(new SqlParameter("@DP", DP));
                        comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                        comandoSql.Parameters.Add(new SqlParameter("@Cpf", Cpf));


                        comandoSql.CommandText = sql.ToString(); //Indica que o código SQL é o que deverá ser executado.
                        comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a string de conexão.
                        comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
                    }
                }
                catch (Exception)
                {
                    //Caso ocorra um erro no bloco try, entrará no catch, lugar em irá detectá-lo.
                    throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
                }
            }

            //Método que armazena as informações da tabela Funcionário e retorna esses dados em ordem decrescente, baseado pelo id.
            public DataTable Listar()
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                    {
                        conexao.Open();

                        sql.Append("SELECT * FROM Medico");
                        sql.Append(" ORDER BY ID_Medico DESC");

                        comandoSql.CommandText = sql.ToString();
                        comandoSql.Connection = conexao;
                        dadosTabela.Load(comandoSql.ExecuteReader());
                        return dadosTabela;
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do sistema.");
                }
            }

            //Método que irá Atualizar as informações conforme os parâmetros que possui entre parênteses.
            public void Alterar(int ID_Medico, string nome, string endereco,
                                string experiencia, string area, DateTime DP,string telefone, string Cpf)
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                    {
                        conexao.Open();

                        sql.Append("UPDATE Funcionario");
                        sql.Append(" SET NOME_MEDICO=@ID_Medico, ENDERECO_MEDICO=@endereco, EXPERIENCIA_MEDICO@experiencia, AREA_MEDICO=@area");
                        sql.Append("DISPONIBLIDADE_MEDICO=@DP, TELEFONE_MEDICO=@telefone, CPF_MEDICO=@cpf");

                        sql.Append(" WHERE (ID_Medico=@idMedico)");

                        comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                        comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                        comandoSql.Parameters.Add(new SqlParameter("@experiencia", experiencia));
                        comandoSql.Parameters.Add(new SqlParameter("@area", area));
                        comandoSql.Parameters.Add(new SqlParameter("@DP", DP));
                        comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                        comandoSql.Parameters.Add(new SqlParameter("@cpf", Cpf));

                        comandoSql.CommandText = sql.ToString();
                        comandoSql.Connection = conexao;
                        comandoSql.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
                }
            }

            //Método para excluir registros do banco.
            public void Excluir(int idMedico)
            {
                try
                {
                    using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                    {
                        conexao.Open();

                        sql.Append("DELETE FROM Medico");
                        sql.Append(" WHERE (ID_MEDICO = @idMedico)");

                        comandoSql.Parameters.Add(new SqlParameter("@idFuncionario", idMedico));

                        comandoSql.CommandText = sql.ToString();
                        comandoSql.Connection = conexao;
                        comandoSql.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do sistema.");
                }
            }
        }
    }
}