using Project_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Project_Management_System
{

    class DBMS
    {
        private const string databaseName = "ProjectManager_DB";

        private readonly SqlConnection co;
        private SqlConnectionStringBuilder builder;

        /// <summary>
        /// Establish a new instance of the Data Base Management System communicator.
        /// This prepares the connection to the DataSource "localhost" and to our database, 
        /// notice that this doesn't start the connection. Use "OpenConnection"
        /// </summary>
        public DBMS()
        {
            builder = new SqlConnectionStringBuilder {IntegratedSecurity = true, DataSource = "localhost"};


            co = new SqlConnection {ConnectionString = builder.ConnectionString};

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
        }

        public List<Employee> GetAllEmployees()
        {
            OpenConnection();

            const string queryString = "SELECT * FROM [employee]";
            var command = new SqlCommand(queryString, co);
            var reader = command.ExecuteReader();

            var ret = new List<Employee>();
            try
            {
                while (reader.Read())
                {
                    var current = new Employee((int) reader["memberId"],(string) reader["name"],(string) reader["title"],(int) reader["workingHours"],(int) reader["cost"]);
                    ret.Add(current);
                }

            }
            finally
            {
                reader.Close();
                CloseConnection();
            }


            return ret;

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

        private List<Project> ProjectQueryExecute(string queryString)
        {
            OpenConnection();

            var command = new SqlCommand(queryString, co);
            var reader = command.ExecuteReader();

            var ret = new List<Project>();
            try
            {
                while (reader.Read())
                {
                    var current = new Project((int)reader["projectId"], (string)reader["projectName"], (DateTime)reader["startDate"], (DateTime)reader["dueDate"],(int) reader["workingHours"],(int) reader["weekStartDay"]);
                    ret.Add(current);
                }

            }
            finally
            {
                reader.Close();
                CloseConnection();
            }


            return ret;
        }

        public List<Employee> GetEmployeesOnTask(int taskID)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllFreeEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAllMainTasks(int projectID)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAllSubTasks(int taskID)
        {
            throw new NotImplementedException();
        }
    }
}
