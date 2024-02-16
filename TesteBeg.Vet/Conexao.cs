using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBeg.Vet
{
    public class Connection
    {
        public static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Carlos Eduardo\source\repos\TesteBeg.Vet\TesteBeg.Vet\mydatabase.mdf"";Integrated Security=True";
        public static string StringConnection
        { 
            get { return connection;  }
        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }
    }
}
