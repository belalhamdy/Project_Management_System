using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Project_Planner
{

    class DBMS
    {
        private static string databaseName = "Test";

        private SqlConnection co;
        private SqlConnectionStringBuilder builder;
        
        /// <summary>
        /// Establish a new instance of the Data Base Management System communicator.
        /// This prepares the connection to the DataSource "localhost" and to our database, 
        /// notice that this doesn't start the connection. Use "OpenConnection"
        /// </summary>
        public DBMS()
        {
            builder = new SqlConnectionStringBuilder();
            builder.IntegratedSecurity = true;
            
            builder.DataSource = "localhost";

            co = new SqlConnection();
            co.ConnectionString = builder.ConnectionString;
            co.ChangeDatabase(databaseName);
        }
        /// <summary>
        /// Tries to establish the connection
        /// </summary>
        public void OpenConnection()
        {
            co.Open();
        }
        /// <summary>
        /// Closes the connection to the server and the database.
        /// </summary>
        public void CloseConnection()
        {
            co.Close();
            co.Dispose();
        }

        
    }
}
