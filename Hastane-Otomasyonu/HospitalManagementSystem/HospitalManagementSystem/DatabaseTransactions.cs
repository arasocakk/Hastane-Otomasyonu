using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class DatabaseTransactions
    {
        string connectionSentence = ConfigurationManager.ConnectionStrings["hospitalConnectionSentence"].ConnectionString;


        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection(connectionSentence);
            SqlConnection.ClearPool(connection);
            return connection;
        }
    }

    
}

