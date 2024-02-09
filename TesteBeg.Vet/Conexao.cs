using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBeg.Vet
{
    public class Conexao
    {
        private static string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Carlos Eduardo\source\repos\TesteBeg.Vet\TesteBeg.Vet\mydatabase.mdf"";Integrated Security=True";
        public static string stringConexao
        { 
            get { return conexao;  }
        }
    }
}
