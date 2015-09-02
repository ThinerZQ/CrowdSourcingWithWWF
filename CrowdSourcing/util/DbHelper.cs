using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CrowdSourcing
{
    public class DbHelper
    {
        public static SqlConnection getSqlConnection()
        {
            string con = "Server=localhost;Database=CrowdSourcing;User ID=sa;Password=zhengqiang;Pooling=true;Max Pool Size=40000;Min Pool Size=0;";
            SqlConnection mycon = new SqlConnection(con);
            return mycon;
        }
    }
}
