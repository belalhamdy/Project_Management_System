using Project_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace Project_Management_System
{

    class DBMS
    {
        private const string databaseName = "ProjectManager_DB";

        private SqlConnection co;
        private SqlConnectionStringBuilder builder;

        /// <summary>
        /// Establish a new instance of the Data Base Management System communicator.
        /// This prepares the connection to the DataSource "localhost" and to our database, 
        /// notice that this doesn't start the connection. Use "OpenConnection"
        /// </summary>
        public DBMS()
        {
            builder = new SqlConnectionStringBuilder { IntegratedSecurity = true, DataSource = "localhost" };

        }
        /// <summary>
        /// Tries to establish the connection
        /// </summary>
        private void OpenConnection()
        {
            co = new SqlConnection { ConnectionString = builder.ConnectionString };
            co.Open();
            co.ChangeDatabase(databaseName);
        }
        /// <summary>
        /// Closes the connection to the server and the database.
        /// </summary>
        private void CloseConnection()
        {
            co.Close();
            co.Dispose();
        }

        public int AddEmployee(Employee employee)
        {
            OpenConnection();

            const string queryString = "INSERT INTO employee([taskId],[name],[title],[workingHours],[cost]) output INSERTED.memberid VALUES(@taskId,@name,@title,@workingHours,@cost)";

            var command = new SqlCommand(queryString, co);

            command.Parameters.AddWithValue("@taskId", employee.TaskId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@name", employee.Name);
            command.Parameters.AddWithValue("@title", employee.Title);
            command.Parameters.AddWithValue("@workingHours", employee.HoursDay);
            command.Parameters.AddWithValue("@cost", employee.Cost);

            int? newId = (int?)command.ExecuteScalar();

            if (newId == null) throw new Exception("Error in inserting project in database please try again later.");

            CloseConnection();

            return (int)newId;
        }
        public int AddProject(Project project)
        {
            OpenConnection();

            const string queryString = "INSERT INTO project_Plan([weekStartDay],[workingHours],[projectName],[startDate],[dueDate])  output INSERTED.projectid VALUES(@weekStartDay,@workingHours,@projectName,@startDate,@dueDate)";

            var command = new SqlCommand(queryString, co);

            command.Parameters.AddWithValue("@weekStartDay", project.StartingOfWeek);
            command.Parameters.AddWithValue("@workingHours", project.NumberHrsPerDay);
            command.Parameters.AddWithValue("@projectName", project.ProjectName);
            command.Parameters.AddWithValue("@startDate", project.StartingDate);
            command.Parameters.AddWithValue("@dueDate", project.DueDate);
            

            int? newId = (int?)command.ExecuteScalar();

            if (newId == null) throw new Exception("Error in inserting project in database please try again later.");

            CloseConnection();
            
            return (int) newId;
        }
        public int AddTask(Task task)
        {
            OpenConnection();

            const string queryString = "INSERT INTO task([ParentTask],[taskType],[projectId],[startDate],[dueDate],[title],[actualWorkingHours],[isFinished])  output INSERTED.taskid VALUES(@ParentTask,@taskType,@projectId,@startDate,@dueDate,@title,@actualWorkingHours,@isFinished)";

            var command = new SqlCommand(queryString, co);

            command.Parameters.AddWithValue("@ParentTask", task.ParentTask ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@taskType", task.TaskType);
            command.Parameters.AddWithValue("@projectId", task.ProjectID);
            command.Parameters.AddWithValue("@startDate", task.StartingDate);
            command.Parameters.AddWithValue("@dueDate", task.DueDate);
            command.Parameters.AddWithValue("@title", task.Title);
            command.Parameters.AddWithValue("@actualWorkingHours", task.ActualWorkingHours ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@isFinished", task.IsFinished);

            int? newId= (int?) command.ExecuteScalar();

            if (newId == null) throw new Exception("Error in inserting task in database please try again later.");

            CloseConnection();

            return (int) newId;
        }

        public int AddDeliverable(Deliverable deliverable)
        {
            OpenConnection();

            const string queryString = "INSERT INTO deliverable([projectId],[isFinished],[title],[description])  output INSERTED.deliverableId VALUES(@projectId,@isFinished,@title,@description)";

            var command = new SqlCommand(queryString, co);

            command.Parameters.AddWithValue("@projectId", deliverable.ProjectID);
            command.Parameters.AddWithValue("@title", deliverable.Title);
            command.Parameters.AddWithValue("@description", deliverable.Description ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@isFinished", deliverable.IsFinished);
            
            int? newId = (int?)command.ExecuteScalar();

            if (newId == null) throw new Exception("Error in inserting deliverable in database please try again later.");

            CloseConnection();

            return (int) newId;
        }


        public void RemoveEmployee(int v)
        {
            RemoveEntry("employee", "memberId", v);
        }
        public void RemoveDeliverable(int v)
        {
            RemoveEntry("deliverable", "deliverableId", v);
        }
        public void RemoveProject(int v)
        {
            RemoveEntry("project_plan", "projectId", v);
        }
        public void RemoveTask(int v)
        {
            RemoveEntry("task", "taskId", v);
        }

        private void RemoveEntry(string tableName, string columnName, int id)
        {
            OpenConnection();

            var queryString = $"DELETE FROM {tableName} WHERE {columnName} = @Id";

            var command = new SqlCommand(queryString, co);

            command.Parameters.AddWithValue("@Id", id);


            var rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected < 1) throw new Exception($"Error in deleting {tableName} from database please try again later.");

            CloseConnection();
        }
        public List<Employee> GetAllEmployees()
        {
            const string queryString = "SELECT * FROM [employee]";
            var command = new SqlCommand(queryString);

            return GetEmployeeQueryExecute(command);
        }
        public List<Project> GetAllProjects()
        {
            const string queryString = "SELECT * FROM [project_plan]";
            var command = new SqlCommand(queryString);

            return GetProjectQueryExecute(command);
        }


        public Project GetProjectByID(int v)
        {
            const string queryString = "SELECT * FROM [project_plan] WHERE [projectId] = @PID";
            var command = new SqlCommand(queryString);

            command.Parameters.AddWithValue("@PID", v);

            var result = GetProjectQueryExecute(command);
            return result.Capacity == 0 ? null : result[0];
        }

        public List<Task> GetAllMainTasks(int projectID)
        {
            const string queryString = "SELECT * FROM [task] WHERE [ParentTask] is NULL";
            var command = new SqlCommand(queryString);
            return GetTaskQueryExecute(command);

        }

        public List<Task> GetAllSubTasks(int taskID)
        {
            const string queryString = "SELECT * FROM [task] WHERE [ParentTask] is not NULL";
            var command = new SqlCommand(queryString);
            return GetTaskQueryExecute(command);
        }

        public List<Employee> GetAllFreeEmployees()
        {
            const string queryString = "SELECT * FROM [employee] WHERE [taskId] is NULL";
            var command = new SqlCommand(queryString);
            return GetEmployeeQueryExecute(command);
        }

        public List<Employee> GetEmployeesOnTask(int taskID)
        {
            const string queryString = "SELECT * FROM [employee] WHERE [taskId] = @taskID";

            var command = new SqlCommand(queryString);
            command.Parameters.AddWithValue("@taskID", taskID);

            return GetEmployeeQueryExecute(command);
        }

        private List<Project> GetProjectQueryExecute(SqlCommand command)
        {
            OpenConnection();
            command.Connection = co;
            var reader = command.ExecuteReader();

            var ret = new List<Project>();
            try
            {
                while (reader.Read())
                {
                    ret.Add(new Project((int)reader["projectId"], (string)reader["projectName"], (DateTime)reader["startDate"], (DateTime)reader["dueDate"], (int)reader["workingHours"], (int)reader["weekStartDay"]));
                }

            }
            finally
            {
                reader.Close();
                CloseConnection();
            }


            return ret;
        }

        private List<Employee> GetEmployeeQueryExecute(SqlCommand command)
        {
            OpenConnection();

            command.Connection = co;
            var reader = command.ExecuteReader();

            var ret = new List<Employee>();
            try
            {
                while (reader.Read())
                {

                    ret.Add(new Employee((int)reader["memberId"], (string)reader["name"], (string)reader["title"], (int)reader["workingHours"], (int)reader["cost"], reader["taskId"] == System.DBNull.Value ? null : (int?)reader["taskId"]));
                }

            }
            finally
            {
                reader.Close();
                CloseConnection();
            }


            return ret;
        }
        private List<Deliverable> GetDeliverableQueryExecute(SqlCommand command)
        {
            OpenConnection();

            command.Connection = co;
            var reader = command.ExecuteReader();

            var ret = new List<Deliverable>();
            try
            {
                while (reader.Read())
                {
                    ret.Add(new Deliverable((int)reader["deliverableId"], (int)reader["projectId"], (bool)reader["isFinished"], (string)reader["title"], (string)reader["description"]));
                }

            }
            finally
            {
                reader.Close();
                CloseConnection();
            }


            return ret;
        }
        private List<Task> GetTaskQueryExecute(SqlCommand command)
        {
            OpenConnection();

            command.Connection = co;
            command.CommandText += " ORDER BY startDate";
            var reader = command.ExecuteReader();

            var ret = new List<Task>();

            try
            {
                while (reader.Read())
                {
                    ret.Add(new Task(reader["taskId"] == System.DBNull.Value ? null : (int?)reader["taskId"], (int)reader["ParentTask"], (int)reader["taskType"], (DateTime)reader["startDate"], (DateTime)reader["dueDate"], (string)reader["title"], reader["actualWorkingHours"] == System.DBNull.Value ? null : (int?)reader["actualWorkingHours"], (bool)reader["isFinished"]));
                }

            }
            finally
            {
                reader.Close();
                CloseConnection();
            }


            return ret;
        }

        public void UnselectAllEmployeesFromTask(int taskID)
        {
            OpenConnection();

            var queryString = "UPDATE employee SET taskId = null where memberId = @Id";

            var command = new SqlCommand(queryString, co);

            command.Parameters.AddWithValue("@Id", taskID);


            var rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected < 1) throw new Exception("Error in updating employees from database please try again later.");

            CloseConnection();
        }

        //TODO: TEST IT
        public void SetEmployeesOnTask(int taskID, List<int> employeesID)
        {
            OpenConnection();

            var queryString = "";

            var command = new SqlCommand(queryString, co);
            command.CommandText = $"UPDATE employee SET taskId = @Id where memberId in ({AddArrayParameters(command, employeesID, "employeeID")})";

            command.Parameters.AddWithValue("@Id", taskID);


            var rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected < 1) throw new Exception("Error in updating employees from database please try again later.");

            CloseConnection();
        }
        protected string AddArrayParameters(SqlCommand sqlCommand,List<int> array, string paramName)
        {
            /* An array cannot be simply added as a parameter to a SqlCommand so we need to loop through things and add it manually. 
             * Each item in the array will end up being it's own SqlParameter so the return value for this must be used as part of the
             * IN statement in the CommandText.
             */
            var parameters = new string[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                parameters[i] = string.Format("@{0}{1}", paramName, i);
                sqlCommand.Parameters.AddWithValue(parameters[i], array[i]);
            }

            return string.Join(", ", parameters);
        }

    }

}
