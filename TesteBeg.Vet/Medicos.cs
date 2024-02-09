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
    public class Medic
    {
        SqlCommand SqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dataTable = new DataTable();

        //Method which gonna save the informations according to the parameters between parentheses.
        public void Save(string name,
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
                using (SqlConnection conexao = new SqlConnection(Conexao.StringConexao))
                {
                    conexao.Open(); //Abre a conexão com o banco de dados.

                    //Comando SQL para a inserção de valores nos respectivos campos da tabela Funcionário.
                    sql.Append("INSERT INTO medicos (NOME_MEDICO, ENDERECO_MEDICO, EXPERIENCIA_MEDICO, AREA_MEDICO ");
                    sql.Append("DISPONIBILIDADE, TELEFONE_MEDICO, CPF_MEDICO)");

                    sql.Append(" VALUES (@nome, @endereco, @experiencia, @area, @DP, ");
                    sql.Append("@telefone, @Cpf)");

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
                using (SqlConnection conexao = new SqlConnection(Conexao.StringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Medicos");
                    sql.Append(" ORDER BY ID_MEDICOS DESC");

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
        public void Alterar(int idMedico, string nome, string endereco, string experiencia, string area,
                            string DP, string telefone)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.StringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Funcionario");
                    sql.Append(" SET NOME_MEDICO=@nome, ENDERECO_MEDICO=@endereco, ");
                    sql.Append("EXPERIENCIA_MEDICO=@experiencia, AREA_MEDICO=@area, DISPONIBILIDADE=@DP  ");
                    sql.Append(" TELEFONE_MEDICO=@telefone, CPF_MEDICO=@cpf ");

                    sql.Append(" WHERE (ID_Medico=@idMedico)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@experiencia", experiencia));
                    comandoSql.Parameters.Add(new SqlParameter("@area", area));
                    comandoSql.Parameters.Add(new SqlParameter("@DP", DP));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));

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
        public void Excluir(int idFuncionario)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.StringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Funcionario");
                    sql.Append(" WHERE (ID_FUNCIONARIO = @idFuncionario)");

                    comandoSql.Parameters.Add(new SqlParameter("@idFuncionario", idFuncionario));

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

        internal void Salvar(string text1, string text2, string text3, string valueMember, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        internal static void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}