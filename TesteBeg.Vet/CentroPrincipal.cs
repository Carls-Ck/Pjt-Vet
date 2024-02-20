using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBeg.Vet
{
    public class CentroPrincipal
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.StringConnection))
                {
                    Connection.Open();

                    sql.Append("SELECT * FROM CentroPrincipal");
                    sql.Append(" ORDER BY ID_CONSULTAS DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = connection;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do sistema.");
            }
        }
    }
}
