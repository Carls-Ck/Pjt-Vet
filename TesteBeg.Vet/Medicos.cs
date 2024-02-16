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
        internal void Save(int idMedic, string name, string adress, string experience, string area, string DP,
                               string telephone)
        {
            try // Structure Try, which try to realize what is inside the keys.
            {

                // Lays down a connection with the database by the connection string.

                using (SqlConnection connection = new SqlConnection(Connection.StringConnection))
                {
                    connection.Open(); //Open the connection with database

                    //Comando SQL para a inserção de valores nos respectivos campos da tabela Funcionário.
                    sql.Append("INSERT INTO medic (NAME_MEDIC, ADRESS_MEDIC, EXPERIENCE_MEDIC, AREA_MEDIC ");
                    sql.Append("DISPONIBILITY_MEDIC, TELEPHONE_MEDIC, ID_MEDICO)");

                    sql.Append(" VALUES (@name, @adress, @experience, @area, @DP, ");
                    sql.Append("@telephone, @idmedic)");

                    //Relaciona cada valor com seu respectivo parâmetro.
                    SqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    SqlCommand.Parameters.Add(new SqlParameter("@adress", adress));
                    SqlCommand.Parameters.Add(new SqlParameter("@experience", experience));
                    SqlCommand.Parameters.Add(new SqlParameter("@area", area));
                    SqlCommand.Parameters.Add(new SqlParameter("@DP", DP));
                    SqlCommand.Parameters.Add(new SqlParameter("@telephone", telephone));
                    SqlCommand.Parameters.Add(new SqlParameter("@idmedico", idMedic));

                    SqlCommand.CommandText = sql.ToString(); //Indica que o código SQL é o que deverá ser executado.
                    SqlCommand.Connection = connection; //Indica que a conexão dos comandos SQL é a string de conexão.
                    SqlCommand.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
                }
            }
            catch (Exception)
            {
                //Caso ocorra um erro no bloco try, entrará no catch, lugar em irá detectá-lo.
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o Administrador do Sistema.");
            }
        }

        //Método que armazena as informações da tabela Funcionário e retorna esses dados em ordem decrescente, baseado pelo id.
        public DataTable List()
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(Vet.Connection.StringConnection))
                {
                    Vet.Connection.Open();//tá só "Vet" pq foi simplificado pelo prórprio VS pq vai "." no nome, vulgo ' TesteBeg.Vet '

                    sql.Append("SELECT * FROM Medicos");
                    sql.Append(" ORDER BY ID_MEDICOS DESC");

                    SqlCommand.CommandText = sql.ToString();
                    SqlCommand.Connection = Connection;
                    DataTable(SqlCommand.ExecuteReader());
                    return DataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        //Método que irá Atualizar as informações conforme os parâmetros que possui entre parênteses.
        public void Change(int idMedic, string name, string adress, string experience, string area,
                            string DP, string telephone)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.StringConnection))
                {
                    Connection.Open();

                    sql.Append("UPDATE Medic");
                    sql.Append(" SET NAME_MEDIC=@name, ADRESS_MEDIC=@adress, ");
                    sql.Append("EXPERIENCE_MEDIC=@experience, AREA_MEDIC=@area, DISPONIBILTY_MEDIC=@DP  ");
                    sql.Append(" TELEPHONE_MEDIC=@telephone");

                    sql.Append(" WHERE (ID_MEDIC=@idmedic)");

                    SqlCommand.Parameters.Add(new SqlParameter("@name", name));
                    SqlCommand.Parameters.Add(new SqlParameter("@adress", adress));
                    SqlCommand.Parameters.Add(new SqlParameter("@experiencia", experience));
                    SqlCommand.Parameters.Add(new SqlParameter("@area", area));
                    SqlCommand.Parameters.Add(new SqlParameter("@DP", DP));
                    SqlCommand.Parameters.Add(new SqlParameter("@telefone", telephone));
                    SqlCommand.Parameters.Add(new SqlParameter("@idmedico", idMedic));

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

        //Método para excluir registros do banco.
        public void Excluir(int idMedic)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(Vet.Connection.StringConnection))
                {
                    Vet.Connection.Open();

                    sql.Append("DELETE FROM Medic");
                    sql.Append(" WHERE (ID_MEDIC = @idmedic)");

                    SqlCommand.Parameters.Add(new SqlParameter("@idmedic", idMedic));

                    SqlCommand.CommandText = sql.ToString();
                    SqlCommand.Connection = Connection;
                    SqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }

        internal static void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}