using Project_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Project_Management_System
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
            
        }
        /// <summary>
        /// Tries to establish the connection
        /// </summary>
        public void OpenConnection()
        {
            co.Open();
            co.ChangeDatabase(databaseName);
        }
        /// <summary>
        /// Closes the connection to the server and the database.
        /// </summary>
        public void CloseConnection()
        {
            co.Close();
            co.Dispose();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int v)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjects()
        {
            throw new NotImplementedException();
        }
        
        public void AddProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void RemoveProject(int v)
        {
            throw new NotImplementedException();
        }

        public Project GetProjectByID(int v)
        {
            throw new NotImplementedException();
        }
    }
}
