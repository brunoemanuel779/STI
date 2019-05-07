using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace STI
{
   public class Conexao
    {
        public static SqlConnection getConnection()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=DB_STII;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return cnn;
        }
    }
}
