using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning_ae0429
{
    public static class UsersDal
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +"Data Source=D:\\DBUsers.accdb";
        public static OleDbConnection connection = new OleDbConnection(connectionString);
        
    }
}
