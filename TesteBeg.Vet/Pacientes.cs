using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBeg.Vet
{
    internal class Pacientes
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string dono, string nome, DateTime nascimento, string especie, string vascinas,
            string problema, string historico)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Paciente (NOME_PACIENTE, DONO_PACIENTE, NASCIMENTO_PACIENTE, ");
                    sql.Append(" ESPECIE_PACIENTE, VASCINAS_PACIENTE, PROBLEMA_PACIENTE, HISTORICO_PACIENTE) ");
                    sql.Append(" VALUES (@nome, @dono, @nascimento, @especie, @vascinas, @problema, @historico) ");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@dono", dono));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@especie", especie));
                    comandoSql.Parameters.Add(new SqlParameter("@vascinas", vascinas));
                    comandoSql.Parameters.Add(new SqlParameter("@problema", problema));
                    comandoSql.Parameters.Add(new SqlParameter("@historico", historico));
 
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Pacientes");
                    sql.Append(" ORDER BY ID_CLIENTE DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }


        public void Alterar(int idPaciente, string dono, string nome, DateTime nascimento, string especie, string vascinas,
            string problema, string historico)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Cliente");
                    sql.Append(" SET NOME_PACIENTE=@nome, DONO_PACIENTE=@dono, NASCIMENTO_PACIENTE=@nascimento, ");
                    sql.Append(" ESPECIE_PACIENTE=@especie, VASCINAS_PACIENTE=@vascinas, PROBLEMA_PACIENTE=@problema, HISTORICO_PACIENTE=@historico");
                    sql.Append(" WHERE (ID_PACIENTE=@idPaciente)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@dono", dono));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@especie", especie));
                    comandoSql.Parameters.Add(new SqlParameter("@vascinas", vascinas));
                    comandoSql.Parameters.Add(new SqlParameter("@problema", problema));
                    comandoSql.Parameters.Add(new SqlParameter("@historico", historico));
                    comandoSql.Parameters.Add(new SqlParameter("@idPaciente", idPaciente));

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
        public void Excluir(int idPaciente)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Pacientes");
                    sql.Append(" WHERE (ID_PACIENTE = @idPaciente)");
                    comandoSql.Parameters.Add(new SqlParameter("@idPaciente", idPaciente));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        internal void Salvar(string text1, string text2, string text3, string valueMember, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        internal void Alterar(int v, string text1, string text2, string text3, string valueMember, string text4, string text5)
        {
            throw new NotImplementedException();
        }
    }
}
    

