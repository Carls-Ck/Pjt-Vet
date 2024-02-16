using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBeg.Vet
{
    internal class Pacients
    {
        SqlCommand SqlCommand = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable DataTable = new DataTable();

        public void Save(string owner, string name, DateTime Born, string species, string vasccines,
            string problem, string history, SqlConnection connection)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(connection.StringConnection)) ;
                {
                    Connection.Open();

                    sql.Append("INSERT INTO Paciente (NAME_PACIENT, OWNER_PACIENT, BORN_PACIENT, ");
                    sql.Append(" SPECIES_PACIENT, VASCCINES_PACIENT, PROBLEM_PACIENT, HISTORY_PACIENT) ");
                    sql.Append(" VALUES (@name, @owner, @born, @species, @vasccines, @problem, @history) ");

                    SqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    SqlCommand.Parameters.Add(new SqlParameter("@owner", owner));
                    SqlCommand.Parameters.Add(new SqlParameter("@born", Born));
                    SqlCommand.Parameters.Add(new SqlParameter("@species", species));
                    SqlCommand.Parameters.Add(new SqlParameter("@vasccines", vasccines));
                    SqlCommand.Parameters.Add(new SqlParameter("@problem", problem));
                    SqlCommand.Parameters.Add(new SqlParameter("@history", history));

                    SqlCommand.CommandText = sql.ToString();
                    SqlCommand.Connection = connection;
                    SqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }
        public DataTable List()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.StringConnection))
                {
                    connection.Open();

                    sql.Append("SELECT * FROM Pacientes");
                    sql.Append(" ORDER BY ID_CLIENTE DESC");

                    SqlCommand.CommandText = sql.ToString();
                    SqlCommand.Connection = connection;
                    DataTable.Load(SqlCommand.ExecuteReader());
                    return DataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }


        public void Change(int idPacient, string owner, string name, DateTime Born, string species, string vasccines,
            string problem, string history)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.StringConnection))
                {
                    Connection.Open();

                    sql.Append("UPDATE Cliente");
                    sql.Append(" SET NAME_PACIENT=@name, OWNER_PACIENT=@owner, BORN_PACIENT=@born, ");
                    sql.Append(" SPECIES_PACIENT=@species, VASCCNIES_PACIENT=@vasccines, PROBLEM_PACIENT=@problem, HISTORICO_PACIENTE=@historico");
                    sql.Append(" WHERE (ID_PACIENT=@idPacient)");

                    SqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    SqlCommand.Parameters.Add(new SqlParameter("@owner", owner));
                    SqlCommand.Parameters.Add(new SqlParameter("@born", Born));
                    SqlCommand.Parameters.Add(new SqlParameter("@species", species));
                    SqlCommand.Parameters.Add(new SqlParameter("@vasccines", vasccines));
                    SqlCommand.Parameters.Add(new SqlParameter("@problem", problem));
                    SqlCommand.Parameters.Add(new SqlParameter("@history", history));
                    SqlCommand.Parameters.Add(new SqlParameter("@idPacient", idPacient));

                    SqlCommand.CommandText = sql.ToString();
                    SqlCommand.Connection = connection;
                    SqlCommand.ExecuteNonQuery();
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
                using (SqlConnection conexao = new SqlConnection(Connection.StringConnection))
                {
                    Connection.Open();

                    sql.Append("DELETE FROM Pacientes");
                    sql.Append(" WHERE (ID_PACIENTE = @idPaciente)");
                    SqlCommand.Parameters.Add(new SqlParameter("@idPaciente", idPaciente));

                    SqlCommand.CommandText = sql.ToString();
                    SqlCommand.Connection = conexao;
                    SqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }


        internal void Save(string text1, string text2, string text3, string valueMember, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        internal void Change(int v, string text1, string text2, string text3, string valueMember, string text4, string text5)
        {
            throw new NotImplementedException();
        }
    }
}
    

