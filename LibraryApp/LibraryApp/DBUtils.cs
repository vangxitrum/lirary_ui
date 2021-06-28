using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"116.105.93.181";
            string database = "LibabryDB";
            string username = "sa";
            string password = "Chumhaywa112233";

            return DBServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
